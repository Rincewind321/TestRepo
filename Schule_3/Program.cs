﻿using System;
using System.Collections.Generic;

namespace Schule_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sTest = "Dies ist ein komplexer Testtext mit komischen üs und ös und äs für ausführliche Tests";

            List<char> sTestList = new List<char>() { Convert.ToChar(sTest)};
        }
    }
}
