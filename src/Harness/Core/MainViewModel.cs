using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rox
{
    public class MainViewModel
        : ViewModelBase
    {
        private readonly MainView MainView;
        public MainViewModel(MainView mainView)
        {
            MainView = mainView;

            WrapLayoutCommand = new Command(async () =>
            {
                WrapLayoutView wrapLayoutView = new WrapLayoutView();
                WrapLayoutViewModel wrapLayoutViewModel = new WrapLayoutViewModel();
                wrapLayoutView.BindingContext = wrapLayoutViewModel;

                await MainView.Navigation.PushAsync(wrapLayoutView);
            });

            WrapAlignmentCommand = new Command(async () =>
            {
                WrapAlignmentView wrapAlignmentView = new WrapAlignmentView();
                WrapAlignmentViewModel wrapAlignmentViewModel = new WrapAlignmentViewModel();
                wrapAlignmentView.BindingContext = wrapAlignmentViewModel;

                await MainView.Navigation.PushAsync(wrapAlignmentView);
            });

            WrapTextCommand = new Command(async () =>
            {
                WrapTextView wrapTextView = new WrapTextView();
                WrapTextViewModel wrapTextViewModel = new WrapTextViewModel();
                wrapTextView.BindingContext = wrapTextViewModel;

                await MainView.Navigation.PushAsync(wrapTextView);
            });

            OverlayLayoutCommand = new Command(async () =>
            {
                OverlayLayoutView overlayLayoutView = new OverlayLayoutView();
                OverlayLayoutViewModel overlayLayoutViewModel = new OverlayLayoutViewModel();
                overlayLayoutView.BindingContext = overlayLayoutViewModel;

                await MainView.Navigation.PushAsync(overlayLayoutView);
            });

            OverlayImageCommand = new Command(async () =>
            {
                OverlayImageView overlayImageView = new OverlayImageView();
                OverlayImageViewModel overlayImageViewModel = new OverlayImageViewModel(this);
                overlayImageView.BindingContext = overlayImageViewModel;

                await MainView.Navigation.PushAsync(overlayImageView);
            });
        }

        public ICommand WrapLayoutCommand { get; }

        public ICommand WrapAlignmentCommand { get; }

        public ICommand WrapTextCommand { get; }

        public ICommand OverlayLayoutCommand { get; }

        public ICommand OverlayImageCommand { get; }

        public Task DisplayMessage(string messageText, string buttonText)
        {
            return MainView.DisplayAlert("Leo Wanker Sample for Layouts", messageText, buttonText);
        }
    }
}