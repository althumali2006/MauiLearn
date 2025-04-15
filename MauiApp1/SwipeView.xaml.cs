using MauiApp1.Models;

namespace MauiApp1;

public partial class SwipeView : ContentPage
{
    public SwipeView()
    {
        InitializeComponent();
        List<UserModel> users = new List<UserModel>
        {
            new UserModel { Name = "John Doe", Details = "Details about John" , Img="nora.png"},
            new UserModel { Name = "Jane Smith", Details = "Details about Jane" , Img="dotnet_bot.png"},
            new UserModel { Name = "Sam Brown", Details = "Details about Sam" , Img="image.jpg"}
        };
        SwipedList1.ItemsSource = users;
    }

    private void SwipeItem_Clicked(object sender, EventArgs e)
    {
        var swipeItem = sender as MenuItem;
        string swipedName="NULL";
        if (swipeItem != null)
            swipedName = swipeItem.CommandParameter!=null? swipeItem.CommandParameter.ToString():"NULL";
        if (swipeItem != null)
            Navigation.PushAsync(new SwipeSelctedViewed(swipedName));
    }
}