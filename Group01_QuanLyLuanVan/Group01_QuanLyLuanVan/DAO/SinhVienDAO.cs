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
            string sqlStr = $"SELECT * FROM SinhVien WHERE Khoaid = 'K01' AND nhomId IS NULL";
            dt = conn.Sql_Select(sqlStr);
            return dt;
        }
    }
}
