using BusinessObject.IService;
using BusinessObject.Service;
using DataAccess.IRepository;
using DataAccess.Models;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;
using UIView.View;
using UIWiew.ViewModel;

namespace UIView
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }
        public IConfiguration Configuration { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureAppSettings(serviceCollection);
            RegisterDbContext(serviceCollection);
            RegisterServices(serviceCollection);
            RegisterRepositories(serviceCollection);
            RegisterViewModels(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            ServiceProvider.GetRequiredService<ProductPage>().Show();
        }

        private void ConfigureAppSettings(ServiceCollection services)
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = configurationBuilder.Build();
            services.AddSingleton<IConfiguration>(Configuration);
        }

        private void RegisterDbContext(IServiceCollection services)
        {
            services.AddDbContext<ProjectPRN221Context>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("value"))); 
        }

        private void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IBranchService, BranchService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ISupplierService, SupplierService>();
        }

        private void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IInventoryTransactionRepository, InventoryTransactionRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            services.AddScoped<IStaffScheduleRepository, StaffScheduleRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        private void RegisterViewModels(IServiceCollection services)
        {
            services.AddTransient<ProductViewModel>();
            services.AddTransient<ProductPage>();
        }
    }
}
