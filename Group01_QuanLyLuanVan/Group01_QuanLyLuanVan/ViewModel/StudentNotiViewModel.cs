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
using System.Windows.Input;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class StudentNotiViewModel : BaseViewModel
    {
        ThongBaoDAO tbDAO = new ThongBaoDAO();
        private ObservableCollection<ThongBao> _ListThongBao;
        public ObservableCollection<ThongBao> ListThongBao { get => _ListThongBao; set { _ListThongBao = value;/* OnPropertyChanged();*/ } }
        public ICommand DetailThongBaoCommand { get; set; }
        public ObservableCollection<ThongBao> ThongBaos { get; set; }
        public ICommand LoadThongBaosCommand { get; set; }

        private string _selectedThongBaoNoiDung;
        public string SelectedThongBaoNoiDung
        {
            get { return _selectedThongBaoNoiDung; }
            set
            {
                _selectedThongBaoNoiDung = value;
                OnPropertyChanged(nameof(SelectedThongBaoNoiDung));
            }
        }

        public StudentNotiViewModel()
        {
            ThongBaos = new ObservableCollection<ThongBao>();
            var thongBaosData = tbDAO.LoadListThongBao();

            foreach (DataRow row in thongBaosData.Rows)
            {
                int thongBaoId = Convert.ToInt32(row["thongBaoId"]);
                string tieuDe = row["tieuDe"].ToString();
                string noiDung = row["noiDung"].ToString();
                string deTaiId = row["deTaiId"].ToString();
                DateTime ngay = Convert.ToDateTime(row["ngay"]);

                ThongBaos.Add(new ThongBao(thongBaoId, tieuDe, noiDung, deTaiId, ngay));
            }
            ListThongBao = ThongBaos;
            LoadThongBaosCommand = new RelayCommand<StudentNotiView>((p) => true, (p) => _LoadThongBaosCommand(p));
            DetailThongBaoCommand = new RelayCommand<StudentNotiView>((p) => { return p.ListThongBaoView.SelectedItem == null ? false : true; }, (p) => _DetailThongBaoCommand(p));
        }
        void _LoadThongBaosCommand(StudentNotiView notiView)
        {
            notiView.ListThongBaoView.ItemsSource = listThongBao();
        }
        ObservableCollection<ThongBao> listThongBao()
        {
            ThongBaos = new ObservableCollection<ThongBao>();
            var thongBaosData = tbDAO.LoadListThongBao();
            foreach (DataRow row in thongBaosData.Rows)
            {
                int thongBaoId = Convert.ToInt32(row["thongBaoId"]);
                string tieuDe = row["tieuDe"].ToString();
                string noiDung = row["noiDung"].ToString();
                string deTaiId = row["deTaiId"].ToString();
                DateTime ngay = Convert.ToDateTime(row["ngay"]);

                ThongBaos.Add(new ThongBao(thongBaoId, tieuDe, noiDung, deTaiId, ngay));
            }
            return ThongBaos;
        }
        void _DetailThongBaoCommand(StudentNotiView tbView)
        {
            if (tbView != null && tbView.ListThongBaoView.SelectedItem != null)
            {
                var selectedThongBao = (ThongBao)tbView.ListThongBaoView.SelectedItem;
                SelectedThongBaoNoiDung = selectedThongBao.NoiDung;
            }
        }
    }
}
