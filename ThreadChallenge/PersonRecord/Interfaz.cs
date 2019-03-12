using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRecord
{
    public class Interfaz
    {
        /// <summary>
        /// Write in console all the options for the execution of the application
        /// </summary>
        /// <returns></returns>
        public static Options OpcionesDeInterfaz()
        {

            string temporal;
            bool printOnConsole;
            bool WriteTxtFile;
            bool WriteInDB;
            bool ShowActualStatus;

            Console.WriteLine("The program will read a CSV file, an it will fill a Data base using all the registers found in the file");
            Console.WriteLine();
            Console.WriteLine("Configure the next oprions with (Yes/No) as you wish. Answer as shown next(y/n)");
            Console.WriteLine();
            Console.Write("Do you want the application to print id and age of each person? ");
            temporal = Console.ReadLine();
            if (temporal == "y")
            {
                printOnConsole = true;
            }
            else {printOnConsole = false;}

            Console.WriteLine();
            Console.Write("Do you want the application to create a .txt for each person in the person folder? ");
            temporal = Console.ReadLine();
            if (temporal == "y")
            {
                WriteTxtFile = true;
            }
            else { WriteTxtFile = false; }

            Console.WriteLine();
            Console.Write("Do you want the application to insert the records into de Data base? ");
            temporal = Console.ReadLine();
            if (temporal == "y")
            {
                WriteInDB = true;
            }
            else { WriteInDB = false; }

            Console.WriteLine();
            Console.Write("Do you want the application to log the procces trough? ");
            temporal = Console.ReadLine();
            if (temporal == "y")
            {
                ShowActualStatus = true;
            }
            else { ShowActualStatus = false; }


            return new Options(printOnConsole, WriteTxtFile, WriteInDB, ShowActualStatus);
        }
    }
}
