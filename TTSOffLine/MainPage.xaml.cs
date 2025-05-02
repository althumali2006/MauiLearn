namespace TTSOffLine
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            TextToSpeech.Default.SpeakAsync("Hello World", new SpeechOptions { Pitch = 0, Volume = 1 }, CancellationToken.None);
        }

        private void BtnSpeak_Clicked(object sender, EventArgs e)
        {
            TextToSpeech.Default.SpeakAsync(WordEntry.Text, new SpeechOptions { Pitch = 0, Volume = 1 }, CancellationToken.None);
        }
    }

}
