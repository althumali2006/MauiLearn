using TTSOffLine.Data;
namespace TTSOffLine;

public partial class DictionaryPage : ContentPage
{
    public DictionaryPage()
    {
        InitializeComponent();
        DB list = new DB();
        var Dict = list.GetAll();
        MyList.ItemsSource = Dict;
    }
}