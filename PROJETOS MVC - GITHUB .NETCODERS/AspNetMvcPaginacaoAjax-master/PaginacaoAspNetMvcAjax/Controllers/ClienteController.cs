using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaginacaoAspNetMvcAjax.Models;

namespace PaginacaoAspNetMvcAjax.Controllers
{
    public class ClienteController : Controller
    {
        Contexto contexto = new Contexto();
        // GET: Pesquisa
        public ActionResult Pesquisar()
        {
            DadosPesquisaModel model = new DadosPesquisaModel();
            return View(model);
        }

        [HttpPost]
        public JsonResult ListarClientes(DadosPesquisaModel form, int pagina = 1)
        {
            List<ClienteModel> clientes;
            int totalItens = 0;
            int totalPaginas = 1;
            int ItensPorPagina = 3;

            if (String.IsNullOrEmpty(form.Nome))
            {
                clientes = contexto.Clientes.OrderBy(x => x.Id).Skip((pagina - 1) * ItensPorPagina).Take(ItensPorPagina).ToList();
                totalItens = contexto.Clientes.Count;
            }
            else
            {
                clientes = contexto.Clientes.Where(x => x.Nome.Contains(form.Nome)).OrderBy(x => x.Id).Skip((pagina - 1) * ItensPorPagina).Take(ItensPorPagina).ToList();
                totalItens = contexto.Clientes.Where(x => x.Nome.Contains(form.Nome)).Count();
            }


            //if (totalItens >= ItensPorPagina)
                totalPaginas = (int)Math.Ceiling((decimal)totalItens / ItensPorPagina);


            return Json(new { dados = clientes, pagina = pagina, totalPaginas = totalPaginas }, JsonRequestBehavior.AllowGet);
        }
    }
}