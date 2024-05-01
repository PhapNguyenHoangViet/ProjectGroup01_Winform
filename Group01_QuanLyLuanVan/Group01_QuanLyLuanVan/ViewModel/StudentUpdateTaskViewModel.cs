using Group01_QuanLyLuanVan.DAO;
using Group01_QuanLyLuanVan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Data.SqlClient;
using System.Windows.Input;
using Group01_QuanLyLuanVan.View;
using Microsoft.Win32;
using System.Data.Common;
using System.ComponentModel;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class StudentUpdateTaskViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        YeuCauDAO ycDAO = new YeuCauDAO();
        public ICommand ThemTask { get; set; }
        
        private ObservableCollection<YeuCau> _myCollection;
        public ObservableCollection<YeuCau> MyCollection
        {
            get { return _myCollection ?? (_myCollection = new ObservableCollection<YeuCau>()); }
            set { _myCollection = value; }
        }

        public StudentUpdateTaskViewModel()
        {
            
            ThemTask = new RelayCommand<StudentUpdateTaskView>((p) => true, (p) => _ThemTask(p));
            DataTable dataTable = ycDAO.LoadListYeuCau();
            foreach (DataRow row in dataTable.Rows)
            {               
                YeuCau yeucau = new YeuCau
                {
                    
                    NoiDung = row["NoiDung"].ToString()
                };
                MyCollection.Add(yeucau);
            }

        }



        void _ThemTask(StudentUpdateTaskView p)
        {
            if (string.IsNullOrWhiteSpace(p.ThemTask.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung cho task.");
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction(); // Bắt đầu giao dịch

                    try
                    {
                        string sql = "SELECT deTaiId FROM SinhVien JOIN DeTai ON SinhVien.nhomId = DeTai.nhomId WHERE sinhVienId = @sinhVienId";

                        using (SqlCommand command = new SqlCommand(sql, conn, transaction))
                        {
                            command.Parameters.AddWithValue("@sinhVienId", Const.sinhVien.SinhVienId);

                            object detaiId = command.ExecuteScalar();

                            if (detaiId != null)
                            {
                                string insertYeuCauQuery = "INSERT INTO YeuCau (noiDung, trangThai, deTaiId) VALUES (@noiDung, 0, @deTaiId)";
                                using (SqlCommand insertYeuCauCommand = new SqlCommand(insertYeuCauQuery, conn, transaction))
                                {
                                    insertYeuCauCommand.Parameters.AddWithValue("@noiDung", p.ThemTask.Text);
                                    insertYeuCauCommand.Parameters.AddWithValue("@deTaiId", detaiId);
                                    insertYeuCauCommand.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                MessageBox.Show("Thêm thành công");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

                
                DataTable dataTable = ycDAO.LoadListYeuCau();
                if (dataTable.Rows.Count > 0)
                {
                    DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];
                    

                    YeuCau yeucau = new YeuCau
                    {
                        
                        NoiDung = lastRow["NoiDung"].ToString()
                    };
                    MyCollection.Add(yeucau);
                }
                p.ThemTask.Text = "";
            }



        }


       
        public void UpdateTrangThai(string noiDung, int trangThai)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                conn.Open();
                string sql = "UPDATE YeuCau SET trangThai = @TrangThai WHERE noiDung = @NoiDung";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TrangThai", trangThai);
                    command.Parameters.AddWithValue("@NoiDung", noiDung);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công!");
                    }
                }
            }
        }



    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;

        public RelayCommand(Action<object> execute)
        {
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
