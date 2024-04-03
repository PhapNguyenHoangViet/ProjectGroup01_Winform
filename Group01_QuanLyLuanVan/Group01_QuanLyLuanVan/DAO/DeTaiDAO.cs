using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Group01_QuanLyLuanVan.Model;
using System.Windows;

namespace Group01_QuanLyLuanVan.DAO
{
    public class DeTaiDAO
    {
        DBConnection conn = new DBConnection();
        public DataTable LoadListTopic()
        {
            DataTable dt = new DataTable();
            string sqlStr = string.Format("SELECT DT.deTaiId,DT.tenDeTai, TL.tenTheLoai , GV.hoTen ,  DT.moTa , DT.yeuCauChung ,  DT.ngayBatDau ,   DT.ngayKetThuc ,DT.soLuong, DT.nhomId FROM    DeTai DT JOIN    GiangVien GV ON DT.giangVienId = GV.giangVienId JOIN  TheLoai TL ON DT.theLoaiId = TL.theLoaiId WHERE   DT.trangThai = 0  AND GV.khoaId =  '{0}'", Const.sinhVien.KhoaId);
            dt = conn.Sql_Select(sqlStr);
            return dt;
        }

        public DataTable LoadListTopicCoGV()
        {
            DataTable dt = new DataTable();
            string sqlStr = string.Format("SELECT DT.deTaiId,DT.tenDeTai, TL.tenTheLoai , GV.hoTen ,  DT.moTa , DT.yeuCauChung ,  DT.ngayBatDau ,   DT.ngayKetThuc ,DT.soLuong, DT.nhomId, DT.trangThai, DT.an FROM    DeTai DT JOIN    GiangVien GV ON DT.giangVienId = GV.giangVienId JOIN  TheLoai TL ON DT.theLoaiId = TL.theLoaiId WHERE  GV.khoaId =  '{0}' AND DT.trangThai != 2 AND DT.an != 1", Const.sinhVien.KhoaId);
            dt = conn.Sql_Select(sqlStr);
            return dt;
        }


        public DataTable LoadListTopic(string giaoVienId)
        {
            string sqlStr = string.Format("SELECT DT.deTaiId,DT.tenDeTai, TL.tenTheLoai,  DT.moTa , DT.yeuCauChung, DT.ngayBatDau, DT.ngayKetThuc, DT.soLuong, DT.trangThai, DT.an FROM DeTai DT JOIN  TheLoai TL ON DT.theLoaiId = TL.theLoaiId WHERE DT.giangVienId = '{0}' and DT.an != 1", giaoVienId);
            DataTable tb = conn.Sql_Select(sqlStr);
            return tb;
        }

        public int FindNhomIdByDeTaiId(string deTaiId)
        {
            string sqlStr = string.Format("select nhomId from DeTai where deTaiId = '{0}'", deTaiId);
            DataTable tb = conn.Sql_Select(sqlStr);
            if (tb.Rows.Count > 0)
            {
                DataRow dr = tb.Rows[0];
                int nhomId;
                if (dr["nhomId"].ToString() == "")
                    nhomId = -1;
                else
                    nhomId = int.Parse(dr["nhomId"].ToString());
                return nhomId;
            }
            else
            {
                return -1;
            }
        }

        public string FindGiangVienIdByDeTaiId(string deTaiId)
        {
            string sqlStr = string.Format("select giangVienId from DeTai where deTaiId = '{0}'", deTaiId);
            DataTable tb = conn.Sql_Select(sqlStr);
            if (tb.Rows.Count > 0)
            {
                DataRow dr = tb.Rows[0];
                return dr["giangVienId"].ToString();
            }
            else
            {
                return "";
            }
        }

        public List<DeTai> FindDeTaiByGVID(string giaoVienId)
        {
            List<DeTai> dsTL = new List<DeTai>();
            string sqlStr = string.Format("SELECT DT.deTaiId,DT.tenDeTai, TL.tenTheLoai,  DT.moTa , DT.yeuCauChung, DT.ngayBatDau, DT.ngayKetThuc, DT.soLuong, DT.trangThai, DT.an FROM DeTai DT JOIN  TheLoai TL ON DT.theLoaiId = TL.theLoaiId WHERE DT.giangVienId = '{0}' and DT.an != 1", giaoVienId);
            DataTable tb = conn.Sql_Select(sqlStr);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    dsTL.Add(new DeTai(tb.Rows[i]["deTaiId"].ToString(), tb.Rows[i]["tenDeTai"].ToString(), tb.Rows[i]["tenTheLoai"].ToString(), tb.Rows[i]["moTa"].ToString(), tb.Rows[i]["yeuCauChung"].ToString(), DateTime.Parse(tb.Rows[i]["ngayBatDau"].ToString()), DateTime.Parse(tb.Rows[i]["ngayKetThuc"].ToString()), int.Parse(tb.Rows[i]["soLuong"].ToString()), tb.Rows[i]["trangThai"].ToString()));
                }
                return dsTL;
            }
            else
            {
                return null;
            }
        }

        public void AddTopic(DeTai dt)
        {
            string sqlStr = string.Format("insert into DeTai (tenDeTai, moTa, yeuCauChung,soLuong, trangThai, ngayBatDau, ngayKetThuc, theLoaiId, giangVienId, an) values (N'{0}', N'{1}', N'{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", dt.TenDeTai, dt.MoTa, dt.YeuCauChung, dt.SoLuong, dt.TrangThai, dt.NgayBatDau, dt.NgayKetThuc, dt.TheLoaiId, dt.GiangVienId, 0);
            conn.Sql_Them_Xoa_Sua(sqlStr);
        }


        public void UpdateTopic(DeTai dt)
        {
            string sqlStr = string.Format("update DeTai set tenDeTai = N'{0}', moTa = N'{1}', yeuCauChung = '{2}', soLuong = '{3}' where deTaiId='{4}'",dt.TenDeTai, dt.MoTa, dt.YeuCauChung,dt.SoLuong, dt.DeTaiId);
            conn.Sql_Them_Xoa_Sua(sqlStr);
        }

        public void DeleteTopic(string deTaiId)
        {
            string sqlStr = string.Format("Delete from DeTai where deTaiId = '{0}'", deTaiId);
            conn.Sql_Them_Xoa_Sua(sqlStr);
        }

        public void AnTopic(string deTaiId)
        {
            string sqlStr = string.Format("update DeTai set an = '{0}' where deTaiId = '{1}'", 1, deTaiId);
            conn.Sql_Them_Xoa_Sua(sqlStr);
        }

        //public DeTai FindOne(string deTaiId)
        //{
        //    string sqlStr = string.Format("(select * from DeTai where deTaiId='{0}' ) ", deTaiId);
        //    DataTable tb = conn.Sql_Select(sqlStr);
        //    if (tb.Rows.Count > 0)
        //    {
        //        DataRow dr = tb.Rows[0];
        //        DeTai deTai = new DeTai(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), int.Parse(dr[4].ToString()), int.Parse(dr[5].ToString()), DateTime.Parse(dr[6].ToString()), DateTime.Parse(dr[7].ToString()), dr[8].ToString(), int.Parse(dr[8].ToString()), dr[10].ToString());
        //        return deTai;    }
        //    else
        //    {
        //        return null;
        //    }
        //}

    }
}
