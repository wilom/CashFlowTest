using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CashFlowProject;
using CashFlowProject.Dto;

namespace TesUnitCashFlow.CashFlowTest
{
    [TestClass]
    public class SalesTest
    {
        [TestMethod]
        public void BuatSales()
        {
            var sales = new Sales(new DateTime(2015, 1, 1), 20000.0);
            SalesDto snapshot = sales.SnapShot();

            var expect = new SalesDto() { TglSales = new DateTime(2015, 1, 1), Nominal = 20000.0 };
            Assert.AreEqual(expect, snapshot);
        }
    }
}
