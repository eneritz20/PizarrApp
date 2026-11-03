namespace PizarrApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        /*private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }*/

        private void OnCompraClicked(object? sender, EventArgs e)
        {

        }

        private async void OnTareasClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnadirTareaPage());
        }
    }
}
