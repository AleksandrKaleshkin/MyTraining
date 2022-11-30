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
    /// Логика взаимодействия для InPutWindow.xaml
    /// </summary>
    public partial class InPutWindow : Page
    {
        public InPutWindow()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegWindow()); 

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Email = email.Text.ToLower();
            string Password = password.Password;

            if(Password.Length <5)
            {
                password.ToolTip = "Некорректный пароль!";
                password.Background = Brushes.Red;
                BorderPassword.Background = Brushes.Red;
            }

            else if ( Email.Length<5 || !Email.Contains("@") || !Email.Contains("."))
            {
                email.ToolTip = "Некорректное эл. почта";
                BorderEmail.Background = Brushes.Red;
                email.Background = Brushes.Red;
            }
            else
            {
                password.ToolTip = null;
                password.Background = Brushes.Transparent;


                password.ToolTip = null;
                password.Background = Brushes.Transparent;
                BorderPassword.Background = Brushes.Transparent;

                email.ToolTip = null;
                email.Background = Brushes.Transparent;
                BorderEmail.Background = Brushes.Transparent;

          
                MessageBox.Show(Email, Password);
                ExercisesWindow exercisesWindow = new ExercisesWindow();
                exercisesWindow.ShowDialog();
            }


        }
    }
}
