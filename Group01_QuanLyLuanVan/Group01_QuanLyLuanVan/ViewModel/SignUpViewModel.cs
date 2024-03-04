using Group01_QuanLyLuanVan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group01_QuanLyLuanVan.View;


namespace Group01_QuanLyLuanVan.ViewModel
{
    public class SignUpViewModel : BaseViewModel
    {
        private string _linkaddimage;
        public string linkaddimage { get => _linkaddimage; set { _linkaddimage = value; OnPropertyChanged(); } }

        public SignUpViewModel()
        {
            linkaddimage = Const._localLink + "/Resource/Image/addava.png";
        }
    }
}
