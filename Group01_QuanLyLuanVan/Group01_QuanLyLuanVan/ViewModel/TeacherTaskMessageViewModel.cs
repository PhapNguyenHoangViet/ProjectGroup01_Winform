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
using System.Windows.Controls;
using System.Security.Cryptography;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class TeacherTaskMessageViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public ObservableCollection<MessageTask> Users { get; set; }
        public string Message { get; set; }
        public string Quyen { get; set; }


        MessageTaskDAO messageTaskDAO = new MessageTaskDAO();

        public ICommand AddMsg { get; set; }

        private ObservableCollection<MessageTask> _ListMessage;
        public ObservableCollection<MessageTask> ListMessage
        {
            get { return _ListMessage ?? (_ListMessage = new ObservableCollection<MessageTask>()); }
            set { _ListMessage = value; }
        }

        public ICommand back { get; set; }
        public ICommand LoadTaskMessageCommand { get; set; }


        public TeacherTaskMessageViewModel()
        {
            
            back = new RelayCommand<TeacherTaskMessageView>((p) => true, p => _back(p));

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
            LoadTaskMessageCommand = new RelayCommand<TeacherTaskMessageView>((p) => true, (p) => _LoadTaskMessageCommand(p));

        }

        void _LoadTaskMessageCommand(TeacherTaskMessageView msgView)
        {
            msgView.TenTask.Text = Const.YeuCau.NoiDung;
            msgView.ListMessageView.ItemsSource = listMsg();

        }

        private void UserDisconnected()
        {
            var uid = Const._server.PacketReader.ReadMessage();
            var user = Users.Where(x => x.UID == uid).FirstOrDefault();
            Application.Current.Dispatcher.Invoke(() => Users.Remove(user));

        }

        private void MessageReceived()
        {
            Quyen = "0";
            string msg = Const._server.PacketReader.ReadMessage().ToString();
            string[] splittedStrings = msg.Split(new string[] { "iiiiii" }, StringSplitOptions.None);
            string message = splittedStrings[0].ToString();
            int yeucauId = (int)int.Parse(splittedStrings[1].ToString());

            DataTable dataTable = messageTaskDAO.LoadListMessageTask(yeucauId);
            if (dataTable.Rows.Count > 0)
            {
                DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];
                int tinNhanId = int.Parse(lastRow["tinNhanId"].ToString());
                string tinNhan = lastRow["tinNhan"].ToString();
                DateTime thoiGian = DateTime.Parse(lastRow["thoiGian"].ToString());
                string username = lastRow["username"].ToString();
                int yeuCauId = Convert.ToInt32(lastRow["yeuCauId"]);
                Application.Current.Dispatcher.Invoke(() =>
                {
                    ListMessage.Add(new MessageTask(tinNhanId, tinNhan, thoiGian, username, yeuCauId));
                });
            }
            Application.Current.Dispatcher.Invoke(() =>
            {
                TeacherTaskMessageView teacherTaskMessageView = new TeacherTaskMessageView();
                teacherTaskMessageView.TenTask.Text = Const.YeuCau.NoiDung;
                teacherTaskMessageView.ListMessageView.ItemsSource = listMsg();
                teacherTaskMessageView.ListMessageView.Items.Refresh();
                TeacherMainViewModel.MainFrame.Content = teacherTaskMessageView;
            });

        }

        private void UserConnected()
        {
            var user = new MessageTask
                (Const._server.PacketReader.ReadMessage(),
                Const._server.PacketReader.ReadMessage());

            if (!Users.Any(x => x.UID == user.UID))
            {
                Application.Current.Dispatcher.Invoke(() => Users.Add(user));

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
                Quyen = "1";
                messageTaskDAO.AddMessage(p.Msg.Text, DateTime.Now, Const.giangVien.Username, Const.yeuCauId);
                Const._server.SendMessageToServer(Message+ "|" + Const.yeuCauId.ToString());
                p.Msg.Text = "";

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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        void _back(TeacherTaskMessageView paramater)
        {
            TeacherTaskDetailView taskView = new TeacherTaskDetailView();
            TeacherMainViewModel.MainFrame.Content = taskView;
        }
    }
}
