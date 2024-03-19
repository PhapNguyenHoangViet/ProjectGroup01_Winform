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
        SinhVienDAO sv = new SinhVienDAO();

        public DataTable LoadListSinhVienDangKyDeTai()
        {
            DataTable dt = new DataTable();
            string sqlStr = $"SELECT * FROM SinhVien WHERE khoaId = " + Const.sinhVien.KhoaId + " AND nhomId IS NULL";
            dt = conn.Sql_Select(sqlStr);
            return dt;
        }
        public SinhVien FindOneByUsername(string username)
        {
            string sqlStr = string.Format("(select * from SinhVien where username='{0}') ", username);
            DataTable tb = conn.Sql_Select(sqlStr);
            if (tb.Rows.Count > 0)
            {
                DataRow dr = tb.Rows[0];
                SinhVien sinhVien = new SinhVien(dr[0].ToString(), dr[1].ToString(), DateTime.Parse(dr[2].ToString()), dr[3].ToString(),dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), int.Parse(dr[9].ToString()));
                return sinhVien;
            }
            else
            {
                return null;
            }
        }
    }
}
