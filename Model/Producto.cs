using System;
using System.Collections.Generic;
using System.Text;

namespace PizarrApp.Model
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }

        public Producto(string nombre, string imagen)
        {
            Nombre = nombre;
            Imagen = imagen;
        }
    }
}
