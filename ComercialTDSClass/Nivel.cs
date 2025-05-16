using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;



namespace ComercialTDSClass
{
    /// <summary>
    /// Classe que representa um nivel de acesso no sistema
    /// </summary>
    public class Nivel
    {
        public Nivel(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Nivel() { }

        public Nivel(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        /// <summary>
        ///  Insere um novo nivel no banco de dados
        /// </summary>
        //inserir,atualizar,listar,obterPorId(id)
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_nivel_insert";
            //cmd.Parameters.Add("spnome",MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            // codigo do etodo
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from niveis where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //nivel.Id = dr.GetInt32(0);
                //nivel.Nome = dr.GetString(1);
                //nivel.Sigla = dr.GetString(2);
                nivel = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
            cmd.Connection.Close();
            return nivel;

        }
        /// <summary>
        /// Obtém uma lista de niveis do banco de dados
        /// </summary>
        /// <returns></returns>
        public static List<Nivel> ObterLista()  
        {
            List<Nivel> niveis = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from niveis order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                niveis.Add(new Nivel(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2))
                    );
                dr.Close(); // Abriu o dr Fechar para abrir um novo  select ou comando de banco
                cmd.Connection.Close(); // fechar a conexão
            }
            return niveis;
        }
        /// <summary>
        /// Atualiza o nivel no banco de dados
        /// </summary>
        /// <returns></returns>
        public bool Atualizar()
        {
            // come este método não e estatico, precisamos considerar que
            // as propriedades ja possuem valores atribidos
            bool atualizado = false;
            if (Id < 1) return false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_nivel_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spNome", Nome);
            cmd.Parameters.AddWithValue("spSigla", Sigla);
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                atualizado = true;

            }
            return atualizado;
        }
    }
}





           


