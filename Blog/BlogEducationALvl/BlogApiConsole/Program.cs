using IdentityModel.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace BlogApiConsole
{
    class Program
    {
        static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();

        private static async Task MainAsync()
        {
            HttpClient httpClient = new HttpClient();

            //Below code will give you discovery document response previously we were creating using DiscoveryClient()

            // They have created `.GetDiscoveryDocumentAsync()` extension method to get discovery document.

            DiscoveryDocumentResponse discoveryDocument = await httpClient.GetDiscoveryDocumentAsync("http://localhost:5000");
            // discover all endpoints using metadata identity server
            if (discoveryDocument.IsError)
            {
                Console.WriteLine(discoveryDocument.Error);
                return;
            }



            // Grab bear token
            //  var tokenClient = new TokenClient( options);
            var tokenResponse = await httpClient.RequestTokenAsync(new TokenRequest
            {
                Address = "https://demo.identityserver.io/connect/token",
                //GrantType = "custom",

                ClientId = "client",
                ClientSecret = "secret",

                //Parameters =
                //{
                //    { "custom_parameter", "custom value"},
                //    { "scope", "api1" }
                //}
            });

            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
            }

            Console.WriteLine(tokenResponse.Json);
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
