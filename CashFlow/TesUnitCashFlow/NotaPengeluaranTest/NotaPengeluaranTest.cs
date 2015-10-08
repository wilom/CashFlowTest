using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NotaPengeluaranProject;
using NotaPengeluaranProject.Dto;


namespace TesUnitCashFlow.NotaPengeluaranTest
{
    [TestClass]
    public class NotaPengeluaranTest
    {
        NotaPengeluaran notaPengeluaran;
        
        [TestInitialize]
        public void init()
        {
            notaPengeluaran = new NotaPengeluaran("NT0001", new DateTime(2015, 1, 1), "Bahan", 20000.0);
        }
        [TestMethod]
        public void IsiItem()
        {
            var items = new Items("Ayam", 20000.0);
            ItemsDto snapshot = items.SnapShot();
            Assert.IsNotNull(snapshot);
        }
        [TestMethod]
        public void EditNoNota()
        {
            string noNota = "123";
            notaPengeluaran.EditNoNota(noNota);
            Assert.AreEqual(noNota, notaPengeluaran.GetNoNota());
        }
        [TestMethod]
        public void CreateDTONotaPengeluaran()
        {
            NotaPengeluaranDto snapshot = notaPengeluaran.SnapShot();
            Assert.IsNotNull(snapshot.Items);
        }
    }
}
