﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerProgram
{
    public class SacnManager
    {

        PrintScanner _printer = new PrintScanner();

        public void ScanDocument(PrintScanner scanner)
        {
            scanner.Scan();
        }
        

    }
}
