﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core;
using Thinktecture.IdentityServer.Core.Services.InMemory;

namespace Thinktecture.IdentityServer.Tests
{
    public class TestUsers
    {
        public static IEnumerable<InMemoryUser> Get()
        {
            return new InMemoryUser[]
                {
                    new InMemoryUser{Subject = "818727", Username = "alice", Password = "alice", 
                        Claims = new Claim[]
                        {
                            new Claim(Constants.ClaimTypes.GivenName, "Alice"),
                            new Claim(Constants.ClaimTypes.FamilyName, "Smith"),
                            new Claim(Constants.ClaimTypes.Email, "AliceSmith@email.com"),
                        }, 
                        Provider = "Google", 
                        ProviderId = "123"
                    },
                    new InMemoryUser{Subject = "88421113", Username = "bob", Password = "bob", 
                        Claims = new Claim[]
                        {
                            new Claim(Constants.ClaimTypes.GivenName, "Bob"),
                            new Claim(Constants.ClaimTypes.FamilyName, "Smith"),
                            new Claim(Constants.ClaimTypes.Email, "BobSmith@email.com"),
                        }
                    },
                };
        }
    }
}
