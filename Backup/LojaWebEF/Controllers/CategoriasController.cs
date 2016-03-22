using LojaWebEF.Entidades;
using LojaWebEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWebEF.Controllers
{
    public class CategoriasController : Controller
    {
        //
        // GET: /Categorias/

        public ActionResult Index()
        {
            IEnumerable<Categoria> categorias = new List<Categoria>();
            return View(categorias);
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Categoria categoria)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
     
            return RedirectToAction("Index");
        }

        public ActionResult Visualiza(int id)
        {
            Categoria categoria = new Categoria();
            return View(categoria);
        }

        public ActionResult Atualiza(Categoria categoria)
        {
            return RedirectToAction("Index");
        }

        public ActionResult CategoriasEProdutos()
        {
            IEnumerable<Categoria> categorias = new List<Categoria>();
            return View(categorias);
        }

        public ActionResult BuscaPorNome(string nome)
        {
            ViewBag.Nome = nome;

            IEnumerable<Categoria> categorias = new List<Categoria>();
            return View(categorias);
        }

        public ActionResult NumeroDeProdutosPorCategoria()
        {
            IEnumerable<ProdutosPorCategoria> produtosPorCategoria = new List<ProdutosPorCategoria>();
            return View(produtosPorCategoria);
        }
    }
}
