using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ProductosMVC.Models;

namespace ProductosMVC.Controllers
{
    public class ProductoController : Controller
    {
        private static List<Producto> listaprod = new List<Producto>();

        // GET: Producto
        public ActionResult Index()
        {
            return View(listaprod);
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            // Obtener datos del modelo
            Producto nuevo = new Producto();

            // Enviar datos del modelo a la vista
            return View(nuevo); // return View(new Producto());
        }

        // POST: Producto/Create
        // public ActionResult Create(FormCollection collection) -> antes de MVC5
        [HttpPost]
        public ActionResult Create(Producto obj)
        {
            try
            {
                /*int cod = int.Parse(collection["CodProd"]);
                string nom = collection["NomProd"];
                int stk = int.Parse(collection["StkProd"]);
                double pre = double.Parse(collection["PreProd"]);

                Producto obj = new Producto()
                {
                    codProd = cod, NomProd = nom,
                    StkProd = stk, PreProd = pre
                };*/

                listaprod.Add(obj);
                TempData["mensaje"] = "Producto registrado correctamente.";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
