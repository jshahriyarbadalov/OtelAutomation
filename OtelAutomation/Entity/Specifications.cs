using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class Specifications
    {
        public Specifications()
        {
            IS_ACTIVE = true;
        }

        public int id { get; set; }
        public string Name { get; set; }
        public string Description  { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
