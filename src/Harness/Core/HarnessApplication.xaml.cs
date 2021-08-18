using Xamarin.Forms;

namespace Rox
{
    public partial class HarnessApplication
        : Application
    {
        public HarnessApplication()
        {
            InitializeComponent();

            MainPage = new MainView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}