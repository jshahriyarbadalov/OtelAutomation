using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation.Entity
{
    public class Customers
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string IDCARDNo { get; set; }
        public string PhoneNo { get; set; }
        public DateTime BirthdayDate { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public bool IS_ACTIVE { get; set; }
    }

    public enum MaritalStatus
    {
        Single=1,
        Married=2
    }

    public enum Gender
    {
        Female=1,
        Male=2
    }
}
