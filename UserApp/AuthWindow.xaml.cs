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

namespace UserApp
{
    /// <summary>
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void BT_Auth_Click(object sender, RoutedEventArgs e)
        {
            string ID = TB_ID.Text.Trim();
            string pass = TB_Password.Password.Trim();

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
            else 
            {
                TB_ID.ToolTip = "";
                TB_ID.Background = Brushes.Transparent;
                TB_Password.ToolTip = "";
                TB_Password.Background = Brushes.Transparent;

                User authUser = null;
                using (AppContext db = new AppContext()) 
                {
                    authUser = db.Users.Where(b => b.Login == ID && b.Pass == pass).FirstOrDefault();
                }

                if (authUser != null)
                    MessageBox.Show("Passt!");
                else
                    MessageBox.Show("Error");
                    

            }
        }
    }
}
