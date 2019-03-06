using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRecord
{
    public class RecordInformation
    {
        public string id { get; set; }
        public string title { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string suffix { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string stateProvinceName { get; set; }
        public string countryRegionName { get; set; }
        public string postalCode { get; set; }
        public string phoneNumber { get; set; }
        public DateTime birthDate { get; set; }
        public string education { get; set; }
        public string occupation { get; set; }
        public string gender { get; set; }
        public string maritalStatus { get; set; }
        public int homeOwnerFlag { get; set; }
        public int numberCarsOwned { get; set; }
        public int numberChildrenAtHome { get; set; }
        public int totalChildren { get; set; }
        public int yearlyIncome { get; set; }
    }
}
