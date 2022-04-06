using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketsPurchaseTests.Pages
{
    public class BillingDetailsDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CountryRegion { get; set; }
        public string StreetAddress { get; set; }
        public string TownCity { get; set; }
        public string StateCounty{ get; set; }
        public string PostcodeZip{ get; set; }
        public string Phone{ get; set; }
        public string EmailAddress{ get; set; }
        public bool DirectBankTransfer { get; set; } = true;
        public bool CheckPayments { get; set; } = false;
        public bool CreateAnAccount { get; set; } = false;

    }
}
