using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRecord
{
    public class PrintOnConsole
    {
        /// <summary>
        /// Prints the id and age of te person in console
        /// </summary>
        /// <param name="record">Person's Information</param>
        public static void PrintIdAge(object record)
        {

            int age = DateTime.Today.Year - ((Person)record).BirthDate.Year;
            Console.WriteLine("The person with the id " + ((Person)record).Id + " is " + age + " years old");
            
        }
    }
}
