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

        AppContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new AppContext();
        }

        private void BT_Register(object sender, RoutedEventArgs e)
        {
            string ID = TB_ID.Text.Trim();
            string pass = TB_Password.Password.Trim();
            string pass_2 = TB_Password_2.Password.Trim();
            string email = TB_EMail.Text.Trim().Trim();

            if (ID.Length < 5)
            {
                TB_ID.ToolTip = "This field is entered incorrectly";
                TB_ID.Background = Brushes.Red;
            }
            else if (pass.Length < 5)
            {
                TB_ID.ToolTip = "This field is entered incorrectly";
                TB_ID.Background = Brushes.Red;
            }
            else if (pass != pass_2)
            {
                TB_ID.ToolTip = "This field is entered incorrectly";
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                TB_ID.ToolTip = "This field is entered incorrectly";
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

                MessageBox.Show("Passt!");

                User user = new User(ID, email, pass);

                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}
