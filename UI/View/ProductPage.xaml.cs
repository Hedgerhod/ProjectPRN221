﻿using BusinessObject.IService;
using BusinessObject.Service;
using UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI.View
{
    /// <summary>
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Window
    {
        public ProductPage(IProductService productService)
        {
            InitializeComponent();
            DataContext = new ProductViewModel(productService);
        }
    }
}
