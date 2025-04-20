namespace MauiApp1;

public partial class Alerts : ContentPage
{
    public Alerts()
    {
        InitializeComponent();
    }

    private void BtnAlert_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Alert", "Alert Shown", "OK");
    }

    private async void BtnAlert2_Clicked(object sender, EventArgs e)
    {
        var _choice = await DisplayAlert("Alert", "Alert Shown", "Accept", "Reject");
        LblChoice.Text = " " + _choice.ToString();
    }
}