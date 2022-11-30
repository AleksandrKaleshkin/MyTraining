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

namespace MyTraining
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Page
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void InPut_Click(object sender, RoutedEventArgs e)
        {


            NavigationService.Navigate(new InPutWindow());
        }

        private void Registration_click(object sender, RoutedEventArgs e)
        {
            string email = EmailBox.Text;
            string password = PasswordBox.Password;
            string rePassword = RePasswordBox.Password;

            if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                EmailBox.ToolTip = "Некорректное эл. почта";
                BorderEmail.Background = Brushes.Red;
                EmailBox.Background = Brushes.Red;
            }
            if (password!=rePassword)
            {
                RePasswordBox.ToolTip = "Неодинаковые пароли!";
                RePasswordBox.Background = Brushes.Red;
                BorderRePassword.Background = Brushes.Red;
                PasswordBox.ToolTip = "Неодинаковые пароли!";
                PasswordBox.Background = Brushes.Red;
                BorderPassword.Background = Brushes.Red;
            }
            if (password.Length < 5)
            {

                PasswordBox.ToolTip = "Некорректный пароль!";
                PasswordBox.Background = Brushes.Red;
                BorderPassword.Background = Brushes.Red;
            }

            if (rePassword.Length < 5)
            {
                RePasswordBox.ToolTip = "Некорректный пароль!";
                RePasswordBox.Background = Brushes.Red;
                BorderRePassword.Background = Brushes.Red;
            }
            else
            {
                NavigationService.Navigate(new InPutWindow());
            }

        }
    }
}
