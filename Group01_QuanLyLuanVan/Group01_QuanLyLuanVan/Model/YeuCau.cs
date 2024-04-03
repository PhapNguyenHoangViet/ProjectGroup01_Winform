using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class YeuCau
    {
        private int yeuCauId;
        private string tenYeuCau;
        private string noiDung;
        private int trangThai;
        private string deTaiId;

        public YeuCau() { }
        public YeuCau(int yeuCauId, string noiDung, int trangThai, string deTaiId)
        {
            this.yeuCauId = yeuCauId;
            this.noiDung = noiDung;
            this.trangThai = trangThai;
            this.deTaiId = deTaiId;
        }

        public YeuCau(string noiDung, int trangThai, string deTaiId)
        {
            this.noiDung = noiDung;
            this.trangThai = trangThai;
            this.deTaiId = deTaiId;
        }

        public int YeuCauId { get => yeuCauId; set => yeuCauId = value; }
        public string TenYeuCau { get => tenYeuCau; set => tenYeuCau = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public int TrangThai { get => trangThai;set => trangThai = value; }
        public string DeTaiId { get => deTaiId; set => deTaiId = value; }
        public bool IsSelected { get; set; }
    }
}
