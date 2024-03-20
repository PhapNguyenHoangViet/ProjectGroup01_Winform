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
        private int quyen;
        private int trangThai;
        private string code;
        private string avatar;

        public TaiKhoan() { }

        public TaiKhoan(string username, string mail, string code)
        {
            this.username = username;
            this.mail = mail;
            this.code = code;
        }

        public TaiKhoan(string username, string password, string mail, int quyen, int trangThai, string code, string avatar)
        {
            this.username = username;
            this.password = password;
            this.mail = mail;
            this.quyen = quyen;
            this.trangThai = trangThai;
            this.code = code;
            this.avatar = avatar;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Quyen { get => quyen; set => quyen = value; }
        public string Code { get => code; set => code = value; }
        public int  TrangThai { get => trangThai; set => trangThai = value; }
        public string Avatar { get => avatar; set => avatar = value; }

    }
}
