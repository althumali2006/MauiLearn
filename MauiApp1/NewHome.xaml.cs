namespace MauiApp1;

public partial class NewHome : ContentPage
{
	public NewHome()
	{
		InitializeComponent();
	}

    private void BtnPush_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ScrollView());
    }
}