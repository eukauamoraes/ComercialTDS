using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public static class Banco
    {
        public static string StrConn { get; set; }
        public static MySqlCommand Abrir(string strconn = "")
        {
            MySqlCommand cmd = new();
            StrConn = strconn;

            if (StrConn == string.Empty)
                StrConn = $@"server=10.91.47.89;database=comercialtdsdb01;user=root;password=123";
            MySqlConnection cn = new(StrConn);
            //cn.ConnectionString = Strconn;
            try
            {
                cn.Open();// ao passar por aqui terá uma connexão aberta
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }
    }
}
