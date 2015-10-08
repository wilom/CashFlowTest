using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CashFlowProject;
using CashFlowProject.Dto;

namespace TesUnitCashFlow.CashFlowTest
{
    [TestClass]
    public class SalesLainTest
    {
        [TestMethod]
        public void BuatSalesLain()
        {
            //testSalesLain
            var salesLain = new SalesLain("SL0001", new DateTime(2015, 1, 1), 20000.0, "Kardus");
            SalesLainDto snapshot = salesLain.SnapShot();

            var expect = new SalesLainDto() { IdSalesLain = "SL0001", TglSalesLain = new DateTime(2015, 1, 1), Nominal = 20000.0, Keterangan = "Kardus" };
            Assert.AreEqual(expect, snapshot);
            //endSalsesLain
            //-----------------------------------------------------------

        }
    }
}
