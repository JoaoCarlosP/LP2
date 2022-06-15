using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace PFerramenta
{
    class Categoria
    {
        private int idcategoria;
        private string descricao;

        public int Idcategoria
        {
            get
            {
                return idcategoria;
            }
            set
            {
                idcategoria = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }

        }

        public DataTable Listar()
        {
            SqlDataAdapter daCategoria;                 //cria variavel para selecionar
            DataTable dtCategoria = new DataTable();    //cria uma tabela de dados
            try
            {
                daCategoria = new SqlDataAdapter("SELECT * FROM CATEGORIA",
                Form1.conexao); //seleciona os dados com o Select e os joga no daCategoria
                daCategoria.Fill(dtCategoria);      //Preenche a tabela de dados com o daCategoria
                daCategoria.FillSchema(dtCategoria, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;   //significa que está a levantar um erro
            }
            return dtCategoria;
        }
    }
}
