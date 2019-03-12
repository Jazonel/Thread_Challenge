using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LogSpace;
using LumenWorks.Framework.IO.Csv;

namespace PersonRecord
{
    public class ProcessPerson
    {
        /// <summary>
        /// Proces the CSV information, introducing it into an object. Person
        /// </summary>
        /// <param name="record">Array of strings that contains all the record information</param>
        /// <param name="options">Object that will allow or prevent functionalities</param>
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

            }


            LogManager log = new LogManager();

            if (error != "Error")
            {
                if (options.printOnConsole)
                {
                    Thread printIdAge = new Thread(PrintOnConsole.PrintIdAge);
                    printIdAge.Start(person);
                    if (options.ShowActualStatus)
                    {
                        log.LogThis("The person with id " + person.Id + " was print on console successfully.", "Info");
                    }
                }
                if (options.WriteTxtFile)
                {
                    Thread writeTxt = new Thread(WriteTextFile.Write);
                    writeTxt.Start(person);
                    if (options.ShowActualStatus)
                    {
                        log.LogThis("The txt of the person with id " + person.Id + " was written successfully", "Info");
                    }
                }
                if (options.WriteInDB)
                {
                    Thread writeDB = new Thread(WriteInDB.WriteNewRecordDB);
                    writeDB.Start(person);
                    if (options.ShowActualStatus)
                    {
                        log.LogThis("The person with id " + person.Id + " was insert on the data base successfully", "Info");
                    }
                }
            }
            else {
                log.LogThis("The person with id " + person.Id + " could not been procceded due to a missing file", "Error");
            }
            

        }
    }
}
