using MauiApplvl2.Data;

namespace MauiApplvl2.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
        InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        try
        {
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.GenerateSql();
        }
        catch (Exception ex)
        {
            ExLabel.Text = ex.Message;
        }
    }
    private void BtnTransactions_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new InsertPage1());
    }

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InsertPage1());
    }
}