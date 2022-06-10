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
    public class ProdutoDao
    {
        //Método listar
        public List<Produto> Listar()
        {
            SqlConnection con = null;
            List<Produto> produtos = null;

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["LojaVictor2"].ConnectionString;


                con = new SqlConnection(strConexao);
                con.Open();

                SqlCommand cmd = new SqlCommand("uspProdutoConsulta", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rad = cmd.ExecuteReader();
                produtos = new List<Produto>();


                while (rad.Read())
                {
                    Produto produto = new Produto();

                    produto.Id = Convert.ToInt32(rad["Id"]);
                    produto.Nome = (string)rad["Nome"];
                    produto.Preco = Convert.ToDouble(rad["Preco"]);
                    produto.CategoriaId = Convert.ToInt32(rad["CategoriaId"]);
                    produtos.Add(produto);
                }

            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return produtos;
        }

        //inserir
        public int Inserir(Produto produto)
        {
            int id;
            SqlConnection con = null;

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["LojaVictor2"].ConnectionString;
                con = new SqlConnection(strConexao);
                con.Open();

                SqlCommand cmd = new SqlCommand("uspProdutoInserir", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                cmd.Parameters.AddWithValue("@Preco", Convert.ToDouble(produto.Preco));
                cmd.Parameters.AddWithValue("@CategoriaId", Convert.ToInt32(produto.CategoriaId));

                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            return id;

        }


    }
}