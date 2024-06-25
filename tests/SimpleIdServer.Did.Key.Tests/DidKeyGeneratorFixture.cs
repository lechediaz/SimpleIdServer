﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using NUnit.Framework;

namespace SimpleIdServer.Did.Key.Tests;

public class DidKeyGeneratorFixture
{
    [Test]
    public async Task When_Generate_DidKey_Then_DidDocument_Is_Correct()
    {
        // ARRANGE
        var generator = DidKeyGenerator.New();
        var resolver = DidKeyResolver.New();

        // ACT
        var did = generator.GenerateRandom();
        var resolved = await resolver.Resolve(did, CancellationToken.None);

        // ASSERT
        Assert.IsNotNull(resolved);
    }

    [Test]
    public async Task When_Generate_DidKey_Jwk_Then_DidDocument_Is_Correct()
    {
        // ARRANGE
        var generator = DidKeyGenerator.New();
        var resolver = DidKeyResolver.New();

        // ACT
        var did = generator.GenerateRandomJwk();
        var resolved = await resolver.Resolve(did, CancellationToken.None);

        // ASSERT
        Assert.IsNotNull(resolved);
    }
}
