using Proquire.View;
using Xamarin.Forms;

namespace Proquire
{
    public partial class App : Application
    {
        
        public static string User = "kamta";
        public App()
        {
            InitializeComponent();

            //MainPage = new ProquirePage();
            MainPage = new ChatPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
