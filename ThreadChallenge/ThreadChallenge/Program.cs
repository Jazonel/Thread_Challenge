using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PersonRecord;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;
using System.Reflection;
using LogSpace;
using System.Data.Common;
using System.Configuration;

namespace ThreadChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Tuple <CsvReader, Dictionary<string, int>> csvInformation = ReadInformation.DeserializeCsv("ThreadData.csv");

            foreach(string[] test in csvInformation.Item1)
            {
                 ProcessPerson.Process(test);           
            }
            //long temporal = csvInformation.Item1.CurrentRecordIndex;
            //WriteTextFile.Write(miLista);
            Console.ReadLine();



        }
    }
}
