using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Rajanell.TechStack.Phonebook.Client.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Phonebook.WebUI.HttpHandlers
{
    public class BearerTokenHandler : DelegatingHandler
    {
        private readonly AppSettings _appSettings;

        public BearerTokenHandler(IOptions<AppSettings> options)
        {
            _appSettings = options.Value;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var client = new HttpClient();

            var disco = await client.GetDiscoveryDocumentAsync(_appSettings.IDP);
            // request token
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,
                ClientId = _appSettings.ClientAppId,
                ClientSecret = _appSettings.ClientSecret,
                Scope = _appSettings.APIScope
            });

            var results = JsonSerializer.Deserialize<AuthToken>(tokenResponse.Json.ToString(), 
                new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

            //this token needs to catched
            var accessToken = results.Access_token;

            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                request.SetBearerToken(accessToken);
                //request.Headers.Add("Authorization", accessToken);
            }

            return await base.SendAsync(request, cancellationToken);
        }
        private class AuthToken
        {
            public string Access_token { get; set; }
            public string Token_type { get; set; }
            public int Expires_in { get; set; }
        }
    }
}
