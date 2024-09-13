using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Strategy01.DiscountStrategies;

namespace Strategy01
{
    public class InvoiceManager
    {
        private ICustomerDiscountStrategy _customerDiscountStrategy;
        public void SetDiscountStrategy(ICustomerDiscountStrategy strategy) {
            _customerDiscountStrategy = strategy;
        }
        public Invoice CreateInvoice(Customer customer, double quantity, double unitPrice) {
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new[]
                {
                    new InvoiceLine { Quantity = quantity, UnitPrice = unitPrice }
                }
            };
            invoice.DiscountPercentage = _customerDiscountStrategy.CalculateDiscount(invoice.TotalPrice);
            return invoice;
        }
    }
}