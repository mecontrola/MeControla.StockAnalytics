using Microsoft.DotNetCore.Hosting.WPF;
using System.Windows;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class MainViewModel
    {
        private BaseViewModel currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }

        private Visibility progressBarVisibility = Visibility.Collapsed;
        public Visibility ProgressBarVisibility
        {
            get { return progressBarVisibility; }
            set { SetProperty(ref progressBarVisibility, value); }
        }

        private bool menuEnabled = true;
        public bool MenuEnabled
        {
            get { return menuEnabled; }
            set { SetProperty(ref menuEnabled, value); }
        }
    }
}