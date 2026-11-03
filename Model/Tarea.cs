using System;
using System.Collections.Generic;
using System.Text;

namespace PizarrApp.Model
{
    internal class Tarea
    {
        public string Nombre { get; set; }
        public string Completada { get; set; }

        public Tarea(string nombre, string completada)
        {
            Nombre = nombre;
            Completada = completada;
        }
    }
}
