using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class Khoa
    {
        private string khoaId;
        private string tenKhoa;

        public Khoa () { }

        public Khoa(string khoaId, string tenKhoa)
        {
            this.khoaId = khoaId;
            this.tenKhoa = tenKhoa;
        }

        public string KhoaId { get => khoaId; set => khoaId = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
    }
}
