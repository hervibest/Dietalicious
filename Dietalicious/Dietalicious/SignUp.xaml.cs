﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dietalicious
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow signUp = new MainWindow();
            signUp.Show();
        }
        private void Login(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow signUp = new MainWindow();
            signUp.Show();

        }
    }
}

