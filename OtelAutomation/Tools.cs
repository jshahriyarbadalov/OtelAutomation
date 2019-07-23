using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace OtelAutomation
{
    public class Tools
    {
        //Singleton Pattern
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                if(connection==null)
                    connection=new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
                    
                return connection;
            }
            
        }

        public static bool Exec(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                int etk = cmd.ExecuteNonQuery();
                cmd.ExecuteScalar();
                return etk > 0 ? true : false;
            }
            catch (Exception)
            {
                //throw;
                return false;
            }
            finally
            {
                if(cmd.Connection.State!=ConnectionState.Closed)
                    cmd.Connection.Close();
            }
        }

        public static object ExecScalar(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

               object value= cmd.ExecuteScalar();
               return value;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
            finally
            {
                if(cmd.Connection.State!=ConnectionState.Closed)
                    cmd.Connection.Close();
            }
        }


        public static void ParameterCreate<T>(SqlCommand cmd, ComType ct, T ent)
        {
            PropertyInfo[] propertys = typeof(T).GetProperties();

            foreach(PropertyInfo pi in propertys)
            {
                string name = pi.Name;
                if (name.ToLower() == "ıd" || name.ToLower() == "id"
                    && ct == ComType.Insert)
                {
                    continue;
                }
                else if (ct==ComType.Delete && (name.ToLower()!="id"||name.ToLower()!="ıd"))
                {
                    continue;
                }

                object value = pi.GetValue(ent);
                cmd.Parameters.AddWithValue("@" + name, value);
            }
        }
    }
}
