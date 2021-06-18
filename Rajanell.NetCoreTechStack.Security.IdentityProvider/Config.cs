// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace Rajanell.NetCoreTechStack.Security.IdentityProvider
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResource(
                    "roles",
                    "Your role(s)",
                    new List<string>() { "role" })
            };
        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                  new ApiResource("StoreAPI", "Store API")
            };
        public static IEnumerable<ApiScope> ApiScopes =>
              new List<ApiScope>
            {
                new ApiScope("StoreAPI", "Store API")
            };

        public static IEnumerable<Client> Clients =>
            new Client[] 
            { 
                new Client{ 
                    ClientId = "StoreClient", //unique Identifier
                    ClientName = "Store Web App", //description
                    AllowedGrantTypes = GrantTypes.Code, //redirection based code is delivered via browser URI redirection
                    RedirectUris = new List<string>()
                    {
                        "https://localhost:44310/signin-oidc" //URI to receive tokens
                    },
                    PostLogoutRedirectUris = new List<string>()
                    {
                        "https://localhost:44310/signout-callback-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Address,
                        "roles",
                        "StoreAPI"
                    },
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    }
                }, new Client
                {
                    ClientId = "StoreClientApp", 
                    AllowedGrantTypes = GrantTypes.ClientCredentials,// no interactive user, use the clientid/secret for authentication               
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())     // secret for authentication
                    },
                    // scopes that client has access to
                    AllowedScopes = { "StoreAPI" }
                }
            };
    }
}