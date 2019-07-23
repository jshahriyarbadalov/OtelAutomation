using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelAutomation.Entity;

namespace OtelAutomation.Facade
{
    public class StaffORM:ORMBase<Staffs>
    {
        public static Staffs ActiveUser;
        public Staffs Enter(Staffs st)
        {

            SqlDataAdapter adp = new SqlDataAdapter("prc_Staffs_Enter", Tools.Connection);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@un", st.Username);
            adp.SelectCommand.Parameters.AddWithValue("@pas", st.Password);
            DataTable dt=new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
                return null;

            Staffs active=new Staffs();
            foreach (DataRow dr in dt.Rows)
            {
                active.Id = (int) dr["Id"];
                active.Name = dr["Name"].ToString();
                active.Surname = dr["Surname"].ToString();
                active.Username = dr["Username"].ToString();
                active.Password = dr["Password"].ToString();

            }

            return active;
        }
    }
}
