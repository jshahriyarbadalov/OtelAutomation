using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelAutomation
{
    public class ORMBase<T> : IORM<T> where T : class
    {
        private string ClassName
        {
            get
            {
                return typeof(T).Name;
            }

        }

        public  bool Insert(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            //PropertyInfo[] propertys = typeof(T).GetProperties();
            //foreach (PropertyInfo pi in propertys)
            //{
            //    string name = pi.Name;
            //    if (name.ToLower() == "id"|| name.ToLower()=="ıd")
            //    {
            //        continue;
            //    }

            //    object value = pi.GetValue(entity);
            //    cmd.Parameters.AddWithValue("@" + name, value);
            //}
            Tools.ParameterCreate<T>(cmd,ComType.Insert, entity);

            return Tools.Exec(cmd);
        }
        public object InsertScalar(T entity)
        {
            SqlCommand cmd=new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.ParameterCreate<T>(cmd, ComType.Insert, entity);

            return Tools.ExecScalar(cmd);
        }



        public DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_{0}_Select", ClassName), Tools.Connection);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        public bool Update(T entity)
        {
            SqlCommand cmd=new SqlCommand(string.Format("prc_{0}_Update", ClassName),Tools.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.ParameterCreate<T>(cmd, ComType.Update, entity);

            return Tools.Exec(cmd);
        }

        public bool Delete(T entity)
        {
            SqlCommand cmd =new SqlCommand(string.Format("prc_{0}_Delete",ClassName),Tools.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParameterCreate<T>(cmd,ComType.Delete,entity);

            return Tools.Exec(cmd);
        }

       
    }
}
