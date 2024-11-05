using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using UIView.ViewModel;

namespace UIView.View
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Window
    {
        private readonly IServiceProvider _serviceProvider;

        public MenuPage(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            DataContext = new MenuViewModel(serviceProvider);
        }    
    }
}
