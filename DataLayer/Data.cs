using System;
using System.Collections.Generic;
using webapitest.Models;

namespace webapitest.DataLayer
{
    public static class Data
    {
        public static IEnumerable<User> Users()
        {
            return _users;
        }

        private static readonly User[] _users = new[]
        {
            new User
            {
                Id = Guid.NewGuid(),
                Name = "John Smith",
                Address = new Address 
                { 
                    AddressId = 1, 
                    Number = 3, 
                    Street = "Alexander St", 
                    City = "Birmingham", 
                    County = "Staffordshire" 
                    },
                Contact = new Contact 
                { 
                    ContactId = 11, 
                    MobilePhone = "07552333251", 
                    EmailAddress = "JohnSmith@example.com", 
                    LinkedIn = "https://www.linkedin.com/in/johnsmith/" 
                }
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Melanie Smith",
                Address = new Address 
                { 
                    AddressId = 2, 
                    Number = 125, 
                    Street = "Hull Street", 
                    City = "Birmingham", 
                    County = "Staffordshire" 
                    },
                Contact = new Contact 
                { 
                    ContactId = 11, 
                    MobilePhone = "0745210021", 
                    EmailAddress = "MelanieSmith@example.com", 
                    LinkedIn = "https://www.linkedin.com/in/melaniesmith/" 
                }
            }
        };
    }
}