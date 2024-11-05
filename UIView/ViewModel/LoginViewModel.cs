using BusinessObject.IService;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using UIView.View;
using UIView.Properties;

namespace UIView.ViewModel
{
    public class LoginViewModel : ObservableObject
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public LoginViewModel(IUserService userService, IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;
        }

        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private IAsyncRelayCommand _loginCommand;
        public IAsyncRelayCommand LoginCommand =>
            _loginCommand ??= new AsyncRelayCommand(LoginAsync);

        private async Task LoginAsync()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var user = await _userService.Login(Username, Password);
            if (user != null)
            {
                Settings.Default.Role = user.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase) ? 0 : 1;
                Settings.Default.UserName = user.Username;
                Settings.Default.Save();

                var menuPage = _serviceProvider.GetRequiredService<MenuPage>();
                menuPage.Show();

                Application.Current.Windows.OfType<LoginPage>().FirstOrDefault()?.Close();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }
        }
    }
}
