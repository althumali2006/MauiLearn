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
        if (!string.IsNullOrEmpty(_choice.ToString()))
            LblChoice.Text = $" {_choice.ToString()}";
    }

    private async void BtnAlert3_Clicked(object sender, EventArgs e)
    {
        var _choice = await DisplayActionSheet("Multiples_Title", "Ok", "Yes", "Act1", "Act2", "Act3");
        if (!string.IsNullOrEmpty(_choice))
            LblMultiChoice.Text = $" {_choice}";
    }

    private async void BtnAlert4_Clicked(object sender, EventArgs e)
    {
        var _choice = await DisplayPromptAsync("Enter Text", "Enter Message", "OK", "Cancel", "message here...", -1);
        if (!string.IsNullOrEmpty(_choice))
            LblDisplayPropmptChoice.Text = _choice;
    }
}