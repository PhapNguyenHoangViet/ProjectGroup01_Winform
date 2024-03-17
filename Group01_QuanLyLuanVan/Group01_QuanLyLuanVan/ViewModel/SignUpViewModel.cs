﻿using Group01_QuanLyLuanVan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group01_QuanLyLuanVan.View;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Group01_QuanLyLuanVan.DAO;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class SignUpViewModel : BaseViewModel
    {
        TaiKhoanDAO tkDAO = new TaiKhoanDAO();

        private string _linkaddimage;
        public string linkaddimage { get => _linkaddimage; set { _linkaddimage = value; OnPropertyChanged(); } }

        public ICommand Register { get; set; }
        public ICommand AddImage { get; set; }

        private string password;
        public string Password { get => password; set { password = value; OnPropertyChanged(); } }
        public ICommand PasswordChangedCommand { get; set; }



        public SignUpViewModel()
        {
            linkaddimage = Const._localLink + "/Resource/Image/addava.png";
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => true, (p) => { Password = p.Password; });
            AddImage = new RelayCommand<ImageBrush>((p) => true, (p) => _AddImage(p));
            Register = new RelayCommand<SignUpView>((p) => true, (p) => _Register(p));
        }

        void _AddImage(ImageBrush img)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png)|*.jpg; *.png";

            if (open.ShowDialog() == true)
            {
                if (open.FileName != "")
                    linkaddimage = open.FileName;
            };
            Uri fileUri = new Uri(linkaddimage);
            img.ImageSource = new BitmapImage(fileUri);
        }

        void _Register(SignUpView parameter)
        {
            if (parameter.username.Text == "" || password == "" || parameter.sinhVienId.Text == "" || parameter.tenKhoa.Text == "" || parameter.ngaySinh.SelectedDate == null || parameter.hoTen.Text == "" || parameter.gioiTinh.Text == "" || parameter.sdt.Text == "" || parameter.mail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "THÔNG BÁO", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (tkDAO.FindOneByUsername(parameter.username.Text) != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại !", "THÔNG BÁO", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (tkDAO.FindOneByUsername(parameter.username.Text) != null)
            {
                MessageBox.Show("Email này đã được sử dụng !", "THÔNG BÁO", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            string match = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
            Regex reg = new Regex(match);
            if (!reg.IsMatch(parameter.mail.Text))
            {
                MessageBox.Show("Email không hợp lệ !", "THÔNG BÁO", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string match1 = @"^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$";
            Regex reg1 = new Regex(match1);
            if (!reg1.IsMatch(parameter.sdt.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ !", "THÔNG BÁO", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBoxResult h = System.Windows.MessageBox.Show("Bạn muốn đăng ký tài khoản ?", "THÔNG BÁO", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (h == MessageBoxResult.Yes)
            {
                TaiKhoan tk = new TaiKhoan();
                tk.Username = parameter.username.Text;
                tk.Password = password;
                tk.Mail = parameter.mail.Text;
                tk.Quyen = 1;
                tk.TrangThai = 0;
                Random rand = new Random();
                tk.Code = rand.Next(100000, 999999).ToString();
                SinhVien sv = new SinhVien();
                sv.SinhVienId = "SV0" + parameter.sinhVienId.Text;
                sv.KhoaId = "K0" + (parameter.tenKhoa.SelectedIndex).ToString();
                sv.HoTen = parameter.hoTen.Text;
                sv.SDT = parameter.sdt.Text;
                sv.GioiTinh = parameter.gioiTinh.Text;
                sv.SDT = parameter.sdt.Text;
                if (linkaddimage == "/Resource/Image/addava.png")
                    tk.Avatar = "/Resource/Image/addava.png";
                else
                    tk.Avatar = "/Resource/Ava/" + sv.SinhVienId + ((linkaddimage.Contains(".jpg")) ? ".jpg" : ".png").ToString();
                Const.taiKhoan = tk;
                SendCode(tk.Mail, tk.Code);

                tkDAO.Register(tk);
                try
                {
                    File.Copy(linkaddimage, Const._localLink + @"/Resource/Ava/" +sv.SinhVienId + ((linkaddimage.Contains(".jpg")) ? ".jpg" : ".png").ToString(), true);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                //MessageBox.Show("Chúc mừng bạn đã đăng ký thành công !", "THÔNG BÁO", MessageBoxButton.OK);
                //parameter.username.Clear();
                //parameter.password.Clear();
                //parameter.mail.Clear();
                //parameter.tenKhoa.SelectedItem = null;
                //parameter.gioiTinh.SelectedItem = null;
                //parameter.ngaySinh.SelectedDate = null;
                //parameter.sinhVienId.Clear();
                //parameter.hoTen.Clear();
                //parameter.sdt.Clear();
                //linkaddimage = "/Resource/Image/addava.png";
                //parameter.ProfilePicture.ImageSource = new BitmapImage(new Uri(Const._localLink + linkaddimage));
            }


        }
        void SendCode(string mail, string code)
        {
            
            string nd = "Vui lòng nhập code: " + code + " để đăng ký tài khoản. Trân trọng !";
            MailMessage message = new MailMessage("21110587@student.hcmute.edu.vn", mail, "Xác nhận đăng ký", nd);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("21110587@student.hcmute.edu.vn", "ngahungA@963");
            smtpClient.Send(message);
        }
    }
}
