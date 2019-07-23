using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class Purchasing
    {
        public int id { get; set; }
        public string SupplierID { get; set; }
        public DateTime PurchasingDate { get; set; }
        public int StaffID { get; set; }

    }
}
