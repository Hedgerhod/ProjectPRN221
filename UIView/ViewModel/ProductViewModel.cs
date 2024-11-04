using DataAccess.Models;
using BusinessObject.IService;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;
using BusinessObject.DTO;
using BusinessObject.Service;

namespace UIWiew.ViewModel
{
    public class ProductViewModel : ViewModelBase
    {
        private readonly IProductService _productService;
        private readonly ISupplierService _supplierService;
        private readonly IBranchService _branchService;
        private readonly ICategoryService _categoryService;

        private ObservableCollection<ProductDTO> _products;
        private ObservableCollection<SupplierDTO> _suppliers;
        private ObservableCollection<BranchDTO> _branches;
        private ObservableCollection<CategoryDTO> _categories;

        private string _productNameFilter;
        private decimal _maxPriceFilter;
        private int? _selectedSupplierId;
        private int? _selectedBranchId;
        private int? _selectedCategoryId;

        public ObservableCollection<ProductDTO> Products
        {
            get => _products;
            set => SetProperty(ref _products, value, nameof(Products));
        }

        public ObservableCollection<SupplierDTO> Suppliers
        {
            get => _suppliers;
            set => SetProperty(ref _suppliers, value, nameof(Suppliers));
        }

        public ObservableCollection<BranchDTO> Branches
        {
            get => _branches;
            set => SetProperty(ref _branches, value, nameof(Branches));
        }

        public ObservableCollection<CategoryDTO> Categories
        {
            get => _categories;
            set => SetProperty(ref _categories, value, nameof(Categories));
        }
        public string ProductNameFilter
        {
            get => _productNameFilter;
            set
            {
                SetProperty(ref _productNameFilter, value, nameof(ProductNameFilter));
                FilterProductsAsync();
            }
        }

        public decimal MaxPriceFilter
        {
            get => _maxPriceFilter;
            set
            {
                SetProperty(ref _maxPriceFilter, value, nameof(MaxPriceFilter));
                FilterProductsAsync();
            }
        }

        public int? SelectedSupplierId
        {
            get => _selectedSupplierId;
            set
            {
                SetProperty(ref _selectedSupplierId, value, nameof(SelectedSupplierId));
                FilterProductsAsync();
            }
        }

        public int? SelectedBranchId
        {
            get => _selectedBranchId;
            set
            {
                SetProperty(ref _selectedBranchId, value, nameof(SelectedBranchId));
                FilterProductsAsync();
            }
        }

        public int? SelectedCategoryId
        {
            get => _selectedCategoryId;
            set
            {
                SetProperty(ref _selectedCategoryId, value, nameof(SelectedCategoryId));
                FilterProductsAsync();
            }
        }

        public ProductViewModel(IProductService productService, IBranchService branchService, ICategoryService categoryService, ISupplierService supplierService)
        {
            _productService = productService;
            _supplierService = supplierService;
            _branchService = branchService;
            _categoryService = categoryService;

            Products = new ObservableCollection<ProductDTO>();
            Suppliers = new ObservableCollection<SupplierDTO>();
            Branches = new ObservableCollection<BranchDTO>();
            Categories = new ObservableCollection<CategoryDTO>();

            InitializeAsync();
        }
        public async Task InitializeAsync()
        {
            await LoadProductsAsync();
            await LoadSuppliersAsync();
            await LoadBranchesAsync();
            await LoadCategoriesAsync();
        }

        private async Task LoadProductsAsync()
        {
            var products = await _productService.GetAllProductsAsync();
            Products.Clear();
            foreach (var product in products)
            {
                Products.Add(product);
            }
        }

        private async Task LoadSuppliersAsync()
        {
            var suppliers = await _supplierService.GetAllSuppliersAsync();
            Suppliers.Clear();
            foreach (var supplier in suppliers)
            {
                Suppliers.Add(supplier);
            }
        }

        private async Task LoadBranchesAsync()
        {
            var branches = await _branchService.GetAllBranchesAsync();
            Branches.Clear();
            foreach (var branch in branches)
            {
                Branches.Add(branch);
            }
        }
        private async Task LoadCategoriesAsync()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            Categories.Clear();
            foreach (var category in categories)
            {
                Categories.Add(category);
            }
        }

        private async Task FilterProductsAsync()
        {
             await FilterProducts();
        }
        private async Task FilterProducts()
        {
            var filteredProducts = await _productService.GetAllProductsAsync();
            var filtered = filteredProducts.Where(p =>
                (string.IsNullOrEmpty(ProductNameFilter) || p.ProductName.Contains(ProductNameFilter)) &&
                (MaxPriceFilter == 0 || p.Price <= MaxPriceFilter) &&
                (SelectedSupplierId == null || p.SupplierId == SelectedSupplierId) &&
                (SelectedBranchId == null || p.BranchId == SelectedBranchId) &&
                (SelectedCategoryId == null || p.CategoryId == SelectedCategoryId)).ToList();

            Products.Clear();
            foreach (var product in filtered)
            {
                Products.Add(product);
            }
        }
    }
}
