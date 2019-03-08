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

        }


    }
}
