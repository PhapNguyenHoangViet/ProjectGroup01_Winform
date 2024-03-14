using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.Model
{
    public class TaiKhoan
    {
        private string username;
        private string password;
        private string mail;
        private string quyen;
        private string code;
        private int trangThai;
        
        public TaiKhoan() { }

        public TaiKhoan(string username, string password, string mail, string quyen, string code, int trangThai)
        {
            this.username = username;
            this.password = password;
            this.mail = mail;
            this.quyen = quyen;
            this.code = code;
            this.trangThai = trangThai;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public string Code { get => code; set => code = value; }
        public int  TrangThai { get => trangThai; set => trangThai = value; }
    }
}
