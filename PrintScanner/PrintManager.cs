using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerProgram 
{

    public class PrintManager 
 
    {
        PrintScanner _printer = new PrintScanner();
       
        public void PrintDocument(PrintScanner printer)
        {
            printer.Print();
        }

    }
}
