using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodeProject
{
    public class Periode
    {
        private string _id;
        private string _cabang;
        private string _periodeSekarang;
        private string _periodeAwal;
        private string _periodeAkhir;
        private string _periodeSebelum;
        private string _periodeSesudah;

        public Periode(string id, string cabang, string periodeSekarang, string periodeAwal, 
            string periodeAkhir, string periodeSebelum, string periodeSesudah)
        {
            this._id = id;
            this._cabang = cabang;
            this._periodeSekarang = periodeSekarang;
            this._periodeAwal = periodeAwal;
            this._periodeAkhir = periodeAkhir;
            this._periodeSebelum = periodeSebelum;
            this._periodeSesudah = periodeSesudah;
        }
        public Dto.PeriodeDto SnapShot()
        {
            return new Dto.PeriodeDto()
            {
                Id = this._id,
                Cabang = this._cabang,
                PeriodeSekarang = this._periodeSekarang,
                PeriodeAwal = this._periodeAwal,
                PeriodeAkhir = this._periodeAkhir,
                PeriodeSebelum = this._periodeSebelum,
                PeriodeSesudah = this._periodeSesudah
            };
        }
    }
}
