using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonRecord
{
    public class WriteTextFile
    {

        public static void Write(List<RecordInformation> records)
        {
            foreach(RecordInformation record in records)
            {
               File.WriteAllText(PutInOneLine(record)[0], PutInOneLine(record)[1]);
            }
        }


        private static string[] PutInOneLine(RecordInformation records)
        {
            string[] toWrite = new string[2];
            string name = records.id + ".txt";
            string path = @"C:\Person\" + name;
            string information = "Id:" + records.id + "\n" +
                                 "Title:" + records.title + "\n" +
                                 "First Name:" + records.firstName + "\n" +
                                 "Middle Name:" + records.middleName + "\n" +
                                 "Suffix:" + records.suffix + "\n" +
                                 "Address Line1:" + records.addressLine1 + "\n" +
                                 "Address Line2:" + records.addressLine2 + "\n" +
                                 "City:" + records.city + "\n" +
                                 "State Province Name:" + records.stateProvinceName + "\n" +
                                 "Country Region Name:" + records.countryRegionName + "\n" +
                                 "Postal Code:" + records.postalCode + "\n" +
                                 "Phone Number:" + records.phoneNumber + "\n" +
                                 "Birth Date:" + Convert.ToString(records.birthDate) + "\n" +
                                 "Education:" + records.education + "\n" +
                                 "Occupation:" + records.occupation + "\n" +
                                 "Gender:" + records.gender + "\n" +
                                 "Maritial Status:" + records.maritalStatus + "\n" +
                                 "Home Owner Flag:" + records.homeOwnerFlag.ToString() + "\n" +
                                 "Number Cars Owned:" + records.numberCarsOwned.ToString() + "\n" +
                                 "Number Children At Home:" + records.numberChildrenAtHome.ToString() + "\n" +
                                 "Total CHildren:" + records.totalChildren.ToString() + "\n" +
                                 "Yearly Income:" + records.yearlyIncome.ToString();

            toWrite[0] = path;
            toWrite[1] = information;
            return toWrite;
        }
        
    }
}
