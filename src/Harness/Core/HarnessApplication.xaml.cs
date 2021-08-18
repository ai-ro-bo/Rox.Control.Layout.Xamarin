﻿using Xamarin.Forms;

namespace Rox
{
    public partial class HarnessApplication
        : Application
    {
        public HarnessApplication()
        {
            InitializeComponent();

            MainView mainView = new MainView();
            MainViewModel mainViewModel = new MainViewModel(mainView);
            mainView.BindingContext = mainViewModel;
            NavigationPage navigationPage = new NavigationPage(mainView);

            MainPage = navigationPage;
        }
    }
}