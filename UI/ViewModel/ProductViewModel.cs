using DataAccess.Models;
using BusinessObject.IService;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Diagnostics;
using BusinessObject.DTO;

namespace UI.ViewModel
{
    public class ProductViewModel : ViewModelBase
    {
        private readonly IProductService _productService;
        private ObservableCollection<ProductDTO> _products;

        public ObservableCollection<ProductDTO> Products
        {
            get => _products;
            set => SetProperty(ref _products, value, nameof(Products));
        }

        public ProductViewModel(IProductService productService)
        {
            _productService = productService;
            Products = new ObservableCollection<ProductDTO>();
            LoadProductsAsync();
        }

        private async void LoadProductsAsync()
        {
            var products = await _productService.GetAllProductsAsync();
            Products.Clear();
            foreach (var product in products)
            {
                Products.Add(product);
            }
        }
    }
}
