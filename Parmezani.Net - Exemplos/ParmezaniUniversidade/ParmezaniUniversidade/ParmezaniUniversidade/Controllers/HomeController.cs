using ParmezaniUniversidade.DAL;
using ParmezaniUniversidade.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParmezaniUniversidade.Controllers
{
    public class HomeController : Controller
    {
        private Contexto db = new Contexto();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var data = from aluno in db.Alunos
                       group aluno by aluno.DataInscricao into dataGrupo
                       
                       select new InscricaoDataGrupo()
                       {
                           InscricaoData = dataGrupo.Key,
                           contadorAlunos = dataGrupo.Count()
                       };

            return View(data);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}