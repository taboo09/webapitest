using System;

namespace webapitest.Models
{
    public class Company
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Branch Branch { get; set; }
    }
}