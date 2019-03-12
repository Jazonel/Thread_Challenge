using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogSpace;

namespace PersonRecord
{
    class WriteInDB
    {
        /// <summary>
        /// Writes a new row in the data base
        /// </summary>
        /// <param name="person"> Person's information that will be inserted in the data base</param>
        public static void WriteNewRecordDB(object person)
        {
            LogManager log = new LogManager();
            using (PersonDBEntities context = new PersonDBEntities())
            {
                
                context.Persons.Add((Person)person);
                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    log.LogThis("The person with the id " + ((Person)person).Id + " is already in the Data base", "Warning");
                    throw;

                }
            }
            
        }
    }
}
