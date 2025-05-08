using MauiApplvl2.Data;
using MauiApplvl2.Models;

namespace MauiApplvl2.Pages;

public partial class InsertPage1 : ContentPage
{
    public InsertPage1()
    {
        InitializeComponent();
    }

    private void BtnInsert_Clicked(object sender, EventArgs e)
    {
        SqlService sqlService = new SqlService();
        Student student = new Student()
        {
            Name = NameEntry.Text,
            Age = Convert.ToInt32(AgeEntry.Text),
            Gender = GenderEntry.Text
        };
        int result = sqlService.insert(student);
        if (result <= 0)
            DisplayAlert("Error", "Your data weren't inserted", "OK");
        else
        {
            DisplayAlert("Success", "Your data were inserted", "OK");
            NameEntry.Text=string.Empty;
            AgeEntry.Text=string.Empty;
            GenderEntry.Text=string.Empty;
        }
    }
}