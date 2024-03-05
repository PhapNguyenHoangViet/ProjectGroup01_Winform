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

namespace Group01_QuanLyLuanVan.View
{
    /// <summary>
    /// Interaction logic for LoginPageView.xaml
    /// </summary>
    public partial class LoginPageView : Page
    {
        public LoginPageView()
        {
            InitializeComponent();
        }

        private void OpenSignUp(object sender, RoutedEventArgs e)
        {
            SignUpView signUpView = new SignUpView();
            signUpView.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TeacherMainView teacherMainView = new TeacherMainView();
            teacherMainView.Show();
        }
    }
}
