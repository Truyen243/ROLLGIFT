﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass.DatabaseType
{
   public interface IDatabaseConnect
    {
        List<string> ReadFile(string path);
        void WriteToFile(string path, List<string> vs);
    }
}