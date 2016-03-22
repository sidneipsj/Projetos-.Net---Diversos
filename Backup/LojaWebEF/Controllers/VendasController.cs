using LojaWebEF.DAO;
using LojaWebEF.Entidades;
using LojaWebEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWebEF.Controllers
{
    public class VendasController : Controller
    {
        public ActionResult Index()
        {
            // use o vendasDAO para preencher a lista de vendas
            IEnumerable<Venda> vendas = new List<Venda>();
            return View(vendas);
        }
        public ActionResult ListaProdutos()
        {
            // use o produtosDAO para preencher a lista de produtos
            IEnumerable<Produto> produtos = new List<Produto>();
            ViewBag.ProdutosNoCarrinho = this.Carrinho.Produtos.Count;
            return View(produtos);
        }
        public ActionResult AdicionaProduto(int produtoId)
        {
            // utilize o produtosDAO para buscar o produto com id
            // produtoId
            Produto produto = new Produto();
            this.Carrinho.Adiciona(produto);
            return RedirectToAction("ListaProdutos");
        }
        public ActionResult FechaPedido()
        {
            IEnumerable<Produto> produtos = this.Carrinho.Produtos;
            // use o usuariosDAO para pegar a lista de usuários
            IEnumerable<Usuario> usuarios = new List<Usuario>();
            ViewBag.Usuarios = usuarios;
            return View(produtos);
        }
        public ActionResult CompletaPedido(int usuarioId)
        {
            // use o usuariosDAO para buscar o usuario de id usuarioId
            Usuario usuario = new Usuario();
            Venda venda = this.Carrinho.CriaVenda(usuario);
            // utilize o dao para gravar a venda no banco de dados
            this.Carrinho = new Carrinho();
            return RedirectToAction("Index");
        }
        public ActionResult LimpaCarrinho()
        {
            this.Carrinho = new Carrinho();
            return RedirectToAction("ListaProdutos");
        }

        // O Valor da propriedade Carrinho é armazenado na sessão
        private Carrinho Carrinho
        {
            get
            {
                Carrinho atual = Session["Carrinho"] as Carrinho;
                if (atual == null)
                {
                    atual = new Carrinho();
                    Session["Carrinho"] = atual;
                }
                return atual;
            }
            set
            {
                Session["Carrinho"] = value;
            }
        }
    }
}
