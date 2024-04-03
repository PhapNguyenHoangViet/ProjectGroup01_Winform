using Group01_QuanLyLuanVan.DAO;
using Group01_QuanLyLuanVan.Model;
using Group01_QuanLyLuanVan.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace Group01_QuanLyLuanVan.ViewModel
{

    public class StudentAddTopicsViewModel : BaseViewModel
    {
        public ICommand back { get; set; }

        public StudentAddTopicsViewModel()
        {
            back = new RelayCommand<StudentAddTopicsView>((p) => true, p => _back(p));
        }
        void _back(StudentAddTopicsView paramater)
        {
            StudentListTopicView topicsView = new StudentListTopicView();
            StudentMainViewModel.MainFrame.Content = topicsView;
        }

    }
}
