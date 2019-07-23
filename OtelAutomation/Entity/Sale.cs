using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class Sale
    {
        public int id { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
        public int RoomID { get; set; }
        public decimal RoomPrice { get; set; }
        public DateTime SaleDate { get; set; }

    }
}
