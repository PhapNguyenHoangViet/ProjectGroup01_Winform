using Group01_QuanLyLuanVan.Model;
using Group01_QuanLyLuanVan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using Group01_QuanLyLuanVan.Properties;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class TeacherMainViewModel : BaseViewModel
    {
        public ICommand Loadwd { get; set; }
        public static Frame MainFrame { get; set; }

        public ICommand LoadPageCM { get; set; }
        public ICommand TeacherUpdateInforCM { get; set; }

        public ICommand SignoutCM { get; set; }
        public ICommand HomeCM { get; set; }

        public TeacherMainViewModel()
        {
            LoadPageCM = new RelayCommand<Frame>((p) => { return true; }, (p) =>
            {
                MainFrame = p;
                p.Content = new HomeView();
            });

            HomeCM = new RelayCommand<Frame>((P) => { return true; }, (P) =>
            {
                MainFrame.Content = new HomeView();
            });


            TeacherUpdateInforCM = new RelayCommand<Frame>((p) => { return true; }, (p) =>
            {
                MainFrame.Content = new TeacherUpdateInforView();
            });

            SignoutCM = new RelayCommand<FrameworkElement>((p) => { return p == null ? false : true; }, (p) =>
            {
                Window oldWindow = App.Current.MainWindow;
                LoginView loginView = new LoginView();
                App.Current.MainWindow = loginView;
                oldWindow.Close();
                loginView.Show();
            });
        }
    }
}
