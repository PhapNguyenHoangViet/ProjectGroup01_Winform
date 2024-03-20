using System;
using Group01_QuanLyLuanVan.View;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Group01_QuanLyLuanVan.Model;
using Group01_QuanLyLuanVan.DAO;
using System.Data;
using System.Windows.Controls;
using System.Windows;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class StudentRegisterTopicViewModel : BaseViewModel
    {
        SinhVienDAO svDAO = new SinhVienDAO();
        public ICommand back { get; set; }
        public StudentRegisterTopicViewModel()
        {
            back = new RelayCommand<StudentRegisterTopicView>((p) => true, p => _back(p));

        }

        void _back(StudentRegisterTopicView paramater)
        {
            StudentListTopicView topicsView = new StudentListTopicView();
            StudentMainViewModel.MainFrame.Content = topicsView;
        }
    }
}
