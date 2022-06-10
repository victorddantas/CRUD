using LojaVictor2.BL;
using LojaVictor2.DAO;
using LojaVictor2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVictor2.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            BlProduto blProduto = new BlProduto();
            var produtos = blProduto.Listar();

            return View(produtos);
        }

        //formulário para inserir 
     
        public ActionResult Form()
        {
            BlCategoriaProdutos blCategoriaProdutos = new BlCategoriaProdutos();
            var categoriaProdutos = blCategoriaProdutos.Listar(); 

            return View(categoriaProdutos);
        }

        //adiciona produtos no banco
       [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {

            ProdutoDao dao = new ProdutoDao();
            dao.Inserir(produto);

            return RedirectToAction("Index", "Produto");
        }

    }
}