using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMvcApp.Models;

namespace WebMvcApp.Controllers
{
    public class TabeladeCarroesController : Controller
    {
        private ContextDB db = new ContextDB();

        // GET: TabeladeCarroes
        public ActionResult Index()
        {
            return View(db.carros.ToList());
        }

        // GET: TabeladeCarroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabeladeCarro tabeladeCarro = db.carros.Find(id);
            if (tabeladeCarro == null)
            {
                return HttpNotFound();
            }
            return View(tabeladeCarro);
        }

        // GET: TabeladeCarroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TabeladeCarroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Placa,Ativo,UsuarioCriacao,UsuarioAlteracao,DataCriacao,DataAlteracao")] TabeladeCarro tabeladeCarro)
        {
            if (ModelState.IsValid)
            {
                db.carros.Add(tabeladeCarro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tabeladeCarro);
        }

        // GET: TabeladeCarroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabeladeCarro tabeladeCarro = db.carros.Find(id);
            if (tabeladeCarro == null)
            {
                return HttpNotFound();
            }
            return View(tabeladeCarro);
        }

        // POST: TabeladeCarroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Placa,Ativo,UsuarioCriacao,UsuarioAlteracao,DataCriacao,DataAlteracao")] TabeladeCarro tabeladeCarro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tabeladeCarro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tabeladeCarro);
        }

        // GET: TabeladeCarroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TabeladeCarro tabeladeCarro = db.carros.Find(id);
            if (tabeladeCarro == null)
            {
                return HttpNotFound();
            }
            return View(tabeladeCarro);
        }

        // POST: TabeladeCarroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TabeladeCarro tabeladeCarro = db.carros.Find(id);
            db.carros.Remove(tabeladeCarro);
            db.SaveChanges();
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
