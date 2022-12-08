using MyTrainingLib;
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
            Person person = new Person
            {
                Email = EmailBox.Text,
                Password = PasswordBox.Password
            };

            string rePassword = RePasswordBox.Password;

            bool emailcheck = person.Email.Length < 7 || !person.Email.Contains("@") || !person.Email.Contains(".");
            bool passRepasscheck = person.Password != rePassword;
            bool passcheck = person.Password.Length < 5;
            bool repasscheck = rePassword.Length < 5;

                if (emailcheck)
                {
                    CheckEmail(EmailBox, BorderEmail);
                    emailcheck = true;
                    
                }

                if (passRepasscheck)
                {
                    CheckPassword(PasswordBox, BorderPassword, RePasswordBox, BorderRePassword);
                    passRepasscheck = true;
                   
                }

                if (passcheck)
                {
                    CheckPassword(PasswordBox, BorderPassword);
                    passcheck = true;
                    
                }

                if (repasscheck)
                {
                    CheckPassword(RePasswordBox, BorderRePassword);
                    repasscheck = true;                    
                }

                if (emailcheck==false && passRepasscheck==false && passcheck == false && repasscheck == false)
                {

                NavigationService.Navigate(new InPutWindow());
            }









        }

        private void CheckEmail(TextBox emailBox, Border emailBorder)
        {
            emailBox.ToolTip = "Некорректное эл. почта";
            emailBorder.Background = Brushes.Red;
            emailBox.Background = Brushes.Red;
        }


        private void CheckPassword(PasswordBox passwordBox, Border borderPassword, PasswordBox rePasswordBox, Border borderRePassword)
        {
                rePasswordBox.ToolTip = "Неодинаковые пароли!";
                rePasswordBox.Background = Brushes.Red;
                borderRePassword.Background = Brushes.Red;
                passwordBox.ToolTip = "Неодинаковые пароли!";
                passwordBox.Background = Brushes.Red;
                borderPassword.Background = Brushes.Red;
        }

        private void CheckPassword(PasswordBox passwordBox, Border borderPassword)
        {
                passwordBox.ToolTip = "Некорректный пароль!";
                passwordBox.Background = Brushes.Red;
                borderPassword.Background = Brushes.Red;
        }


    }

    
}
