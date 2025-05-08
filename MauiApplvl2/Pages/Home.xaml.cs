using MauiApplvl2.Data;
using MauiApplvl2.Models;

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
            DisplayAlert("Error", ex.Message, "OK");
        }
        SqlService sqlService = new SqlService();
        MyList.ItemsSource = sqlService.GetAll();
    }

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InsertPage1());
    }

    private void MyList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedItem = e.SelectedItem as Student;
        Navigation.PushAsync(new UpdatePage(selectedItem));
    }
}