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
       
        /// <summary>
        /// Reads The CSV
        /// </summary>
        /// <param name="path">Path that contains the CSV file</param>
        /// <returns> CSV Matrix of strings</returns>
        public static CsvReader ReadCsv(string path)
        {        
            return new CsvReader(new StreamReader(path), true);
        }


    }
}
