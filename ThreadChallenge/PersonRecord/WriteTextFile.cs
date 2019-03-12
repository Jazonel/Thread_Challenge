using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LogSpace;

namespace PersonRecord
{
    public class WriteTextFile
    {
        /// <summary>
        /// Writes a txt in wich will be all the record information. The name will be the id of the current record
        /// </summary>
        /// <param name="record">Record information that will be written in the txt</param>
        public static void Write(object record)
        { 
            File.WriteAllText(PutInOneLine((Person)record)[0], PutInOneLine((Person)record)[1]);          
                   
        }

        /// <summary>
        /// takes the record information and concatenate all in one string
        /// </summary>
        /// <param name="records">Information to concatenate</param>
        /// <returns></returns>
        private static string[] PutInOneLine(Person records)
        {
            string[] toWrite = new string[2];
            string name = records.Id + ".txt";
            string path = @"C:\Person\" + name;
            string information = "Id:" + records.Id + "\n" +
                                 "Title:" + records.Title + "\n" +
                                 "First Name:" + records.FirstName + "\n" +
                                 "Middle Name:" + records.MiddleName + "\n" +
                                 "Suffix:" + records.Suffix + "\n" +
                                 "Address Line1:" + records.AddressLine1 + "\n" +
                                 "Address Line2:" + records.AddressLine2 + "\n" +
                                 "City:" + records.City + "\n" +
                                 "State Province Name:" + records.StateProvinceName + "\n" +
                                 "Country Region Name:" + records.CountryRegionName + "\n" +
                                 "Postal Code:" + records.PostalCode + "\n" +
                                 "Phone Number:" + records.PhoneNumber + "\n" +
                                 "Birth Date:" + Convert.ToString(records.BirthDate) + "\n" +
                                 "Education:" + records.Education + "\n" +
                                 "Occupation:" + records.Occupation + "\n" +
                                 "Gender:" + records.Gender + "\n" +
                                 "Maritial Status:" + records.MaritialStatus + "\n" +
                                 "Home Owner Flag:" + records.HomeOwnerFlag.ToString() + "\n" +
                                 "Number Cars Owned:" + records.NumberCarsOwned.ToString() + "\n" +
                                 "Number Children At Home:" + records.NumberChildrenAtHome.ToString() + "\n" +
                                 "Total CHildren:" + records.TotalChildren.ToString() + "\n" +
                                 "Yearly Income:" + records.YearlyIncome.ToString();

            toWrite[0] = path;
            toWrite[1] = information;
            return toWrite;
        }

    }
}
