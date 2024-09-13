
using Strategy01;
using Strategy01.DiscountStrategies;

namespace Strategy
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            var dataReader = new CustomerReader();
            var customers = dataReader.GetCustomers();
            while(true) {
                Console.WriteLine("Customer List: [1] Mohamed Ahmed Elmahdy [2] Ibrahim khalid Elnaggar");
                Console.Write($"Enter Customer ID: ");
                var customerId = int.Parse(Console.ReadLine());
                Console.Write("Enter Item Quantity: ");
                var quantity = double.Parse(Console.ReadLine());
                Console.Write("Enter Unit Price: ");
                var unitPrice = double.Parse(Console.ReadLine());

                var customer = customers.First(x => x.Id == customerId);
                ICustomerDiscountStrategy customerDiscountStrategy;
                if(customer.Category == CustomerCategory.Silver)
                    customerDiscountStrategy = new SilverCustomerDiscountStrategy();
                else if(customer.Category == CustomerCategory.Gold)
                    customerDiscountStrategy = new GoldCustomerDiscountStrategy();
                else   
                    customerDiscountStrategy = new NewCustomerDiscountStrategy();
                var invoiceManager = new InvoiceManager();
                invoiceManager.SetDiscountStrategy(customerDiscountStrategy);
                var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);
                Console.WriteLine($"Invoice created for customer `{customer.Name}` with net price: {invoice.NetPrice}");
                Console.WriteLine("Press any key to create another invoice");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}