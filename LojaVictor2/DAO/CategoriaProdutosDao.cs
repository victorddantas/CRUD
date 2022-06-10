using LojaVictor2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LojaVictor2.DAO
{
    public class CategoriaProdutosDao
    {
        //Método Listar
        public List<CategoriaProdutos> Listar()
        {
            SqlConnection con = null;
            List<CategoriaProdutos> categoriaProdutos = null;

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["LojaVictor2"].ConnectionString;


                con = new SqlConnection(strConexao);
                con.Open();

                SqlCommand cmd = new SqlCommand("uspCategoriaProdutoConsultar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rad = cmd.ExecuteReader();
                categoriaProdutos = new List<CategoriaProdutos>();


                while (rad.Read())
                {
                    CategoriaProdutos categoriaProduto = new CategoriaProdutos();

                    categoriaProduto.CategoriaId = Convert.ToInt32(rad["CategoriaId"]);
                    categoriaProduto.Nome = (string)rad["Nome"];
                    categoriaProdutos.Add(categoriaProduto);
                }

            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return categoriaProdutos;
        }
    }
}