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

namespace Doctor_Management
{
    /// <summary>
    /// Interaction logic for admin_panel.xaml
    /// </summary>
    public partial class admin_panel : Window
    {
        int attempt = 3;
        public admin_panel()
        {
            InitializeComponent();
        }

        private void btn_login_click(object sender, RoutedEventArgs e)
        {
            string M = txt_id.Text;
            string N = pwb_pass.Password;
            if (M == "sudas" && N == "0000")
            {
                MenuBar mm = new MenuBar();
                mm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User id or password. Try Again...");
                txt_id.Text = "";
                pwb_pass.Password = "";
                attempt--;
                if (attempt == 0)
                {
                    MessageBox.Show("It seems something wrong. System closed.");
                    System.Environment.Exit(0);
                }
            }
        }

        private void btn_exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
