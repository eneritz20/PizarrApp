using PizarrApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PizarrApp.Data
{
    public static class TareasData
    {
        public static ObservableCollection<Tarea> Tareas { get; } = new ObservableCollection<Tarea>(); //define y crea una colección observable estática de objetos de tipo Tarea.

    }
}
