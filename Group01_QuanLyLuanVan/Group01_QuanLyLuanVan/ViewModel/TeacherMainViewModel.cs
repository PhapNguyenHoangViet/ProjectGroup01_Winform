using Group01_QuanLyLuanVan.Model;
using Group01_QuanLyLuanVan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace Group01_QuanLyLuanVan.ViewModel
{
    public class TeacherMainViewModel : BaseViewModel
    {
        public ICommand Loadwd { get; set; }
        public static Frame MainFrame { get; set; }

        public ICommand LoadPageCM { get; set; }

        public ICommand SignoutCM { get; set; }
        public ICommand HomeCM { get; set; }

        public TeacherMainViewModel()
        {

            SignoutCM = new RelayCommand<FrameworkElement>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = GetParentWindow(p);
                var w = window as Window;
                if (w != null)
                {
                    w.Hide();
                    LoginView w1 = new LoginView();
                    w1.ShowDialog();
                    w.Close();
                }
            });

            FrameworkElement GetParentWindow(FrameworkElement p)
            {
                FrameworkElement parent = p;

                while (parent.Parent != null)
                {
                    parent = parent.Parent as FrameworkElement;
                }
                return parent;
            }
        }
    }
}
