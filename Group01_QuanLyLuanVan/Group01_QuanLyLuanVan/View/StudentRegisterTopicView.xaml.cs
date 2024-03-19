using Group01_QuanLyLuanVan.DAO;
using Group01_QuanLyLuanVan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Group01_QuanLyLuanVan.View
{
    /// <summary>
    /// Interaction logic for StudentRegisterTopicView.xaml
    /// </summary>
    public partial class StudentRegisterTopicView : Page
    {
        
        SinhVienDAO svDAO = new SinhVienDAO();
        private ObservableCollection<SinhVien> sinhViens;

        public StudentRegisterTopicView()
        {
            InitializeComponent();
            LoadSinhVienData();
        }

        private void LoadSinhVienData()
        {
            DataTable dataTable = svDAO.LoadListSinhVienDangKyDeTai(); // Đây là phần bạn phải cung cấp từ dữ liệu của bạn.
            sinhViens = new ObservableCollection<SinhVien>();

            foreach (DataRow row in dataTable.Rows)
            {
                sinhViens.Add(new SinhVien
                {
                    SinhVienId = row["sinhVienId"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    IsSelected = false
                });
            }

            multiSelectComboBox.ItemsSource = sinhViens;
        }

        private void multiSelectComboBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Space)
            {
                multiSelectComboBox.IsDropDownOpen = true;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            UpdateSelectedItemsText();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateSelectedItemsText();
        }

        private void UpdateSelectedItemsText()
        {
            selectedItemTextBlock.Text = "";
            foreach (SinhVien sinhVien in multiSelectComboBox.ItemsSource)
            {
                if (sinhVien.IsSelected)
                {
                    selectedItemTextBlock.Text += sinhVien.HoTen + ", ";
                }
            }
            selectedItemTextBlock.Text = selectedItemTextBlock.Text.TrimEnd(' ', ',');
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            int nhomId = GetNextNhomId(); // Lấy giá trị nhomId tiếp theo

           
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                conn.Open();

                // Thực hiện transaction để đảm bảo tính nhất quán giữa việc thêm dữ liệu vào bảng Nhom, cập nhật trạng thái trong bảng DeTai và thêm dữ liệu vào bảng DeTai
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Thực thi truy vấn SQL để chèn nhomId vào bảng Nhom
                    string insertNhomQuery = "INSERT INTO Nhom (nhomId) VALUES (@nhomId)";
                    SqlCommand insertNhomCommand = new SqlCommand(insertNhomQuery, conn, transaction);
                    insertNhomCommand.Parameters.AddWithValue("@nhomId", nhomId);
                    insertNhomCommand.ExecuteNonQuery();

                    // Thực thi truy vấn SQL để cập nhật trạng thái trong bảng DeTai thành 1
                    string updateDeTaiQuery = "UPDATE DeTai SET trangThai = 1, nhomId = @nhomId WHERE deTaiId = @deTaiId";
                    SqlCommand updateDeTaiCommand = new SqlCommand(updateDeTaiQuery, conn, transaction);
                    updateDeTaiCommand.Parameters.AddWithValue("@nhomId", nhomId);
                    updateDeTaiCommand.Parameters.AddWithValue("@deTaiId", deTaiId.Text); // Lấy giá trị từ TextBox deTaiId
                    updateDeTaiCommand.ExecuteNonQuery();

                    // Commit transaction
                    transaction.Commit();

                    MessageBox.Show("Đã cập nhật trạng thái và thêm nhomId vào bảng DeTai và cơ sở dữ liệu.");
                }
                catch (Exception ex)
                {
                    // Rollback transaction nếu có lỗi
                    transaction.Rollback();

                    MessageBox.Show("Lỗi khi thực hiện cập nhật trạng thái và thêm nhomId vào bảng DeTai và cơ sở dữ liệu: " + ex.Message);
                }
            }

            string sinhVienId = "";
            foreach (SinhVien sinhVien in multiSelectComboBox.ItemsSource)
            {
                if (sinhVien.IsSelected)
                {
                    sinhVienId = sinhVien.SinhVienId;

                    if (string.IsNullOrEmpty(sinhVienId))
                    {
                        MessageBox.Show("Vui lòng chọn một sinh viên.");
                        return;
                    }

                    
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                    {
                        conn.Open();

                        // Thực thi truy vấn SQL để cập nhật nhomId trong bảng SinhVien
                        string updateSinhVienQuery = "UPDATE SinhVien SET nhomId = @nhomId WHERE sinhVienId = @sinhVienId";
                        SqlCommand updateSinhVienCommand = new SqlCommand(updateSinhVienQuery, conn);
                        updateSinhVienCommand.Parameters.AddWithValue("@nhomId", nhomId);
                        updateSinhVienCommand.Parameters.AddWithValue("@sinhVienId", sinhVienId);

                        updateSinhVienQuery = "UPDATE SinhVien SET nhomId = @nhomId WHERE sinhVienId = " + Const.sinhVien.SinhVienId ;
                        updateSinhVienCommand = new SqlCommand(updateSinhVienQuery, conn);
                        updateSinhVienCommand.Parameters.AddWithValue("@nhomId", nhomId);
                        try
                        {
                            // Thực thi truy vấn cập nhật nhomId trong bảng SinhVien
                            updateSinhVienCommand.ExecuteNonQuery();

                            MessageBox.Show("Đã cập nhật nhomId cho sinh viên thành công.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi cập nhật nhomId cho sinh viên: " + ex.Message);
                        }
                    }
                }
            }
        }

        private int GetNextNhomId()
        {
            int nextNhomId = 0; // Giá trị mặc định nếu bảng Nhom chưa có dữ liệu

            
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                conn.Open();

                // Truy vấn SQL để lấy giá trị nhomId lớn nhất trong bảng Nhom
                string selectQuery = "SELECT ISNULL(MAX(nhomId), 0) FROM Nhom";
                SqlCommand command = new SqlCommand(selectQuery, conn);

                // Thực thi truy vấn và lấy giá trị nhomId lớn nhất
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    nextNhomId = Convert.ToInt32(result) + 1;
                }
            }

            return nextNhomId;
        }

    }
}
