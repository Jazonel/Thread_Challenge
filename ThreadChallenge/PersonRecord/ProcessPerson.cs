using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRecord
{
    public class ProcessPerson
    {
        public static void test() {

            using (PersonDBEntities context = new PersonDBEntities())
            {
                Person person = new Person
                {
                    Id = 6546,
                    BirthDate = DateTime.Now,
                    HomeOwnerFlag = 1,
                    NumberCarsOwned = 1,
                    NumberChildrenAtHome =0,
                    TotalChildren = 5,
                    YearlyIncome = 8
                   
                };

                context.Persons.Add(person);
                context.SaveChanges();
            }

        }
    }
}
