using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton01
{
    public class ExchangeRate
    {
        public string BaseCurrency { get; set; }
        public string TargetCurrency { get; set; }
        public decimal Rate { get; set; }
        public ExchangeRate(string baseCurrency, string targetCurrency, decimal rate) {
            BaseCurrency = baseCurrency;
            TargetCurrency = targetCurrency;
            Rate = rate;
        }
    }
}