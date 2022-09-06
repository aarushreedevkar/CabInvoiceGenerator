namespace CabInvoiceGeneratorUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        CabInvoiceGenerator invoiceGenerator = null;




        [TestMethod]
        public void TestMethod1()
        {
            invoiceGenerator = new CabInvoiceGenerator(RideType.NORMAL)
                double distance = 2.0;
            int time = 5;

            double Fare = invoiceGenerator.Distance(distance, time);

            double expected = 25;
            Assert.AreEqual(expected, Fare);
        }


        }
    }
}