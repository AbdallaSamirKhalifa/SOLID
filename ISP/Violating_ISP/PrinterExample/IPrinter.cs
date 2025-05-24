namespace Violating_ISP.PrinterExample
{
    public interface IPrinter
    {
        void Print(string content);
        void Scan();
        void Fax();
    }

}
