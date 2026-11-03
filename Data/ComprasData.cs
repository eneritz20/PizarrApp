using PizarrApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PizarrApp.Data
{
    public static class ComprasData
    {
        public static ObservableCollection<Producto> Productos { get; } = new ObservableCollection<Producto>(); //define y crea una colección observable estática de objetos de tipo Producto.

    }
}
