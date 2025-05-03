namespace MauiApplvl2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Data.Db DB = new Data.Db();
            PeopleList.ItemsSource = DB.GetAll();
        }
    }
}
