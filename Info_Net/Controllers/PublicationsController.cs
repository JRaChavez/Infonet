using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Info_Net.Clases;
using Info_Net.Models;

namespace Info_Net.Controllers
{

    public class PublicationsController : Controller
    {
        private InfoNetContex db = new InfoNetContex();

        // GET: Publications
        public ActionResult Index()
        {
            return View(db.Publications.ToList());
        }

        // GET: Publications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publication publication = db.Publications.Find(id);
            if (publication == null)
            {
                return HttpNotFound();
            }
            return View(publication);
        }
        [Authorize]
        // GET: Publications/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Publications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PublicationView publicationView)
        {
            if (!ModelState.IsValid)
            {
                return View(publicationView);
            }

            //Upload image
            string path = string.Empty;
            string pic = string.Empty;

            if (publicationView.Imagen != null)
            {
                pic = Path.GetFileName(publicationView.Imagen.FileName);
                path = Path.Combine(Server.MapPath("~/Content/Fotos"), pic);
                publicationView.Imagen.SaveAs(path);
                using (MemoryStream ms = new MemoryStream())
                {
                    publicationView.Imagen.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }
            }


            var publication = new Publication
            {
                Nombre = publicationView.Nombre,
                Titulo=publicationView.Titulo,
                Description=publicationView.Description,
                Contenido=publicationView.Contenido,
                Imagen=pic ==string.Empty ? string.Empty:string.Format("~/Content/Foto/{0}",pic),

            };

            db.Publications.Add(publication);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

      
        [Authorize]
        // GET: Publications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publication publication = db.Publications.Find(id);
            if (publication == null)
            {
                return HttpNotFound();
            }
            return View(publication);
        }

        // POST: Publications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Publication_id,Nombre,Titulo,Description,Imagen,Contenido")] Publication publication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publication);
        }

        // GET: Publications/Delete/5

        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Publication publication = db.Publications.Find(id);
            if (publication == null)
            {
                return HttpNotFound();
            }
            return View(publication);
        }


        [Authorize]
        // POST: Publications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Publication publication = db.Publications.Find(id);
            db.Publications.Remove(publication);
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
