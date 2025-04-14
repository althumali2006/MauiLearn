using MauiApp1.Models;
namespace MauiApp1;

public partial class ListViews : ContentPage
{
	public ListViews()
	{
		InitializeComponent();
		List<UserModel> users = new List<UserModel>
        {
            new UserModel { Name = "John Doe", Details = "Details about John" , Img="nora.png"},
            new UserModel { Name = "Jane Smith", Details = "Details about Jane" , Img="dotnet_bot.png"},
            new UserModel { Name = "Sam Brown", Details = "Details about Sam" , Img="nora.png"}
        };
        ListView1.ItemsSource = users;
        ListView2.ItemsSource = users;
    }
}