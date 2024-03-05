using Group01_QuanLyLuanVan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private string username;
        public string Username { get => username; set { username = value; OnPropertyChanged(); } }

        private string password;
        public string Password { get => password; set { password = value; OnPropertyChanged(); } }

        public static Frame MainFrame { get; set; }

        public Button LoginButton { get; set; }

        public ICommand LoginCM { get; set; }

        public ICommand LoadLoginPageCM { get; set; }

        public ICommand ForgetPasswordCM { get; set; }

        public ICommand Login { get; set; }

        public ICommand PasswordChangedCommand { get; set; }
        public LoginViewModel()
        {
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });

            LoadLoginPageCM = new RelayCommand<Frame>((p) => { return true; }, (p) =>
            {
                MainFrame = p;
                p.Content = new LoginPageView();
            });

            ForgetPasswordCM = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MainFrame.Content = new ForgetPasswordView();
            });

        }
    }
}
