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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BT_Register(object sender, RoutedEventArgs e)
        {
            string id = TB_ID.Text.Trim();
            string password = TB_Password.Password.Trim();
            string password_2 = TB_Password_2.Password.Trim();
            string email = TB_EMail.Text.Trim().Trim();

            if (id.Length < 5)
            {
                TB_ID.ToolTip = "Hey du noch was schreib mal da";
                TB_ID.Background = Brushes.Red;
            }
            else if (password.Length < 5)
            {
                TB_ID.ToolTip = "Hey du noch was schreib mal da";
                TB_ID.Background = Brushes.Red;
            }
            else if (password != password_2)
            {
                TB_ID.ToolTip = "Hey du noch was schreib mal da";
                TB_ID.Background = Brushes.Red;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                TB_ID.ToolTip = "Hey du noch was schreib mal da";
                TB_ID.Background = Brushes.Red;
            }
            else 
            {
                TB_ID.ToolTip = "";
                TB_ID.Background = Brushes.Transparent;
                TB_Password.ToolTip = "";
                TB_Password.Background = Brushes.Transparent;
                TB_Password_2.ToolTip = "";
                TB_Password_2.Background = Brushes.Transparent;
                TB_EMail.ToolTip = "";
                TB_EMail.Background = Brushes.Transparent;

                MessageBox.Show("Ok!");
            }
        }
    }
}
