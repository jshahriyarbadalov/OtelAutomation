using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class Staffs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IDCARDNo { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public DateTime BirthdayDate { get; set; }
        public DateTime DateOfEntry { get; set; }
        public decimal Salary { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
