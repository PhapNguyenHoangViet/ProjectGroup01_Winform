using Group01_QuanLyLuanVan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group01_QuanLyLuanVan.DAO
{
    public class SinhVienDAO
    {
        DBConnection conn = new DBConnection();

        public DataTable LoadListSinhVienDangKyDeTai()
        {
            DataTable dt = new DataTable();
            String sqlStr = string.Format("SELECT * FROM SinhVien WHERE khoaId = '{0}' AND nhomId IS NULL AND username != '{1}'", Const.sinhVien.KhoaId, Const.taiKhoan.Username);
            dt = conn.Sql_Select(sqlStr);
            return dt;
        }
        public SinhVien FindOneByUsername(string username)
        {
            string sqlStr = string.Format("select * from SinhVien where username = '{0}'", username);
            DataTable tb = conn.Sql_Select(sqlStr);
            if (tb.Rows.Count > 0)
            {
                DataRow dr = tb.Rows[0];
                int nhomId;
                if (dr["nhomId"].ToString() == "")
                    nhomId = -1;
                else
                    nhomId = int.Parse(dr["nhomId"].ToString());

                SinhVien sinhVien = new SinhVien(dr["sinhVienId"].ToString(), dr["hoTen"].ToString(), DateTime.Parse(dr["ngaySinh"].ToString()), dr["gioiTinh"].ToString(),
                dr["diaChi"].ToString(), dr["email"].ToString(), dr["sdt"].ToString(), dr["khoaId"].ToString(), dr["username"].ToString(), nhomId);
                return sinhVien;
            }
            else
            {
                return null;
            }
        }

        public void Register(SinhVien model)
        {
            string sqlStr = string.Format("Insert into SinhVien(id, hoTen, ngaySinh, gioiTinh, email, SDT, khoaId, username) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", model.Id, model.HoTen, model.NgaySinh, model.GioiTinh, model.Email, model.SDT, model.KhoaId, model.Username);
            conn.Sql_Them_Xoa_Sua(sqlStr);
        }
    }
}
