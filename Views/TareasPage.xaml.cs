using Microsoft.Maui.Controls;
using PizarrApp.ViewModels;

namespace PizarrApp
{
    public partial class TareasPage : ContentPage
    {
        public TareasPage()
        {
            InitializeComponent();

            BindingContext = new TareasViewModel();
        }
    }
}
