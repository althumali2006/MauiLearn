
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace TTSOffLine
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            //var locales = TextToSpeech.Default.GetLocalesAsync().Result;
            //TextToSpeech.Default.SpeakAsync("Hello", new SpeechOptions { Pitch = 0, Volume = 1, Locale = locales.FirstOrDefault(l => l.Language == "en-UK" || l.Language == "en-GB") }, CancellationToken.None);
        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();  // تأكد من استدعاء القاعدة أولاً

            // مثال: جلب locales ثم تشغيل TTS
            await Task.Delay(200);
            var locales = await TextToSpeech.Default.GetLocalesAsync();
            /*
            foreach (var loc in locales)
            {
                Locales.Text += $"Name: {loc.Name}, Languag: {loc.Language},Country: {loc.Country}\n";
            }
            */
            //var localeGb = locales.FirstOrDefault(l => l.Language == "en-GB");
            //var localeGb = locales.FirstOrDefault(l => l.Language == "en-GB" || l.Language == "en-UK");
            var localeGb = locales.FirstOrDefault(l => l.Language == "en-GB")
                     ?? locales.FirstOrDefault(l => l.Language == "en-UK")
                     ?? locales.FirstOrDefault(l => l.Language == "en-US")
                     ?? locales.FirstOrDefault(l => l.Country=="GB")
                     ?? locales.FirstOrDefault();
            if (localeGb != null)
            {
                var options = new SpeechOptions
                {
                    Locale = localeGb,
                    Pitch = 0f,
                    Volume = 1f
                };
                await Task.Delay(200);
                await TextToSpeech.Default.SpeakAsync("Hello from the UK!", options);
            }
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
                    Locale = locales.FirstOrDefault(l => l.Language == "en-UK" || l.Language == "en-GB")
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
