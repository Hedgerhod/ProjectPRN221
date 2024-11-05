using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using UIView.Properties;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using UIView.View;
using System.Windows;

namespace UIView.ViewModel
{
    public class MenuViewModel : ObservableObject
    {
        private readonly IServiceProvider _serviceProvider;

        private bool _isAdmin;
        public bool IsAdmin
        {
            get => _isAdmin;
            set
            {
                SetProperty(ref _isAdmin, value);
                UpdateButtonVisibility();
            }
        }

        private string _userRole;
        public string UserRole
        {
            get => _userRole;
            set => SetProperty(ref _userRole, value);
        }

        public Visibility UserManagementVisibility { get; private set; }
        public Visibility CategoryManagementVisibility { get; private set; }
        public Visibility BranchManagementVisibility { get; private set; }
        public Visibility SupplierManagementVisibility { get; private set; }
        public Visibility ProductManagementVisibility { get; private set; }
        public Visibility OrderManagementVisibility { get; private set; }
        public Visibility OrderDetailsManagementVisibility { get; private set; }
        public Visibility InventoryTransactionVisibility { get; private set; }
        public Visibility ScheduleManagementVisibility { get; private set; }
        public Visibility LeaveRequestsVisibility { get; private set; }
        public Visibility ReportsVisibility { get; private set; }

        private IRelayCommand _productManageCommand;
        private IRelayCommand _logoutCommand;



        public IRelayCommand ProductManageCommand =>
            _productManageCommand ??= new RelayCommand(ExcuteProduct);
        public IRelayCommand LogoutCommand =>
            _logoutCommand ??= new RelayCommand(ExecuteLogout);

        public MenuViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            IsAdmin = Settings.Default.Role == 0;
            UserRole = IsAdmin ? "Admin" : "Staff";
            UpdateButtonVisibility();
        }

        private void UpdateButtonVisibility()
        {
            // admin
            UserManagementVisibility = IsAdmin ? Visibility.Visible : Visibility.Collapsed;
            CategoryManagementVisibility = IsAdmin ? Visibility.Visible : Visibility.Collapsed;
            BranchManagementVisibility = IsAdmin ? Visibility.Visible : Visibility.Collapsed;
            SupplierManagementVisibility = IsAdmin ? Visibility.Visible : Visibility.Collapsed;
            ScheduleManagementVisibility = IsAdmin ? Visibility.Visible : Visibility.Collapsed;
            ReportsVisibility = IsAdmin ? Visibility.Visible : Visibility.Collapsed;

            // admin + staff
            ProductManagementVisibility = Visibility.Visible;
            OrderManagementVisibility = Visibility.Visible;
            OrderDetailsManagementVisibility = Visibility.Visible;
            InventoryTransactionVisibility = Visibility.Visible;
            LeaveRequestsVisibility = Visibility.Visible;

            OnPropertyChanged(nameof(UserManagementVisibility));
            OnPropertyChanged(nameof(CategoryManagementVisibility));
            OnPropertyChanged(nameof(BranchManagementVisibility));
            OnPropertyChanged(nameof(SupplierManagementVisibility));
            OnPropertyChanged(nameof(ScheduleManagementVisibility));
            OnPropertyChanged(nameof(ReportsVisibility));
            OnPropertyChanged(nameof(ProductManagementVisibility));
            OnPropertyChanged(nameof(OrderManagementVisibility));
            OnPropertyChanged(nameof(OrderDetailsManagementVisibility));
            OnPropertyChanged(nameof(InventoryTransactionVisibility));
            OnPropertyChanged(nameof(LeaveRequestsVisibility));

        }

        private void ExcuteProduct()
        {
            var productPage = _serviceProvider?.GetRequiredService<ProductPage>();
            productPage?.Show();

            Application.Current.Windows.OfType<MenuPage>().FirstOrDefault()?.Close();
        }

        private void ExecuteLogout()
        {
            Settings.Default.Role = -1;
            Settings.Default.UserName = string.Empty;
            Settings.Default.Save();

            var loginPage = _serviceProvider?.GetRequiredService<LoginPage>();
            loginPage?.Show();

            Application.Current.Windows.OfType<MenuPage>().FirstOrDefault()?.Close();
        }
    }
}
