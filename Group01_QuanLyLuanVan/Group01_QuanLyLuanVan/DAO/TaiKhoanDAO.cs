using Group01_QuanLyLuanVan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01_QuanLyLuanVan.DAO
{
    public class TaiKhoanDAO
    {
        DBConnection dbcon = new DBConnection();
        public DataTable KiemTraThongTinTaiKhoan(string username, string passowrd)
        {
            string sqlStr = string.Format("(select * from TaiKhoan where username='{0}' and passowrd='{1}' ) ", username, passowrd);
            return dbcon.Sql_Select(sqlStr);
        }

        public TaiKhoan FindOne(string username, string passowrd)
        {
            string sqlStr = string.Format("(select * from TaiKhoan where username='{0}' and passowrd='{1}' ) ", username, passowrd);
            DataTable tb = dbcon.Sql_Select(sqlStr);
            if (tb.Rows.Count > 0)
            {
                DataRow dr = tb.Rows[0];
                TaiKhoan taiKhoan =  new TaiKhoan(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), dr[5].ToString());
                return taiKhoan;
            }
            else
            {
                return null;
            }
        }

        public List<TaiKhoan> FindAll()
        {
            List<TaiKhoan> dsTK = new List<TaiKhoan>();
            string sqlStr = string.Format("(select * from TaiKhoan) ");
            DataTable tb = dbcon.Sql_Select(sqlStr);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    dsTK.Add(new TaiKhoan(tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString(), tb.Rows[i][2].ToString(), tb.Rows[i][3].ToString(), int.Parse(tb.Rows[i][4].ToString()), tb.Rows[i][5].ToString()));
                }
                return dsTK;
            }
            else
            {
                return null;
            }
        }

        public void DoiMatKhau(string TK, string MatKhauMoi)
        {
            string sqlStr = string.Format("update TaiKhoan set MatKhau='{0}' where TK='{1}'", MatKhauMoi, TK);
            dbcon.Sql_Them_Xoa_Sua(sqlStr);
        }
    }
}
