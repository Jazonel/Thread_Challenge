namespace PersonRecord
{
    using System;
    using System.Collections.Generic;   
    public partial class Person
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvinceName { get; set; }
        public string CountryRegionName { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public string Gender { get; set; }
        public string MaritialStatus { get; set; }
        public int HomeOwnerFlag { get; set; }
        public int NumberCarsOwned { get; set; }
        public int NumberChildrenAtHome { get; set; }
        public int TotalChildren { get; set; }
        public int YearlyIncome { get; set; }
    }
}
