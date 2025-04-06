namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private string rd = "";
        double dim = 0.0;
        public MainPage()
        {
            InitializeComponent();
            //label3.Text = "test\nlabel3";
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            label3.IsVisible = true;
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            label3.IsVisible = false;
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
        }

        private void rA_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radres = (RadioButton)sender;
            rd = radres.Content?.ToString() ?? "!NULL!";
            rdLabel.Text = rd;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Slider slider = (Slider)sender;
            sliderValue.Text = slider.Value.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                img.Source = ImageSource.FromUri(new Uri("https://khamsat.hsoubcdn.com/assets/images/logo-73045c76e830509d4dbe03ea6172d22f047c708fed5435e93ffd47f80ee5ffa4.png"));
            }
            catch (Exception)
            {

            }
        }

        private void switch2_Clicked(object sender, EventArgs e)
        {
            try
            {
                img.Source = ImageSource.FromFile("nora.png");
            }
            catch (Exception)
            {

            }
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (boxView != null)
                boxView.BackgroundColor = Color.FromRgb((byte)sliderRed.Value, (byte)sliderGreen.Value, (byte)sliderBlue.Value);
        }

        private void sliderSquare_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (boxSquare != null)
            {
                boxSquare.WidthRequest = e.NewValue;
                boxSquare.HeightRequest = e.NewValue;
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender != null)
            {
                selectedFilter.Text = ((Picker)sender).SelectedItem.ToString();
            }
        }

        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (datePicker != null)
            {
                selectedDate.Text = e.NewDate.ToString("yyyy/MM/dd");
            }
        }
    }
}
