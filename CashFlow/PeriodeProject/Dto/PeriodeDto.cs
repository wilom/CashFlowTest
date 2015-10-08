using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodeProject.Dto
{
    public class PeriodeDto
    {

        public string Id { get; set; }

        public string Cabang { get; set; }

        public string PeriodeSekarang { get; set; }

        public string PeriodeAwal { get; set; }

        public string PeriodeAkhir { get; set; }

        public string PeriodeSebelum { get; set; }

        public string PeriodeSesudah { get; set; }
        public override bool Equals(object obj)
        {
            if (!(obj is PeriodeDto)) return false;
            var cmp = (PeriodeDto)obj;
            return this.Id.Equals(cmp.Id) &&
                this.Cabang.Equals(cmp.Cabang)&&
                this.PeriodeSekarang.Equals(cmp.PeriodeSekarang)&&
                this.PeriodeAwal.Equals(cmp.PeriodeAwal)&&
                this.PeriodeAkhir.Equals(cmp.PeriodeAkhir)&&
                this.PeriodeSebelum.Equals(cmp.PeriodeSebelum)&&
                this.PeriodeSesudah.Equals(cmp.PeriodeSesudah);
        }
    }
}
