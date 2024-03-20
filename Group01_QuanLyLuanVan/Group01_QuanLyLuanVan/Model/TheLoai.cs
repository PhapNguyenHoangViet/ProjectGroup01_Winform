using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class TheLoai
    {
        private string theLoaiId;
        private string tenTheLoai;
        private string khoaId;

        public TheLoai() { }

        public TheLoai(string theLoaiId, string tenTheLoai, string khoaId)
        {
            this.theLoaiId = theLoaiId;
            this.tenTheLoai = tenTheLoai;
            this.khoaId = khoaId;
        }

        public string TheLoaiId { get => theLoaiId; set => theLoaiId = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }
        public string KhoaId { get => khoaId; set => khoaId = value; }
    }
}
