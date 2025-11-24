using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductosMVC.Models
{
    public class Producto
    {
        //prop + 2 veces tecla TAB = Propiedad Entedra
        public int CodProd { get; set; }
        // prop + 1 tecla TAB = Propiedad NO ENTERA
        public string NomProd { get; set; }
        public int StkProd { get; set; }
        public double PreProd { get; set; }
        public Producto() { }
        public Producto(int cod, string nom, int stk, double pre)
        {
            CodProd = cod; NomProd = nom;
            StkProd = stk; PreProd = pre;
        }

    }
}