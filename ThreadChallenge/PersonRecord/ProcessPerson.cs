using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogSpace;
using LumenWorks.Framework.IO.Csv;

namespace PersonRecord
{
    public class ProcessPerson
    {

        public static void Process(string[] record, Options options)
        {

            string error = "";
            Person person = new Person();

            if (int.TryParse(record[0], out int id))
            {
                person.Id = id;
            }
            else {
                error = "Error";
            }
            person.Title = record[1];
            person.FirstName = record[2];
            person.MiddleName = record[3];
            person.LastName = record[4];
            person.Suffix = record[5];
            person.AddressLine1 = record[6];
            person.AddressLine2 = record[7];
            person.City = record[8];
            person.StateProvinceName = record[9];
            person.CountryRegionName = record[10];
            person.PostalCode = record[11];
            person.PhoneNumber = record[12];
            if (DateTime.TryParse(record[13], out DateTime date))
            {
                person.BirthDate = date;
            }
            else {
                error = "Error";
            }
            person.Education = record[14];
            person.Occupation = record[15];
            person.Gender = record[16];
            person.MaritialStatus = record[17];
            if (int.TryParse(record[18], out int flag))
            {
                person.HomeOwnerFlag = flag;
            }
            else
            {

                error = "Error";
            }

            if (int.TryParse(record[19], out int cars))
            {
                person.NumberCarsOwned = cars;
            }
            else
            {
                error = "Error";
            }

            if (int.TryParse(record[20], out int childrenHome))
            {
                person.NumberChildrenAtHome = childrenHome;
            }
            else
            {
                error = "Error";
            }

            if (int.TryParse(record[21], out int children))
            {
                person.TotalChildren = children;
            }
            else
            {
                error = "Error";
            }

            if (int.TryParse(record[22], out int income))
            {
                person.YearlyIncome = income;
            }
            else
            {
                error = "Error";
                //LogManager.LogThis("La persona con id " + person.Id + " no pudo ser agregada", "Error");
                //continue;
            }

            WriteTextFile.Write(person, error);
            

        }
    }
}
