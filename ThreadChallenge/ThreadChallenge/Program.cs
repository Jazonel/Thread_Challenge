﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PersonRecord;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace ThreadChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RecordInformation> miLista = ReadInformation.DeserializeCsv("ThreadData.csv");
            



        }
    }
}
