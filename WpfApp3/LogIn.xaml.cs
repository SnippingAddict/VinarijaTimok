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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();

        }

        Login login = new Login("admin", "1234");

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //define local variables from the user inputs 
            string user = UserU.Text;
            string pass = PasswordU.Password;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                PocetniProzor test = new PocetniProzor();
                test.Show();
                this.Close();
            }
            else
            {
                NeuspesanLogin login = new NeuspesanLogin();
                login.ShowDialog();
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
