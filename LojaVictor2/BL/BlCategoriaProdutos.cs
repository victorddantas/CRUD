using LojaVictor2.DAO;
using LojaVictor2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVictor2.BL
{
    public class BlCategoriaProdutos
    {
        //listar
        public List<CategoriaProdutos> Listar()
        {
            CategoriaProdutosDao categoriaProdutosDao = new CategoriaProdutosDao();
            var categoriaProdutos = categoriaProdutosDao.Listar();

            return categoriaProdutos;
        }
    }
}