﻿using System;
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


            ExercisesWindow exercisesWindow = new ExercisesWindow();
            exercisesWindow.ShowDialog();

        }
    }
}
