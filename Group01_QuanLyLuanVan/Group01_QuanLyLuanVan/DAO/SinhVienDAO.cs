using Group01_QuanLyLuanVan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.DAO
{
    public class SinhVienDAO
    {
        DBConnection conn = new DBConnection();

        public DataTable LoadListSinhVienDangKyDeTai()
        {
            DataTable dt = new DataTable();
            string sqlStr = $"SELECT * FROM SinhVien WHERE khoaId = " + Const.sinhVien.KhoaId + " AND nhomId IS NULL";
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
                if (dr["nhomId"] == null)
                {
                    SinhVien sinhVien = new SinhVien(dr["sinhVienId"].ToString(), dr["hoTen"].ToString(), DateTime.Parse(dr["ngaySinh"].ToString()), dr["gioiTinh"].ToString(),
                    dr["diaChi"].ToString(), dr["email"].ToString(), dr["sdt"].ToString(), dr["khoaId"].ToString(), dr["username"].ToString(), int.Parse(dr["nhomId"].ToString()));
                    return sinhVien;
                }
                else
                {
                    SinhVien sinhVien = new SinhVien(dr["sinhVienId"].ToString(), dr["hoTen"].ToString(), DateTime.Parse(dr["ngaySinh"].ToString()), dr["gioiTinh"].ToString(),
                    dr["diaChi"].ToString(), dr["email"].ToString(), dr["sdt"].ToString(), dr["khoaId"].ToString(), dr["username"].ToString());
                    return sinhVien;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
