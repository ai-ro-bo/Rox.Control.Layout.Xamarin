using Xamarin.Forms.Platform.WPF;

namespace Rox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
        : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadApplication(new HarnessApplication());
        }
    }
}