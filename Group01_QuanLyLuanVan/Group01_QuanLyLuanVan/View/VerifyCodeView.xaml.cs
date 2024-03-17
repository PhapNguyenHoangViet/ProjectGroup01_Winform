using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Group01_QuanLyLuanVan.View
{
    /// <summary>
    /// Interaction logic for VerifyCodeView.xaml
    /// </summary>
    public partial class VerifyCodeView : Window
    {
        public VerifyCodeView()
        {
            InitializeComponent();
        }
        private void OnDigitKeyUp(object sender, KeyEventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (currentTextBox.Text.Length >= 1)
            {
                MoveToNextTextBox(currentTextBox);
            }
        }

        private void MoveToNextTextBox(TextBox currentTextBox)
        {
            TraversalRequest request = new TraversalRequest(FocusNavigationDirection.Next);
            currentTextBox.MoveFocus(request);
        }

        // Chỉ cho phép nhập số vào ô TextBox
        private void PreviewTextInputHandler(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private bool IsTextAllowed(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
