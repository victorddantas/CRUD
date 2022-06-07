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
            DaoProduto daoProduto = new DaoProduto();
            var produtos = daoProduto.Listar();

            return produtos;
        }

        //inserir
        public int Inserir(Produto produto)
        {
            DaoProduto daoProduto = new DaoProduto();
            int id = daoProduto.Inserir(produto);
            return id;            
        }
   
    }
}