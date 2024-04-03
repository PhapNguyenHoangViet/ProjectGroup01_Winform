﻿using Group01_QuanLyLuanVan.DAO;
using Group01_QuanLyLuanVan.Model;
using Group01_QuanLyLuanVan.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class StudentListTopicViewModel : BaseViewModel
    {
        DeTaiDAO dtDAO = new DeTaiDAO();
        private ObservableCollection<DeTai> _ListTopic;
        public ObservableCollection<DeTai> ListTopic { get => _ListTopic; set { _ListTopic = value;/* OnPropertyChanged();*/ } }
        private ObservableCollection<string> _ListTK;
        public ObservableCollection<string> ListTK { get => _ListTK; set { _ListTK = value; OnPropertyChanged(); } }
        public ICommand SearchTopicsCommand { get; set; }
        public ICommand DetailTopicsCommand { get; set; }
        public ObservableCollection<DeTai> Topics { get; set; }
        public ICommand LoadTopicsCommand { get; set; }
        public ICommand AddTopicsCommand { get; set; }
        public StudentListTopicViewModel()
        {
            Topics = new ObservableCollection<DeTai>();
            var topicsData = dtDAO.LoadListTopicCoGV();
            foreach (DataRow row in topicsData.Rows)
            {
                string deTaiId = row["deTaiId"].ToString();
                string tenDeTai = row["tenDeTai"].ToString();
                string tenTheLoai = row["tenTheLoai"].ToString();
                string hoTen = row["hoTen"].ToString();
                string moTa = row["moTa"].ToString();
                string yeuCauChung = row["yeuCauChung"].ToString();
                DateTime ngayBatDau = Convert.ToDateTime(row["ngayBatDau"]);
                DateTime ngayKetThuc;
                try
                {
                    ngayKetThuc = Convert.ToDateTime(row["ngayKetThuc"]);
                }
                catch
                {
                    ngayKetThuc = Convert.ToDateTime(row["ngayBatDau"]);
                }
                int soLuong = Convert.ToInt32(row["soLuong"]);
                int trangThai = Convert.ToInt32(row["trangThai"]);
                int an = Convert.ToInt32(row["an"]);
                string tenTrangThai = "";

                if (trangThai == 1)
                {
                    tenTrangThai = "Đã đăng ký";
                }
                else
                {
                    tenTrangThai = "Chưa đăng ký";
                }
                if (an != 1)
                    Topics.Add(new DeTai(deTaiId, tenDeTai, tenTheLoai, hoTen, moTa, yeuCauChung, ngayBatDau, ngayKetThuc, soLuong, tenTrangThai));
            }
            MessageBox.Show("Đã xóa đề tài này !", "THÔNG BÁO", MessageBoxButton.OK, MessageBoxImage.Error);
            ListTopic = Topics;
            ListTK = new ObservableCollection<string>() { "Đề tài", "Thể loại", "Giảng viên" };
            DetailTopicsCommand = new RelayCommand<StudentListTopicView>((p) => { return p.ListTopicView.SelectedItem == null ? false : true; }, (p) => _DetailTopicsCommand(p));
            SearchTopicsCommand = new RelayCommand<StudentListTopicView>((p) => { return p == null ? false : true; }, (p) => _SearchTopicsCommand(p));
            LoadTopicsCommand = new RelayCommand<StudentListTopicView>((p) => true, (p) => _LoadTopicsCommand(p));
            AddTopicsCommand = new RelayCommand<StudentListTopicView>((p) => true, (p) => _AddTopicsCommand(p));
        }
        void _AddTopicsCommand(StudentListTopicView topicsView)
        {
            StudentAddTopicsView addTopicsView = new StudentAddTopicsView();
            StudentMainViewModel.MainFrame.Content = addTopicsView;
        }
        void _LoadTopicsCommand(StudentListTopicView topicsView)
        {
            topicsView.cbxChon.SelectedIndex = 0;
        }
        void _DetailTopicsCommand(StudentListTopicView topicsView)
        {
            StudentRegisterTopicView detailTopic = new StudentRegisterTopicView();
            DeTai temp = (DeTai)topicsView.ListTopicView.SelectedItem;
            detailTopic.deTaiId.Text = temp.DeTaiId;
            detailTopic.TenDeTai.Text = temp.TenDeTai;
            detailTopic.TenTheLoai.Text = temp.TenTheLoai;
            detailTopic.HoTen.Text = temp.HoTen;
            detailTopic.MoTa.Text = temp.MoTa;
            detailTopic.YeuCau.Text = temp.YeuCauChung;
            detailTopic.NgayBatDau.Text = temp.NgayBatDau.ToString();
            if (temp.NgayBatDau.ToString() == temp.NgayKetThuc.ToString())
                detailTopic.NgayKetThuc.Text = "";
            else
                detailTopic.NgayKetThuc.Text = temp.NgayKetThuc.ToString();
            detailTopic.SoLuong.Text = temp.SoLuong.ToString();
            detailTopic.TenTrangThai.Text = temp.TenTrangThai.ToString();

            ListTopic = Topics;
            topicsView.ListTopicView.ItemsSource = ListTopic;
            topicsView.ListTopicView.SelectedItem = null;
            StudentMainViewModel.MainFrame.Content = detailTopic;
        }

        void _SearchTopicsCommand(StudentListTopicView topicsView)
        {
            ObservableCollection<DeTai> temp = new ObservableCollection<DeTai>();
            if (topicsView.cbxChon.Text != "")
            {
                switch (topicsView.cbxChon.SelectedItem.ToString())
                {
                    case "Đề tài":
                        {
                            foreach (DeTai s in ListTopic)
                            {
                                if (s.TenDeTai.ToLower().Contains(topicsView.txbSearch.Text.ToLower()))
                                {
                                    temp.Add(s);
                                }
                            }
                            break;
                        }
                    case "Thể loại":
                        {
                            foreach (DeTai s in ListTopic)
                            {
                                if (s.TenTheLoai.ToLower().Contains(topicsView.txbSearch.Text.ToLower()))
                                {
                                    temp.Add(s);
                                }
                            }
                            break;
                        }
                    default:
                        {
                            foreach (DeTai s in ListTopic)
                            {
                                if (s.HoTen.ToLower().Contains(topicsView.txbSearch.Text.ToLower()))
                                {
                                    temp.Add(s);
                                }
                            }
                            break;
                        }
                }
                topicsView.ListTopicView.ItemsSource = temp;
            }
            else
                topicsView.ListTopicView.ItemsSource = ListTopic;
        }

    }
}