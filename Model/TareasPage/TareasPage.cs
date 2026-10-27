namespace PizarrApp.Model.TareasPage;

public partial class NewPage1 : ContentPage
{
    private CollectionView _tareasCollectionView;

    public NewPage1()
    {
        var grid = new Grid
        {
            Padding = new Thickness(20),
            RowDefinitions = new RowDefinitionCollection
            {
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Star },
                new RowDefinition { Height = GridLength.Auto }
            }
        };

        var headerLabel = new Label
        {
            Text = "Lista de Tareas",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#333333"),
            Margin = new Thickness(0, 0, 0, 20)
        };
        Grid.SetRow(headerLabel, 0);
        grid.Children.Add(headerLabel);

        _tareasCollectionView = new CollectionView();
        _tareasCollectionView.ItemTemplate = new DataTemplate(() =>
        {
            var checkBox = new CheckBox { Color = Color.FromArgb("#512BD4") };
            checkBox.SetBinding(CheckBox.IsCheckedProperty, "IsCompleted");
            checkBox.CheckedChanged += OnTaskCheckedChanged;

            var nameLabel = new Label
            {
                FontSize = 18,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(10, 0, 0, 0),
                TextColor = Color.FromArgb("#444444")
            };
            nameLabel.SetBinding(Label.TextProperty, "Name");

            var stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Center,
                Children = { checkBox, nameLabel }
            };

            return new Frame
            {
                CornerRadius = 8,
                HasShadow = true,
                Margin = new Thickness(0, 5),
                Padding = new Thickness(15),
                BackgroundColor = Colors.White,
                Content = stackLayout
            };
        });

        Grid.SetRow(_tareasCollectionView, 1);
        grid.Children.Add(_tareasCollectionView);

        var guardarButton = new Button
        {
            Text = "Guardar Progreso",
            BackgroundColor = Color.FromArgb("#512BD4"),
            TextColor = Colors.White,
            FontAttributes = FontAttributes.Bold,
            CornerRadius = 10,
            Margin = new Thickness(0, 20, 0, 0)
        };
        guardarButton.Clicked += OnGuardarClicked;
        Grid.SetRow(guardarButton, 2);
        grid.Children.Add(grid);

        Content = grid;
    }

    private void OnTaskCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
    }

    private void OnGuardarClicked(object sender, EventArgs e)
    {
    }
}