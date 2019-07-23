using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class Products
    {
        public Products()
        {
            IS_ACTIVE = true;
        }

        public int id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }
        public int CategoryID { get; set; }
        public int UnitTypeID { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
