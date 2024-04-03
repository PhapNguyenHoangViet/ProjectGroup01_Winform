using Group01_QuanLyLuanVan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.DAO
{
    public class ThongBaoDAO
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadListThongBao()
        {
            DataTable dt = new DataTable();
            string sqlStr = string.Format("SELECT thongBaoId, tieude, noiDung, ThongBao.deTaiId, ngay  FROM ThongBao INNER JOIN DeTai ON ThongBao.deTaiId = DeTai.deTaiId INNER JOIN SinhVien ON DeTai.nhomId = SinhVien.nhomId  WHERE sinhVienId = '{0}'", Const.sinhVien.SinhVienId);

            dt = conn.Sql_Select(sqlStr);
            return dt;
        }
    }
}
