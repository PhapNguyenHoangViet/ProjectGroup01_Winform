﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class SinhVien
    {
        private string sinhVienId;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string email;
        private string sdt;
        private string khoaId;
        private string username;
        private string nhomId;

        public SinhVien() { }

        public SinhVien(string sinhVienId, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string email, string sdt, string khoaId, string username, string nhomId)
        {
            this.sinhVienId = sinhVienId;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.email = email;
            this.sdt = sdt;
            this.khoaId = khoaId;
            this.username = username;
            this.nhomId = nhomId;
        }

        public string SinhVienId { get => sinhVienId; set => sinhVienId = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string KhoaId { get => khoaId; set => khoaId = value; }
        public string Username { get => username; set => username = value; }
        public string NhomId { get => nhomId; set => nhomId = value; }
    }
}
