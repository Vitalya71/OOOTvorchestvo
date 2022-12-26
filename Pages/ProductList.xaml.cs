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
using System.Windows.Navigation;
using System.Windows.Shapes;
using OOOTvorchestvo.Entities;
using OOOTvorchestvo.Pages;

namespace OOOTvorchestvo.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductList.xaml
    /// </summary>
    public partial class ProductList : Page
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void FindProductName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var txtfind = TvorchestvoEntities.GetContact().Product.ToList();
            var txtvodd = txtfind.Where(k => (k.ProductName.ToLower().Contains(FindProductName.Text)));

        }



    }
}
