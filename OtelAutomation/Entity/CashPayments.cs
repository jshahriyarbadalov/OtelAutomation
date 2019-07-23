using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class CashPayments
    {
        public int  id { get; set; }
        public int CashID { get; set; }
        public int CashPaymentsTypeID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

    }
}
