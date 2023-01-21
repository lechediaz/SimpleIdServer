﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleIdServer.IdServer.Api.BCCallback;
using SimpleIdServer.IdServer.Exceptions;
using SimpleIdServer.IdServer.Jobs;
using SimpleIdServer.IdServer.Jwt;
using SimpleIdServer.IdServer.Store;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.Api.BCAuthorize
{
    public class BCCallbackController : BaseController
    {
        private readonly IJwtBuilder _jwtBuilder;
        private readonly IBCAuthorizeRepository _bcAuthorizeRepository;
        private readonly IRecurringJobManager _recurringJobManager;

        public BCCallbackController(IJwtBuilder jwtBuilder, IBCAuthorizeRepository bCAuthorizeRepository, IRecurringJobManager recurringJobManager)
        {
            _jwtBuilder = jwtBuilder;
            _bcAuthorizeRepository = bCAuthorizeRepository;
            _recurringJobManager = recurringJobManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BCCallbackParameter parameter, CancellationToken cancellationToken)
        {
            try
            {
                var idToken = ExtractBearerToken();
                var extractionResult = _jwtBuilder.ReadSelfIssuedJsonWebToken(idToken);
                if (extractionResult.Error != null) return BuildError(System.Net.HttpStatusCode.Unauthorized, ErrorCodes.ACCESS_DENIED, extractionResult.Error);
                var userSubject = extractionResult.Jwt.Subject;
                var bcAuthorize = await _bcAuthorizeRepository.Query().Include(a => a.Histories).FirstOrDefaultAsync(b => b.Id == parameter.AuthReqId, cancellationToken);
                if (bcAuthorize == null) return BuildError(HttpStatusCode.NotFound, ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.UNKNOWN_BC_AUTHORIZE, parameter.AuthReqId));
                switch(parameter.ActionEnum)
                {
                    case BCCallbackActions.CONFIRM:
                        {
                            if (bcAuthorize.LastStatus != Domains.BCAuthorizeStatus.Pending) return BuildError(HttpStatusCode.BadRequest, ErrorCodes.INVALID_REQUEST, ErrorMessages.BC_AUTHORIZE_NOT_PENDING);
                            bcAuthorize.Confirm();
                        }
                        break;
                    case BCCallbackActions.REJECT:
                        {
                            if (bcAuthorize.LastStatus != Domains.BCAuthorizeStatus.Pending) return BuildError(HttpStatusCode.BadRequest, ErrorCodes.INVALID_REQUEST, ErrorMessages.BC_AUTHORIZE_NOT_PENDING);
                            bcAuthorize.Reject();
                        }
                        break;
                }

                await _bcAuthorizeRepository.SaveChanges(cancellationToken);
                _recurringJobManager.Trigger(nameof(BCNotificationJob));
                return new NoContentResult();
            }
            catch (OAuthException ex)
            {
                return BuildError(ex);
            }
        }
    }
}
