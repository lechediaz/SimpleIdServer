﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Saml.Idp.Domains;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.Saml.Idp.Persistence.InMemory
{
    public class InMemoryRelyingPartyRepository : IRelyingPartyRepository
    {
        private readonly ICollection<RelyingPartyAggregate> _relyingParties;

        public InMemoryRelyingPartyRepository(ICollection<RelyingPartyAggregate> relyingParties)
        {
            _relyingParties = relyingParties;
        }

        public Task<bool> Add(RelyingPartyAggregate relyingPartyAggregate, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<RelyingPartyAggregate> Get(string id, CancellationToken cancellationToken)
        {
            return Task.FromResult(_relyingParties.FirstOrDefault(r => r.Id == id));
        }

        public Task<int> SaveChanges(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(RelyingPartyAggregate relyingPartyAggregate, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
