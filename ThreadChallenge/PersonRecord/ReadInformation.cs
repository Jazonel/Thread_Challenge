using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;
using System.IO;

namespace PersonRecord
{
    public class ReadInformation
    {
        private static Dictionary<string, int> csvMap = new Dictionary<string, int>();
        public static List<RecordInformation> recordList = new List<RecordInformation>();


        public static List<RecordInformation> DeserializeCsv(string path)
        {
            using (CsvReader csvFile = new CsvReader(new StreamReader(path), true))
            {
                int fieldCount = csvFile.FieldCount;
                string[] headers = csvFile.GetFieldHeaders();

                for (int i = 0; i < fieldCount; i++)
                {
                    csvMap[headers[i]] = i;
                }

                while (csvFile.ReadNextRecord())
                {
                    RecordInformation recordObject = new RecordInformation();
                    recordObject.id = csvFile[csvMap["Id"]];
                    recordObject.title = csvFile[csvMap["Title"]];
                    recordObject.firstName = csvFile[csvMap["FirstName"]];
                    recordObject.lastName = csvFile[csvMap["LastName"]];
                    recordObject.middleName = csvFile[csvMap["MiddleName"]];
                    recordObject.lastName = csvFile[csvMap["LastName"]];
                    recordObject.suffix = csvFile[csvMap["Suffix"]];
                    recordObject.addressLine1 = csvFile[csvMap["AddressLine1"]];
                    recordObject.addressLine2 = csvFile[csvMap["AddressLine2"]];
                    recordObject.city = csvFile[csvMap["City"]];
                    recordObject.stateProvinceName = csvFile[csvMap["StateProvinceName"]];
                    recordObject.countryRegionName = csvFile[csvMap["CountryRegionName"]];
                    recordObject.postalCode = csvFile[csvMap["PostalCode"]];
                    recordObject.phoneNumber = csvFile[csvMap["PhoneNumber"]];
                    recordObject.birthDate = Convert.ToDateTime(csvFile[csvMap["BirthDate"]]);
                    recordObject.education = csvFile[csvMap["Education"]];
                    recordObject.occupation = csvFile[csvMap["Occupation"]];
                    recordObject.gender = csvFile[csvMap["Gender"]];
                    recordObject.maritalStatus = csvFile[csvMap["MaritalStatus"]];
                    recordObject.homeOwnerFlag = Int32.Parse(csvFile[csvMap["HomeOwnerFlag"]]);
                    recordObject.numberCarsOwned = Int32.Parse(csvFile[csvMap["NumberCarsOwned"]]);
                    recordObject.numberChildrenAtHome = Int32.Parse(csvFile[csvMap["NumberChildrenAtHome"]]);
                    recordObject.totalChildren = Int32.Parse(csvFile[csvMap["TotalChildren"]]);
                    if (int.TryParse(csvFile[csvMap["YearlyIncome"]], out int income))
                    {
                        recordObject.yearlyIncome = income;
                    }
                    recordList.Add(recordObject);
                }

            }
            return recordList;
        }


    }
}
