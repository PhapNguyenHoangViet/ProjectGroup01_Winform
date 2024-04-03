using Group01_QuanLyLuanVan.Model;
using Group01_QuanLyLuanVan.Properties;
using Group01_QuanLyLuanVan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Group01_QuanLyLuanVan.ViewModel
{

    public class ADMainViewModel : BaseViewModel
    {
        public static Frame MainFrame { get; set; }

        public ICommand LoadPageCM { get; set; }
        public ICommand SignoutCM { get; set; }

        public ADMainViewModel()
        {
            LoadPageCM = new RelayCommand<Frame>((p) => { return true; }, (p) =>
            {
                MainFrame = p;
                p.Content = new HomeView();
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
