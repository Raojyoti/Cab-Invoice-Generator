using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;
        [Test]//tc1
        public void GiveDistanceAndTimeSouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            double fare=invoiceGenerator.CalculateFare(distance, time);
            double excepted = 25;
            Assert.AreEqual(excepted, fare);
        }
    }
}