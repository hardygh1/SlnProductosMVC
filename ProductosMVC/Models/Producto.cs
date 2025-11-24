using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductosMVC.Models
{
    public class Producto
    {
        //prop + 2 veces tecla TAB = Propiedad Entedra
        public int codProd { get; set; }
        // prop + 1 tecla TAB = Propiedad NO ENTERA
        public string NomProd { get; set; }
        public int StkProd { get; set; }
        public double PreProd { get; set; }
    }
}