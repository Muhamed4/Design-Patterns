
namespace Singleton01
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            while(true) {
                Console.Write("Enter base currency: ");
                var baseCurrency = Console.ReadLine();
                Console.Write("Enter target currency: ");
                var targetCurrency = Console.ReadLine();
                Console.Write("Enter amount: ");
                var amount = decimal.Parse(Console.ReadLine());
                // var converter = new CurrencyConverter();
                var exchangedAmount = CurrencyConverter.Instance.Convert(baseCurrency, targetCurrency, amount);
                Console.WriteLine($"{amount} {baseCurrency} = {exchangedAmount} {targetCurrency}");
                Console.WriteLine("---------------------------------------------------------");
            }

            var singleTone1 = StaticHolderSingleton.Instance();
            var singleTone2 = StaticHolderSingleton.Instance();
            Console.WriteLine(singleTone1.GetHashCode());
            Console.WriteLine(singleTone2.GetHashCode());
        }
    }
}