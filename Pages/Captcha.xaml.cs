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

namespace OOOTvorchestvo.Pages
{
    /// <summary>
    /// Логика взаимодействия для Captcha.xaml
    /// </summary>
    public partial class Captcha : Page
    {
        public Captcha()
        {
            InitializeComponent();
            GenerationCaptcha();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (TBGeneragionCaptcha.Text == TBInputCaptcha.Text)
            {
                NavigationService.Navigate(new ProductList());
            }

        }
        public void GenerationCaptcha()
        {
            Random rand = new Random();
            TBGeneragionCaptcha.Text += "";
            for (int i = 0; i < 5; i++)
            {
                TBGeneragionCaptcha.Text += (char)('a' + rand.Next(26));

            }


        }

        private void BtnRefreshCaptcha_Click(object sender, RoutedEventArgs e)
        {
            GenerationCaptcha();
        }
    }
}

