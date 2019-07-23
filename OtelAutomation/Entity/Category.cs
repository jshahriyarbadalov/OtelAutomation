using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class Category
    {
        public Category()
        {
            IS_ACTIVE = true;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IS_ACTIVE { get; set; }

    }
}
