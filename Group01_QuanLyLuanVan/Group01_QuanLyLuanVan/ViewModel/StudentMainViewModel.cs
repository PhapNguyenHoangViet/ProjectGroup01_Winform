using Group01_QuanLyLuanVan.DAO;
using Group01_QuanLyLuanVan.Model;
using Group01_QuanLyLuanVan.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class StudentMainViewModel : BaseViewModel
    {
        private string _selectedOption;
        public string SelectedOption
        {
            get { return _selectedOption; }
            set
            {
                _selectedOption = value;
                OnPropertyChanged(nameof(SelectedOption));
            }
        }
        YeuCauDAO ycDAO = new YeuCauDAO();
        ThongBaoDAO tbDAO = new ThongBaoDAO();
        DeTaiDAO dtDAO = new DeTaiDAO();
        SinhVienDAO sinhVienDAO = new SinhVienDAO();
        GiangVienDAO gvDAO = new GiangVienDAO();
            public ICommand LoadPageHomeCM { get; set; }
        public static Frame MainFrame { get; set; }
        public ICommand HomeStudentCM { get; set; }
        public ICommand StudentRegisterCM { get; set; }
        public ICommand StudentUpdateTaskCM { get; set; }
        public ICommand StudentUpdateProgressCM { get; set; }
        public ICommand SignoutCM { get; set; }
        public ICommand StudentNotiCM { get; set; }

        public ICommand StudentMailCM { get; set; }
        public ObservableCollection<DeTai> Topics { get; set; }

        public StudentMainViewModel()
        {


            // Khởi tạo command để load giao diện ban đầu
            LoadPageHomeCM = new RelayCommand<Frame>((p) => { return true; }, (p) =>
            {
                MainFrame = p;
                p.Content = new HomeView();
            });
            HomeStudentCM = new RelayCommand<Frame>((P) => { return true; }, (P) =>
            {
                MainFrame.Content = new HomeView();
            });
            StudentRegisterCM = new RelayCommand<Frame>((P) => { return true; }, (P) =>
            {
                dtDAO.LoadListTopicCoGV();
                MainFrame.Content = new StudentListTopicView();

            });
            StudentUpdateTaskCM = new RelayCommand<Frame>((P) => { return true; }, (P) =>
            {
                ycDAO.LoadListYeuCau();
                MainFrame.Content = new StudentUpdateTaskView();

            });
            StudentUpdateProgressCM = new RelayCommand<Frame>((P) => { return true; }, (P) =>
            {
                MainFrame.Content = new StudentUpdateProgressView();

            });
            StudentNotiCM = new RelayCommand<Frame>((P) => { return true; }, (P) =>
            {
                tbDAO.LoadListThongBao();
                MainFrame.Content = new StudentNotiView();

            });

            StudentMailCM = new RelayCommand<Frame>((P) => { return true; }, (P) =>
            {

                StudentMailView studentMailView = new StudentMailView();
                GiangVien gv = new GiangVien();
                if (Const.sinhVien.NhomId.ToString() != ""&& Const.sinhVien.NhomId!= -1)
                {
                    string dtTaiId = sinhVienDAO.FindDeTaiIdByNhomID(Const.sinhVien.NhomId);
                    string gvId = dtDAO.FindGiangVienIdByDeTaiId(dtTaiId);
                    gv = gvDAO.FindOneById(gvId);
                }
                if (gv != null)
                {

                    studentMailView.HoTen.Text = gv.HoTen.ToString();
                    studentMailView.EmailAddress.Text = gv.Email.ToString();
                }
                else
                {
                    studentMailView.HoTen.Text = "";
                    studentMailView.EmailAddress.Text = "";
                }
                MainFrame.Content = studentMailView;

            });
            SignoutCM = new RelayCommand<FrameworkElement>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = GetParentWindow(p);
                Window oldWindow = App.Current.MainWindow;
                LoginView loginView = new LoginView();
                App.Current.MainWindow = loginView;
                oldWindow.Close();
                loginView.Show();
            });
            FrameworkElement GetParentWindow(FrameworkElement p)
            {
                FrameworkElement parent = p;

                while (parent.Parent != null)
                {
                    parent = parent.Parent as FrameworkElement;
                }
                return parent;
            }

        }
    }
}
