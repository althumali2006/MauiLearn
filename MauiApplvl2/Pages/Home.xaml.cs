namespace MauiApplvl2.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void BtnTransactions_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new InsertPage1());
    }
}