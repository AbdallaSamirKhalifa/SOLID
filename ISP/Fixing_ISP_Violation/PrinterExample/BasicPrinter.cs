﻿namespace Fixing_ISP_Violation.PrinterExample
{
    public class BasicPrinter :  IPrint
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing: {content}");
        }

        
    }
}
