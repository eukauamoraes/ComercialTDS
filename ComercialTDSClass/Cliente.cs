using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ComercialTDSClass
{
     public class Cliente
    {
        

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string ? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public  DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco>? Enderecos { get; set; }

        public Cliente() { }
     
        //Contrutor utilizado para fazer o insert 
        public Cliente( string? nome, string? cpf, string? telefone, string? email, DateTime? dataNascimento)
        {
           
            Nome =nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento; 
        }
        public Cliente(int id,string? nome, string? cpf, string? telefone, string? email, DateTime? dataNascimento)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public Cliente(int id ,string? nome, string? cpf, string? telefone, string? email, DateTime? dataNascimento, DateTime? dataCadastro, bool ativo, List<Endereco>? enderecos)
        {
            Id = Id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
            Ativo = ativo;
            Enderecos = enderecos;
        }
        public Cliente(int id,string? nome, string? cpf, string? telefone, string? email, DateTime? dataNascimento, DateTime? dataCadastro, bool ativo)
        {
            Id = Id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }
        public void inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "sp_cliente_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdtanasc", DataNascimento);
            Id =  Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();



        }
        public bool atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "sp_cliente_altera";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdtanasc", DataNascimento);
            return cmd.ExecuteNonQuery() > 0 ? true : false;



        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from cliente where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(


                       dr.GetInt32(0),
                       dr.GetString(1),
                       dr.GetString(2),
                       dr.GetString(3),
                       dr.GetString(4),
                       dr.GetDateTime(5),
                       dr.GetDateTime(6),
                       dr.GetBoolean(7)




                     
                );
            }
            dr.Close();
            cmd.Connection.Close();
            return cliente;
        }
        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(new(
                      
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7
                    

                        )
                    ));
            }
            dr.Close();
            cmd.Connection.Close();
            return clientes;
        }

        
    }
}
  





 