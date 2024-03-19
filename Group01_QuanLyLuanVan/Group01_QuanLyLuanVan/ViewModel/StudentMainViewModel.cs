using Group01_QuanLyLuanVan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class StudentMainViewModel: BaseViewModel
    {
        public ICommand LoadPageHomeCM { get; set; }
        public static Frame MainFrame { get; set; }
        public ICommand HomeStudentCM { get; set; }
        public ICommand StudentRegisterCM { get; set; }

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
                MainFrame.Content = new StudentListTopicView();
            });

        }
    }
}
