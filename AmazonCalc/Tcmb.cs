using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonCalc
{
    public class Tcmb
    {
        public string CurrencyCode { get; set; }
        public int? Unit { get; set; }
        public string Name { get; set; }
        public string CurrencyName { get; set; }
        public decimal? ForexBuying { get; set; }
        public decimal? ForexSelling { get; set; }
        public decimal? BanknoteBuying { get; set; }
        public decimal? BanknoteSelling { get; set; }
        public decimal? CrossRateUsd { get; set; }
        public decimal? CrossRateOther { get; set; }
    }
}
