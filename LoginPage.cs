using System;
using Microsoft.Maui.Controls;

namespace Clase1;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void NombreChanged(object sender, TextChangedEventArgs e)
    {
        string nombre = e.NewTextValue ?? "";
        if (nombre == "User")
        {
            PasswordEntry.IsVisible = true;
            AccederButton.IsVisible = true;
        }
        else
        {
            PasswordEntry.IsVisible = false;
            AccederButton.IsVisible = false;
            PasswordEntry.Text = "";
        }
    }

    private void AccederClicked(object sender, EventArgs e)
    {
        if (PasswordEntry.Text == "1234")
        {
            Navigation.PushAsync(new MainPage());
            Navigation.PopAsync();
        }
        else
        {
            DisplayAlert("Error", "Contraseña incorrecta", "OK");
        }
    }
}
