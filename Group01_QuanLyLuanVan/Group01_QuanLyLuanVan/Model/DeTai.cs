using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class DeTai
    {
        private string deTaiId;
        private string tenDeTai;
        private string moTa;
        private string yeuCauChung;
        private int soLuong;
        private string trangThai;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private string theLoaiId;
        private int nhomId;
        private string giangVienId;
        private string hoTen;
        private string tenTheLoai;
        public DeTai() { }

        public DeTai(string deTaiId, string tenDeTai, string moTa, string yeuCauChung,
            int soLuong, string trangThai, DateTime ngayBatDau, DateTime ngayKetThuc, string theLoaiId,
            int nhomId, string giangVienId)
        {
            this.deTaiId = deTaiId;
            this.tenDeTai = tenDeTai;
            this.moTa = moTa;
            this.yeuCauChung = yeuCauChung;
            this.soLuong = soLuong;
            this.trangThai = trangThai;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.theLoaiId = theLoaiId;
            this.nhomId = nhomId;
            this.giangVienId = giangVienId;
        }
        public DeTai(string deTaiId, string tenDeTai, string tenTheLoai, string hoTen, string moTa, string yeuCauChung,
            DateTime ngayBatDau, DateTime ngayKetThuc, int soLuong)
        {
            this.deTaiId = deTaiId;
            this.TenDeTai = tenDeTai;
            this.hoTen = hoTen;
            this.tenTheLoai = tenTheLoai;
            this.moTa=moTa;
            this.yeuCauChung = yeuCauChung;           
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.soLuong = soLuong;

        }

        public string DeTaiId { get => deTaiId; set => deTaiId = value; }
        public string TenDeTai { get => tenDeTai; set => tenDeTai = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string YeuCauChung { get => yeuCauChung; set => yeuCauChung = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string TheLoaiId { get => theLoaiId; set => theLoaiId = value; }
        public int NhomId { get => nhomId; set => nhomId = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public string GiangVienId { get => giangVienId; set => giangVienId = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string  TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }
        
    }
}
