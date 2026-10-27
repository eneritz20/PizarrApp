using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using PizarrApp.Model.ClaseTarea;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PizarrApp.ViewModels
{
    public class TareasViewModel : INotifyPropertyChanged
    {
        private string newTaskName;

        public ObservableCollection<Tarea> ListaTareas { get; }

        public string NewTaskName
        {
            get => newTaskName;
            set
            {
                if (newTaskName == value)
                    return;
                newTaskName = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddTaskCommand { get; }
        public ICommand DeleteTaskCommand { get; }

        public TareasViewModel()
        {
            ListaTareas = new ObservableCollection<Tarea>
            {
                new Tarea { Nombre = "Sacar la basura", Completada = false },
                new Tarea { Nombre = "Limpiar cocina", Completada = false },
                new Tarea { Nombre = "Poner lavadora", Completada = false }
            };

            AddTaskCommand = new Command(OnAddTask);
            DeleteTaskCommand = new Command<Tarea>(OnDeleteTask);
        }

        private async void OnAddTask()
        {
            var nombre = NewTaskName?.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                await Application.Current.MainPage.DisplayAlert("Campo obligatorio", "El nombre de la tarea no puede estar vacío.", "Aceptar");
                return;
            }

            ListaTareas.Add(new Tarea { Nombre = nombre, Completada = false });
            NewTaskName = string.Empty;
        }

        private void OnDeleteTask(Tarea tarea)
        {
            if (tarea == null)
                return;

            if (ListaTareas.Contains(tarea))
                ListaTareas.Remove(tarea);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
