namespace Violating_ISP.PrinterExample
{
    public class AdvancedPrinter : IPrinter
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
    }

}
