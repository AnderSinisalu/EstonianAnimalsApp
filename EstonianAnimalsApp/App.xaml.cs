using EstonianAnimalsApp.Views;

namespace EstonianAnimalsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AnimalsPage();
        }
    }
}
