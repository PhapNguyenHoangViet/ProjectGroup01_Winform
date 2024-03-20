using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class YeuCau
    {
        private string yeuCauId;
        private string noiDung;
        private int trangThai;
        private string deTaiId;

        public YeuCau() { }
        public YeuCau(string yeuCauId, string noiDung, int trangThai, string deTaiId)
        {
            this.yeuCauId = yeuCauId;
            this.noiDung = noiDung;
            this.trangThai = trangThai;
            this.deTaiId = deTaiId;
        }

        public string YeuCauId { get => yeuCauId; set => yeuCauId = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public int TrangThai { get => trangThai;set => trangThai = value; }
        public string DeTaiId { get => deTaiId; set => deTaiId = value; }
    }
}
