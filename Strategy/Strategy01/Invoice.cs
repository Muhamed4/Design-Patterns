using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy01
{
    public class Invoice
    {
        public Customer Customer { get; set; }
        public IEnumerable<InvoiceLine> Lines { get; set; }
        public double TotalPrice => Lines.Sum(x => x.Quantity * x.UnitPrice);
        public double DiscountPercentage { get; set; }
        public double NetPrice => TotalPrice - (TotalPrice * DiscountPercentage);
    }
}