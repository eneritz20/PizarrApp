using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PizarrApp.Model.ClaseTarea
{
    public class Tarea : INotifyPropertyChanged
    {
        private string nombre;
        private bool completada;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre == value)
                    return;
                nombre = value;
                OnPropertyChanged();
            }
        }

        public bool Completada
        {
            get => completada;
            set
            {
                if (completada == value)
                    return;
                completada = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
