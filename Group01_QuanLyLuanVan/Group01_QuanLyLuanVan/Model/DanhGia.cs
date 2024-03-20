using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class DanhGia
    {
        private string danhGiaId;
        private string noiDung;
        private string deTaiId;

        public DanhGia() { }
        public DanhGia(string danhGiaId, string noiDung, string deTaiId)
        {
            this.danhGiaId = danhGiaId;
            this.noiDung = noiDung;
            this.deTaiId = deTaiId;
        }

        public string DanhGiaId { get => danhGiaId; set => danhGiaId = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string DeTaiId { get => deTaiId; set => deTaiId = value; }
    }
}
