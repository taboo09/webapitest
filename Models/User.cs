using System;

namespace webapitest.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public Company Company { get; set; }
    }
}