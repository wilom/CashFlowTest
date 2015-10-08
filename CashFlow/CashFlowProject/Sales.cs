using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlowProject
{
    public class Sales
    {

        private DateTime _tglSales;
        private double _nominal;

        public Sales(DateTime tglSales, double nominal)
        {

            this._tglSales = tglSales;
            this._nominal = nominal;
        }

        public Dto.SalesDto SnapShot()
        {
            return new Dto.SalesDto()
            {
                TglSales = this._tglSales,
                Nominal = this._nominal
            };
        }
    }
}
