
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace TTSOffLine
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            var locales = TextToSpeech.Default.GetLocalesAsync().Result;
            TextToSpeech.Default.SpeakAsync("Hello", new SpeechOptions { Pitch = 0, Volume = 1, Locale = locales.FirstOrDefault(l => l.Language == "en-UK") }, CancellationToken.None);
        }

        private async void BtnSpeak_Clicked(object sender, EventArgs e)
        {
            try
            {
                var locales = await TextToSpeech.Default.GetLocalesAsync();
                var options = new SpeechOptions
                {
                    Pitch = 0f,              // 0.0–1.0
                    Volume = 1f,             // 0.0–1.0
                    Locale = locales.FirstOrDefault(l => l.Language == "en-UK")
                };
                await TextToSpeech.Default.SpeakAsync(WordEntry.Text, options);
                //TextToSpeech.Default.SpeakAsync(WordEntry.Text, new SpeechOptions { Pitch = 1, Volume = 1 }, CancellationToken.None);
            }
            catch (Exception ex)
            {
                DisplayAlert("Alert", ex.Message, "OK");
                //Toast.Make(ex.Message, ToastDuration.Long).Show();
            }            
        }
        private void ImgTap_Tapped(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new DictionaryPage());
        }
    }
}
