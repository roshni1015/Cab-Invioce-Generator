using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator.Tests
{
    [TestClass()]
    public class InvoiceGeneratorTests
    {
        [TestMethod()]
        public void calculateFareTest()
        {
            InvoiceGenerator test1 = new();
            double fare1 = test1.calculateFare(10, 50);
            Assert.AreEqual(150, fare1);
        }

        [TestMethod()]
        public void calculateFareTest1()
        {
            InvoiceGenerator test2 = new();
            MultipleRides[] Rides = { new MultipleRides(10, 40), new MultipleRides(20, 50) };
            double totalfare = test2.calculateFare(Rides);
            Assert.AreEqual(390, totalfare);
        }
    }
}