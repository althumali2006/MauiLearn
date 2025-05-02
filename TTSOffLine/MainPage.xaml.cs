namespace TTSOffLine
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            TextToSpeech.Default.SpeakAsync("Hello World", new SpeechOptions { Pitch = 0, Volume = 1 }, CancellationToken.None);
        }

        private async void BtnSpeak_Clicked(object sender, EventArgs e)
        {
            var locales = await TextToSpeech.Default.GetLocalesAsync();
            var options = new SpeechOptions
            {
                Pitch = 1f,              // 0.0–2.0
                Volume = 1f,             // 0.0–1.0
                Locale = locales.FirstOrDefault(l => l.Language == "en-US")
            };
            await TextToSpeech.Default.SpeakAsync(WordEntry.Text, options);

            //TextToSpeech.Default.SpeakAsync(WordEntry.Text, new SpeechOptions { Pitch = 1, Volume = 1 }, CancellationToken.None);
        }
    }
}
