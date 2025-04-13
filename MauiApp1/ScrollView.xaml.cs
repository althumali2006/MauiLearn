namespace MauiApp1;

public partial class ScrollView : ContentPage
{
    public ScrollView()
    {
        InitializeComponent();
    }
    public ScrollView(string Name)
	{
		InitializeComponent();
		NameLabel.Text = Name;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}