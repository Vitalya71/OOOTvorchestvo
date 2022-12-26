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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            var curentDBUser = TvorchestvoEntities.GetContact().User.ToList();
            var turrentDate = curentDBUser.Where(p => (p.UserLogin == TBLogin.Text) && (p.UserPassword == TBPassword.Text)).FirstOrDefault();
            if (turrentDate != null)
                NavigationService.Navigate(new Captcha());
            else
                MessageBox.Show("Вы ввели некорректные данные, пожалуйста проверьте и войдите заново");

        }

        private void BtnGuest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductList());
        }
    }
}
