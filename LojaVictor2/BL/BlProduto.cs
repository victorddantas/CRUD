using LojaVictor2.DAO;
using LojaVictor2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVictor2.BL
{
    public class BlProduto
    {

        //listar
        public List<Produto> Listar()
        {
            ProdutoDao ProdutoDao = new ProdutoDao();
            var produtos = ProdutoDao.Listar();

            return produtos;
        }

        //inserir
        public int Inserir(Produto produto)
        {
            ProdutoDao daoProduto = new ProdutoDao();
            int id = daoProduto.Inserir(produto);
            return id;            
        }
   
    }
}