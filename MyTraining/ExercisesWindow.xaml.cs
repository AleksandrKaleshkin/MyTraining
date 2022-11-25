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
using System.Windows.Shapes;

namespace MyTraining
{
    /// <summary>
    /// Логика взаимодействия для ExercisesWindow.xaml
    /// </summary>
    public partial class ExercisesWindow : Window
    {
        public ExercisesWindow()
        {
            InitializeComponent();
        }

        private void Exercises_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ExercisesPage();
        }
    }
}
