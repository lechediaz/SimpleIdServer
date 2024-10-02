﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
namespace SimpleIdServer.IdServer.IntegrationEvents;
public class UpdateScopeResourcesSuccessEvent : IIntegrationEvent
{
    public string EventName => nameof(UpdateScopeResourcesSuccessEvent);
    public string Realm { get; set; }
    public string Name { get; set; }
    public List<string> Resources { get; set; }
}