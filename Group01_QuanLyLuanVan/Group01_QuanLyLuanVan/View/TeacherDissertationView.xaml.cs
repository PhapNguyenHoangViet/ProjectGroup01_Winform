﻿using Group01_QuanLyLuanVan.ViewModel;
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

namespace Group01_QuanLyLuanVan.View
{
    /// <summary>
    /// Interaction logic for TeacherDissertationView.xaml
    /// </summary>
    public partial class TeacherDissertationView : Page
    {
        public TeacherDissertationView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TeacherAddDissertationView addTopicView = new TeacherAddDissertationView();
            TeacherMainViewModel.MainFrame.Content = addTopicView;
        }
    }
}
