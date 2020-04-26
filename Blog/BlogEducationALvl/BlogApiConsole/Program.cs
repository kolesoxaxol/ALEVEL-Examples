using IdentityModel.Client;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace BlogApiConsole
{
    class Program
    {
        static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();

        private static async Task MainAsync()
        {

            var client = new HttpClient();

            var discoRO = await client.GetDiscoveryDocumentAsync("http://localhost:5000");

            if (discoRO.IsFaulted)
            {
                Console.WriteLine(discoRO.Result);
                return;
            }



            // Grab user token using RecoverOwnerPasswordType
       
            var tokenClienResp = await client.RequestTokenAsync(new TokenRequest
            {
                Address = discoRO.TokenEndpoint,
                ClientId = "ro.client",
                ClientSecret = "secret",
            });
            //ToDO: finish this example

          //  var Roresponse = tokenClienResp.RequestResourceOwnerPasswordAsync();




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


            client.SetBearerToken(tokenResponse.AccessToken);

            var customerInfo = new StringContent(JsonConvert.SerializeObject(new { Id = 10, FirstName = "KOliesnik", LastName = "Yevhenii" }), Encoding.UTF8, "application/json");
            var createCustomerResponse = await client.PostAsync("http://localhost:44301/api/customers", customerInfo);

            if (!createCustomerResponse.IsSuccessStatusCode)
            {
                Console.WriteLine(createCustomerResponse.StatusCode);
            }

            var getCustomerResponse = await client.GetAsync("https://localhost:44301/api/users");


            if (!getCustomerResponse.IsSuccessStatusCode)
            {
                Console.WriteLine(getCustomerResponse.StatusCode);
            }
            else
            {
                var content = await getCustomerResponse.Content.ReadAsStringAsync();
                Console.WriteLine(content);
                
            }

        }

    }
}
