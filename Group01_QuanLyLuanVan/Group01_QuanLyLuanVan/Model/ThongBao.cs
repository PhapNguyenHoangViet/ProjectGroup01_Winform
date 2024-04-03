using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class ThongBao
    {
        private int thongBaoId;
        private string tieuDe;
        private string noiDung;
        private string deTaiId;
        private DateTime ngay;

        public ThongBao() { }

        public ThongBao(int thongBaoId, string tieuDe, string noiDung, string deTaiId, DateTime ngay)
        {
            this.thongBaoId = thongBaoId;
            this.tieuDe = tieuDe;
            this.noiDung = noiDung;
            this.deTaiId = deTaiId;
            this.ngay = ngay;
        }

        public ThongBao( string tieuDe, string noiDung, string deTaiId, DateTime ngay)
        {
            this.tieuDe = tieuDe;
            this.noiDung = noiDung;
            this.deTaiId = deTaiId;
            this.ngay = ngay;
        }
        public int ThongBaoId { get => thongBaoId; set => thongBaoId = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string DeTaiId { get => deTaiId; set => deTaiId = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
    }
}