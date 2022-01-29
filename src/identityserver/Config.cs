﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace identityserver
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
        {
            new ApiScope("APIProduct1", "API Security with .net core and IdentityServer4.")
        };

        public static IEnumerable<Client> Clients =>
          new List<Client>
          {
              new Client{
                  ClientId = "client",
                  AllowedGrantTypes = GrantTypes.ClientCredentials,
                  ClientSecrets = { new Secret("topsecret".Sha256())},
                  AllowedScopes = { "APIProduct1" }
              }
          };
    }
}