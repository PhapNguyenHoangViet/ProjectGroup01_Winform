using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Group01_QuanLyLuanVan.DAO
{
    public class DeTaiDAO
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadListTopic()
        {
            DataTable dt = new DataTable();
            string sqlStr = $"SELECT DT.deTaiId,DT.tenDeTai, TL.tenTheLoai , GV.hoTen ,  DT.moTa , DT.yeuCauChung ,  DT.ngayBatDau ,   DT.ngayKetThuc ,DT.soLuong, DT.nhomId FROM    DeTai DT JOIN    GiangVien GV ON DT.giangVienId = GV.giangVienId JOIN  TheLoai TL ON DT.theLoaiId = TL.theLoaiId WHERE   DT.trangThai = 0  AND GV.khoaId = 'K01'";
            dt = conn.Sql_Select(sqlStr);
            return dt;
        }
    }
}
