using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class RoomSpecification
    {
        public int RoomID { get; set; }
        public int SpecificationID { get; set; }
        public short Value { get; set; }

    }
}
