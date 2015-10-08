using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeriodeProject;
using PeriodeProject.Dto;

namespace TesUnitCashFlow.PeriodeTest
{
    [TestClass]
    public class PeriodeTest
    {
        Periode _periode = new Periode("PR0001", "Kranggan", "Pertama", "Start","Akhir","Sebelum","Sesudah");
        
        
        [TestMethod]
        public void BuatPeriodetest()
        {
            var _expect = new PeriodeDto()
            {
                Id = "PR0001",
                Cabang = "Kranggan",
                PeriodeSekarang = "Pertama",
                PeriodeAwal = "Start",
                PeriodeAkhir = "Akhir",
                PeriodeSebelum = "Sebelum",
                PeriodeSesudah = "Sesudah"
            };
        
            PeriodeDto snapshot = _periode.SnapShot();
            Assert.AreEqual(_expect, snapshot);
        }

        [TestMethod]
        public void PeriodeSekarang() {
            
        } 
    }
}
