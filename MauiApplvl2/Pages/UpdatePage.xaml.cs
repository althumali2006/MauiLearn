using MauiApplvl2.Data;
using MauiApplvl2.Models;

namespace MauiApplvl2.Pages;

public partial class UpdatePage : ContentPage
{
    private long _id = -1;
    SqlService sqlService = new SqlService();
    public UpdatePage()
	{
		InitializeComponent();
	}
    public UpdatePage(Student student)
    {
        InitializeComponent();
        _id = student.Id;
        NameEntry.Text = student.Name;
        AgeEntry.Text = student.Age.ToString();
        GenderEntry.Text = student.Gender;
    }

    private void BtnSave_Clicked(object sender, EventArgs e)
    {
        try
        {
            var resStudent = sqlService.GetStudent(_id);
            if (resStudent != null)
            {
                var res=sqlService.GetStudent(_id);
                res.Name = NameEntry.Text;
                res.Age=Convert.ToInt32(AgeEntry.Text);
                res.Gender=GenderEntry.Text;
                var resUpdate = sqlService.UpdateStudent(res);
                if (resUpdate > 0)
                {
                    DisplayAlert("Success", "Item successfully updated", "OK");
                }
                else
                {
                    DisplayAlert("Error", "Item not updated", "OK");
                }
                return;
            }
            else
            {
                DisplayAlert("Error", "Item not found", "OK");
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }

    private void BtnDelete_Clicked(object sender, EventArgs e)
    {
        try
        {
            var resStudent= sqlService.GetStudent(_id);
            if (resStudent != null)
            {
                var res = sqlService.DeleteStudent(resStudent);
                if (res < 1)
                {
                    DisplayAlert("Error", "Item not deleted", "OK");
                    return;
                }
                else
                {
                    DisplayAlert("Success", "Item successfully deleted", "OK");
                    return;
                }
            }
            else
            {
                DisplayAlert("Error", "Item not found", "OK");

            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }
}