using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton01
{
    public class CurrencyConverter
    {
        private IEnumerable<ExchangeRate> _exchangeRates;
        private static CurrencyConverter _instance;
        private static object _instanceLock = new object();
        private CurrencyConverter()
        {
            LoadExchangeRates();
        }

        public static CurrencyConverter Instance
        {
            get 
            {
                // double check
                if(_instance == null)
                {
                    lock(_instanceLock)
                    {
                        if(_instance == null)
                            _instance = new CurrencyConverter();
                    }
                }
                
                return _instance;
            }
        }

        private void LoadExchangeRates() 
        {
            Thread.Sleep(3000);
            _exchangeRates = new[] 
            {
                new ExchangeRate("USD", "SAR", 3.75m),
                new ExchangeRate("USD", "EGP", 30.60m),
                new ExchangeRate("SAR", "EGP", 8.16m)
            };
        }

        public decimal Convert(string baseCurrency, string targetCurrency, decimal amount) {
            var exchangeRate = _exchangeRates.FirstOrDefault(rate => rate.BaseCurrency == baseCurrency && rate.TargetCurrency == targetCurrency);
            return amount * exchangeRate.Rate;
        }
    }
}