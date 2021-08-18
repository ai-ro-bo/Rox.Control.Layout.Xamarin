using System.Windows.Input;
using Xamarin.Forms;

namespace Rox
{
    public class OverlayImageViewModel
        : ViewModelBase
    {
        public OverlayImageViewModel(MainViewModel mainViewModel)
        {
            MoreInformationCommand = new Command(() =>
            {
                mainViewModel.DisplayMessage("Leo Wanker is a stuntman extrordinaire!", "I Concur");
            });
        }

        public ICommand MoreInformationCommand { get; }
    }
}