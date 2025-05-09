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

        public static MySqlCommand Abrir(string strconn="")
        {
            MySqlCommand cmd = new();
            StrConn = strconn;
            if (StrConn == string.Empty)
            StrConn = $@"server=127.0.0.1;database=comercialtdsdb01;user=root;passeword=";//conecxao com banco 
            MySqlConnection cn = new MySqlConnection(); //conexao mysql
            //cn.ConnectionString = StrConn;
            try
            {
                cn.Open(); // ao passar por aqui tera uma conexao aberta 
                cmd.Connection = cn;
            }
            catch(MySqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            return cmd;
        }
    }
}
