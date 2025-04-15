namespace MauiApp1;

public partial class SwipeSelctedViewed : ContentPage
{
    public SwipeSelctedViewed(string Name)
    {
        InitializeComponent();
        SwipedItemLabel.Text = Name;

    }
}