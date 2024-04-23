using Group01_QuanLyLuanVan.DAO;
using Group01_QuanLyLuanVan.Model;
using Group01_QuanLyLuanVan.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class TeacherTaskMessageViewModel:BaseViewModel
    {
        MessageTaskDAO messageTaskDAO = new MessageTaskDAO();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand AddMsg { get; set; }

        private ObservableCollection<MessageTask> _ListMessage;
        public ObservableCollection<MessageTask> ListMessage
        {
            get { return _ListMessage ?? (_ListMessage = new ObservableCollection<MessageTask>()); }
            set { _ListMessage = value; }
        }

        public TeacherTaskMessageViewModel()
        {
            AddMsg = new RelayCommand<TeacherTaskMessageView>((p) => true, (p) => _AddMsg(p));
            var msgsdata = messageTaskDAO.LoadListMessageTask(Const.yeuCauId);
            foreach (DataRow row in msgsdata.Rows)
            {
                int tinNhanId = int.Parse(row["tinNhanId"].ToString());
                string tinNhan = row["tinNhan"].ToString();
                DateTime thoiGian = DateTime.Parse(row["thoiGian"].ToString());
                string username = row["username"].ToString();
                int yeuCauId = Convert.ToInt32(row["yeuCauId"]);
                ListMessage.Add(new MessageTask(tinNhanId, tinNhan, thoiGian, username, yeuCauId));
            }
        }
        void _AddMsg(TeacherTaskMessageView p)
        {
            if (p.Msg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung.");
                return;
            }
            else
            {
                messageTaskDAO.AddMessage(p.Msg.Text, DateTime.Now, Const.giangVien.Username,Const.yeuCauId);
                DataTable dataTable = messageTaskDAO.LoadListMessageTask(Const.yeuCauId);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];
                    int tinNhanId = int.Parse(lastRow["tinNhanId"].ToString());
                    string tinNhan = lastRow["tinNhan"].ToString();
                    DateTime thoiGian = DateTime.Parse(lastRow["thoiGian"].ToString());
                    string username = lastRow["username"].ToString();
                    int yeuCauId = Convert.ToInt32(lastRow["yeuCauId"]);
                    ListMessage.Add(new MessageTask(tinNhanId, tinNhan, thoiGian, username, yeuCauId));
                }
                p.Msg.Text = "";

                TeacherTaskMessageView teacherTaskMessageView = new TeacherTaskMessageView();
                teacherTaskMessageView.ListMessageView.ItemsSource = listMsg();
                teacherTaskMessageView.ListMessageView.Items.Refresh();
                TeacherMainViewModel.MainFrame.Content = teacherTaskMessageView;
            }

        }
        ObservableCollection<MessageTask> listMsg()
        {
            ListMessage = new ObservableCollection<MessageTask>();
            DataTable messages = messageTaskDAO.LoadListMessageTask(Const.yeuCauId);
            foreach (DataRow row in messages.Rows)
            {
                int tinNhanId = int.Parse(row["tinNhanId"].ToString());
                string tinNhan = row["tinNhan"].ToString();
                DateTime thoiGian = DateTime.Parse(row["thoiGian"].ToString());
                string username = row["username"].ToString();
                int yeuCauId = Convert.ToInt32(row["yeuCauId"]);
                ListMessage.Add(new MessageTask(tinNhanId, tinNhan, thoiGian, username, yeuCauId));
            }
            return ListMessage;
        }
    }
}
