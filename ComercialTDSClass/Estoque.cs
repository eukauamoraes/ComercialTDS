using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ComercialTDSClass
{
    public class Estoque
    {


        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Dataultimomovimento { get; set; }

        public Estoque(int id, int produtoId, int dataultimomovimento)
        {
            Id = id;
            ProdutoId = produtoId;
            Dataultimomovimento = dataultimomovimento;
        }
        public Estoque(int produtoId, int dataultimomovimento)
        
        {

            ProdutoId = produtoId;
            Dataultimomovimento = dataultimomovimento;
        }
        public void inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "sp_estoque_inserir";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("spprodutoId", ProdutoId);
            cmd.Parameters.AddWithValue("spdataultimomovimento", Dataultimomovimento);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        
  


        

    }
}      
         
               
         
        
        
        
         
    
        
        
        
      
        
        
        

  





    
 
