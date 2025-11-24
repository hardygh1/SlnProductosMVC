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
        private static List<Producto> listaprod = new List<Producto>() 
        { 
           new Producto(1001, "Teclado", 10,451.0),
           new Producto(1002, "Mouse", 15, 234.5),
           new Producto(1003, "Monitor", 8, 1250.0),
           new Producto(1004, "Impresora", 5, 980.0),
           new Producto(1005, "CPU", 12, 2250.0)
        };

        // INICIO DEL EJEMPLO DE VISTA PARCIAL
        // GET: Producto
        public ActionResult ListarProductos()
        {
            return View(listaprod);
        }

        public ActionResult ProductosStock(int stk = 0)
        {
            var listado = listaprod.Where(p => p.StkProd >= stk)
                                        .ToList();
            ViewBag.stock = stk;
            return View(listado);
        }

        public ActionResult ProductosPrecios(double pre1 = 0, double pre2 = 0)
        {
            var listado = listaprod.Where(p => p.PreProd >= pre1 &&
                                        p.PreProd <= pre2)
                                        .ToList();
            return View(listado);
        }


        // FIN DEL EJEMPLO DE VISTA PARCIAL

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
