using Esame.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Esame.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Enabled;
        }
        
        private void btnStart_click(object sender, RoutedEventArgs e)
        {
            var res = gruppoDetail.generateGroupList();

            this.DataContext = res;
        }
    }
}
