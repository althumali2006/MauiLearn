using MauiApp1.Models;
using Microsoft.Maui;

namespace MauiApp1;

public partial class SelctedViewed : ContentPage
{
    public SelctedViewed(UserModel user)
    {
        InitializeComponent();
        NameLabel.Text = user.Name;
        DetailsLabel.Text = user.Details;
        UserImg.Source = ImageSource.FromFile(user.Img);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}