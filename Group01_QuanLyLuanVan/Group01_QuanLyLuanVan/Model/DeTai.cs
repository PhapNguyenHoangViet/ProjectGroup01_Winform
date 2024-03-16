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
        private string nhomId;
        private string giangVienId;

        public DeTai() { }

        public DeTai(string deTaiId, string tenDeTai, string moTa, string yeuCauChung, int soLuong, string trangThai, DateTime ngayBatDau, DateTime ngayKetThuc, string theLoaiId, string nhomId, string giangVienId)
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

        public string DeTaiId { get => deTaiId; set => deTaiId = value; }
        public string TenDeTai { get => tenDeTai; set => tenDeTai = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string YeuCauChung { get => yeuCauChung; set => yeuCauChung = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string TheLoaiId { get => theLoaiId; set => theLoaiId = value; }
        public string NhomId { get => nhomId; set => nhomId = value; }
        public string GiangVienId { get => giangVienId; set => giangVienId = value; }
        
    }
}
