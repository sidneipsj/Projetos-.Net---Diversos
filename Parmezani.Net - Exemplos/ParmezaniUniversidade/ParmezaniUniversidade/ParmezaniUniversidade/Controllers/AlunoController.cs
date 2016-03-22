using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ParmezaniUniversidade.Models;
using ParmezaniUniversidade.DAL;
using PagedList;

namespace ParmezaniUniversidade.Controllers
{
    public class AlunoController : Controller
    {
        private Contexto db = new Contexto();

        // GET: /Aluno/
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NomeParam = String.IsNullOrEmpty(sortOrder) ? "Nome_desc" : "";
            ViewBag.DateParm = sortOrder == "Date" ? "Date_desc" : "Date";


            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var alunos = from s in db.Alunos
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                alunos = alunos.Where(s => s.Sobrenome.ToUpper().Contains(searchString.ToUpper())
                                       || s.Nome.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortOrder)
            {
                case "Nome_desc":
                    alunos = alunos.OrderByDescending(s => s.Sobrenome);
                    break;
                case "Data":
                    alunos = alunos.OrderBy(s => s.DataInscricao);
                    break;
                case "Data_desc":
                    alunos = alunos.OrderByDescending(s => s.DataInscricao);
                    break;
                default:
                    alunos = alunos.OrderBy(s => s.Sobrenome);
                    break;
            }


            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(alunos.ToPagedList(pageNumber, pageSize));
        }



        // GET: /Aluno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno aluno = db.Alunos.Find(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        // GET: /Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Aluno/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Nome,Sobrenome,DataInscricao")] Aluno aluno)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Alunos.Add(aluno);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente de novo, e se o problema persistir consulte o administrador do sistema.");
            }

            return View(aluno);
        }

        // GET: /Aluno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno aluno = db.Alunos.Find(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        // POST: /Aluno/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Nome,Sobrenome,DataInscricao")] Aluno aluno)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(aluno).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente de novo, e se o problema persistir consulte o administrador do sistema.");
            }
            
            return View(aluno);
        }

        // GET: /Aluno/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError=false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Excluir falhou. Tente de novo, e se o problema persistir consulte o administrador do sistema.";
            }
            
            Aluno aluno = db.Alunos.Find(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        // POST: /Aluno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Aluno aluno = db.Alunos.Find(id);
                db.Alunos.Remove(aluno);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }

            return RedirectToAction("Index");
            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
