using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRecord
{
    public class Options
    {
        public bool printOnConsole;
        public bool WriteTxtFile;
        public bool WriteInDB;
        public bool ShowActualStatus;

        public Options(bool _printOnConsole, bool _WriteTxtFile, bool _WriteInDB, bool _ShowActualStatus)
        {
            printOnConsole = _printOnConsole;
            WriteTxtFile = _WriteTxtFile;
            WriteInDB = _WriteInDB;
            ShowActualStatus = _ShowActualStatus;
        }
    }
}
