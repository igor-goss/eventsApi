using Duende.IdentityServer.Models;

namespace IdentityServer;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        { 
            new IdentityResources.OpenId()
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            {
                new ApiScope(name: "EventsApi", displayName: "EventsManagmentAPI")
            };

    public static IEnumerable<Client> Clients =>
        new Client[] 
            {
                new Client
                {
                    ClientId = "client",

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    AllowedScopes = { "EventsApi" }
                }
            };
}