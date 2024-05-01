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
using Group01_QuanLyLuanVan.Chat.Net;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class TeacherTaskMessageViewModel : BaseViewModel
    {
        public ObservableCollection<MessageTask> Users { get; set; }
        public string Message { get; set; }

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

            Users = new ObservableCollection<MessageTask>();
            ListMessage = new ObservableCollection<MessageTask>();
            Const._server.connectedEvent += UserConnected;
            Const._server.msgReceivedEvent += MessageReceived;
            Const._server.userDisconnectEvent += UserDisconnected;

            AddMsg = new RelayCommand<TeacherTaskMessageView>((p) => true, (p) => _AddMsg(p));

        }

        private void UserDisconnected()
        {
            var uid = Const._server.PacketReader.ReadMessage();
            var user = Users.Where(x => x.UID == uid).FirstOrDefault();
            //Application.Current.Dispatcher.Invoke(() => Users.Remove(user));

        }

        private void MessageReceived()
        {
            var msg = Const._server.PacketReader.ReadMessage();
            string[] splittedStrings = msg.Split(new string[] { "iiiiii" }, StringSplitOptions.None);
            string message = splittedStrings[0].ToString();
            int yeucauId = int.Parse(splittedStrings[1].ToString());
/*            messageTaskDAO.AddMessage(message, DateTime.Now, Const.giangVien.Username, yeucauId);
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
            }*/
        }

        private void UserConnected()
        {
            var user = new MessageTask
                (Const._server.PacketReader.ReadMessage(),
                Const._server.PacketReader.ReadMessage());

/*            if (!Users.Any(x => x.UID == user.UID))
            {
                Application.Current.Dispatcher.Invoke(() => Users.Add(user));
            }*/
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
                Const._server.SendMessageToServer(Message+ "iiiiii" + Const.yeuCauId.ToString());

                messageTaskDAO.AddMessage(p.Msg.Text, DateTime.Now, Const.giangVien.Username, Const.yeuCauId);
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
                teacherTaskMessageView.TenTask.Text = Const.YeuCau.TenYeuCau;
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
