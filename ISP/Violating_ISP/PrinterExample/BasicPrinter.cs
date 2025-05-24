namespace Violating_ISP.PrinterExample
{
    public class BasicPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing: {content}");
        }

        public void Scan()
        {
            //we are forced to implement this functionality because it violates the ISP

            throw new NotSupportedException("The basic printer doesn't have the scan functionality.");
        }

        public void Fax()
        {
            //we are forced to implement this functionality because it violates the ISP

            throw new NotSupportedException("The basic printer doesn't have the fax functionality.");

        }
    }

}
