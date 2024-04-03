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
        private string ava;
        public string Ava { get => ava; set { ava = value; OnPropertyChanged(); } }
        private string tenDangNhap;
        public string TenDangNhap { get => tenDangNhap; set { tenDangNhap = value; OnPropertyChanged(); } }
        public ICommand Loadwd { get; set; }
        public static Frame MainFrame { get; set; }
        public ICommand LoadPageCM { get; set; }
        public ICommand TeacherUpdateInforCM { get; set; }
        public ICommand SignoutCM { get; set; }
        public ICommand HomeCM { get; set; }
        public ICommand TeacherDissertationCM { get; set; }
        public ICommand TeacherTaskCM { get; set; }
        public ICommand TeacherProgressCM { get; set; }
        public ICommand TeacherNotiCM { get; set; }
        public void LoadTenND(TeacherMainView p)
        {
            p.TenDangNhap.Text = Const.giangVien.HoTen;
        }

        public TeacherMainViewModel()
        {

            Loadwd = new RelayCommand<TeacherMainView>((p) => true, (p) => _Loadwd(p));

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

            TeacherDissertationCM = new RelayCommand<Frame>((p) => { return true; }, (p) =>
            {
                MainFrame.Content = new TeacherDissertationView();
            });

            TeacherTaskCM = new RelayCommand<Frame>((p) => { return true; }, (p) =>
            {
                MainFrame.Content = new TeacherTaskView();
            });

            TeacherProgressCM = new RelayCommand<Frame>((p) => { return true; }, (p) =>
            {
                MainFrame.Content = new TeacherProgressView();
            });

            TeacherNotiCM = new RelayCommand<Frame>((p) => { return true; }, (p) =>
            {
                MainFrame.Content = new TeacherNotiView();
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

        void _Loadwd(TeacherMainView p)
        {
            if (Const.taiKhoan.Avatar == "/Resource/Image/addava.png")
                Ava = Const._localLink + "/Resource/Image/addava.png";
            else
                Ava = Const._localLink + "/Resource/Ava/" + Const.taiKhoan.Username + ((Const.taiKhoan.Avatar.Contains(".jpg")) ? ".jpg" : ".png").ToString();
            LoadTenND(p);
        }
    }
}
