namespace Fixing_ISP_Violation.PrinterExample
{
    public class AdvancedPrinter : IPrint, IFax, IScan,ICopy
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing: {content}");
        }

        public void Scan()
        {
            Console.WriteLine($"Scanning...");

        }

        public void Fax()
        {
            Console.WriteLine($"Faxing...");


        }
        
        public void Copy()
        {
            Console.WriteLine($"Creating a copy...");


        }
    }
}
