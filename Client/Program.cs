//This is also a modified template from Duende Identity Server 6 documentation. For more information https://docs.duendesoftware.com/identityserver/v6/quickstarts/1_client_credentials/


using IdentityModel.Client;
using System.Text.Json;

// discover endpoints from metadata
var client = new HttpClient();

var disco = await client.GetDiscoveryDocumentAsync(new DiscoveryDocumentRequest
{
    Address = "http://identityserver/",
    Policy =
    {
        RequireHttps = false
    }
});

if (disco.IsError)
{
    Console.WriteLine(disco.Error);
    return;
}

// request token
var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
{
    Address = disco.TokenEndpoint,
    ClientId = "client",
    ClientSecret = "secret",
    Scope = "EventsApi"
});

if (tokenResponse.IsError)
{
    Console.WriteLine(tokenResponse.Error);
    Console.WriteLine(tokenResponse.ErrorDescription);
    return;
}


Console.WriteLine(tokenResponse.Json);
Console.WriteLine("\n\n");

// call api
var apiClient = new HttpClient();
apiClient.SetBearerToken(tokenResponse.AccessToken);

var response = await apiClient.GetAsync("http://eventApi/identity");
if (!response.IsSuccessStatusCode)
{
    Console.WriteLine(response.StatusCode);
}
else
{
    var doc = JsonDocument.Parse(await response.Content.ReadAsStringAsync()).RootElement;
    Console.WriteLine(JsonSerializer.Serialize(doc, new JsonSerializerOptions { WriteIndented = true }));
}