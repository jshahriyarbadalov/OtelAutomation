using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class Rooms
    {
        public Rooms()
        {
            IS_ACTIVE = true;
        }


        public int id { get; set; }
        public string Name { get; set; }
        public short Capacity { get; set; }
        public short CardNo { get; set; }
        public string Description { get; set; }
        public int RoomTurID { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
