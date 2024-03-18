﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group01_QuanLyLuanVan.DAO
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DataTable Sql_Select(string sqlStr)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                dataTable.Load(dataReader);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi!");
            }
            return dataTable;
        }
        public void Sql_Them_Xoa_Sua(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
