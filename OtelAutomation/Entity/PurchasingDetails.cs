using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class PurchasingDetails
    {
        public int PurchasingID { get; set; }
        public int ProductID { get; set; }
        public double Quantity { get; set; }
        public decimal BuyPrice { get; set; }

    }
}
