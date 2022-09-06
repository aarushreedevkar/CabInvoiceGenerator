namespace CabInvoiceGenerator
{
   
    class program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the CabInvoiceGenerator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double Fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine(Fare);
          

        }
    }
}
