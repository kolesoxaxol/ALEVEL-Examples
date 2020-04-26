using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;

namespace BlogAuthServer
{
    public class Config
    {
        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>
            {
                new TestUser{Username="Mikhail",  Password="password1", SubjectId="1"},
                new TestUser{ Username=  "Yevhenii",  Password="password2", SubjectId="2"}
            };
        }
        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("BlogApi", "Api for Blog")

            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> {
                new Client{
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {
                        new Secret("secret".Sha256())
                    },

                    AllowedScopes = {"BlogApi"}

                },
                // Resource Owner Password grand type
                new Client
                {
                    ClientId="ro.client",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    ClientSecrets = { new Secret("secret".Sha256())},
                       AllowedScopes = {"BlogApi"}
                }

            };
        }
    }
}
