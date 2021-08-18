namespace Rox
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadApplication(new HarnessApplication());
        }
    }
}