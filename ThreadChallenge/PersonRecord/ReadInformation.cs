using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogSpace;
using LumenWorks.Framework.IO.Csv;
using System.IO;

namespace PersonRecord
{
    public class ReadInformation
    {
        private static Dictionary<string, int> csvMap = new Dictionary<string, int>();


        public static Tuple<CsvReader, Dictionary<string, int>> DeserializeCsv(string path)
        {
            Tuple<CsvReader, Dictionary<string, int>> csvInformation;
            CsvReader csvFile = new CsvReader(new StreamReader(path), true);
            
                int fieldCount = csvFile.FieldCount;
                string[] headers = csvFile.GetFieldHeaders();

                for (int i = 0; i < fieldCount; i++)
                {
                    csvMap[headers[i]] = i;
                }
                

                return csvInformation = new Tuple<CsvReader, Dictionary<string, int>>(csvFile, csvMap);
                /*
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
                    if (int.TryParse(csvFile[csvMap["HomeOwnerFlag"]], out int flag))
                    {
                        recordObject.homeOwnerFlag = flag;
                    }
                    else
                    {

                        continue;
                    }

                    if (int.TryParse(csvFile[csvMap["NumberCarsOwned"]], out int cars))
                    {
                        recordObject.numberCarsOwned = cars;
                    }
                    else
                    {
                        continue;
                    }

                    if (int.TryParse(csvFile[csvMap["NumberChildrenAtHome"]], out int childrenHome))
                    {
                        recordObject.numberChildrenAtHome = childrenHome;
                    }
                    else
                    {
                        continue;
                    }

                    if (int.TryParse(csvFile[csvMap["TotalChildren"]], out int children))
                    {
                        recordObject.totalChildren = children;
                    }
                    else {
                        continue;
                    }

                    if (int.TryParse(csvFile[csvMap["YearlyIncome"]], out int income))
                    {
                        recordObject.yearlyIncome = income;
                    }
                    else {
                        LogManager.LogThis("La persona con id " + recordObject.id + " no pudo ser agregada", "Error");
                        continue;
                    }
                    */

                //WriteTextFile.Write(recordObject);
                //recordList.Add(recordObject);
            

            

        }


    }
}
