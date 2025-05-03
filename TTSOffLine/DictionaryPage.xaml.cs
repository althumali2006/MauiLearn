using System.Linq;
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

    private void MyList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var locales = TextToSpeech.Default.GetLocalesAsync().Result;
        var word = e.SelectedItem as TTSOffLine.Models.WordModel;
        TextToSpeech.Default.SpeakAsync($"In Arabic.", new SpeechOptions { Pitch = 0f, Volume = 1f , Locale= locales.FirstOrDefault(l => l.Language == "en-UK") });
        TextToSpeech.Default.SpeakAsync($"{word.Arab}", new SpeechOptions { Pitch = 0f, Volume = 1f, Locale = locales.FirstOrDefault(l => l.Language == "ar-SA") });
        TextToSpeech.Default.SpeakAsync($". In English. {word.Eng}", new SpeechOptions { Pitch = 0f, Volume = 1f, Locale = locales.FirstOrDefault(l => l.Language == "en-UK") });
    }
}