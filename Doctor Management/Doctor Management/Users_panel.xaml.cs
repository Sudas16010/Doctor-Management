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
    /// Interaction logic for users_panel.xaml
    /// </summary>
    public partial class users_panel : Window
    {
        public users_panel()
        {
            InitializeComponent();
        }

        private void btn_signin_click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_create_account_click(object sender, RoutedEventArgs e)
        {
            Create_new_account sd = new Create_new_account();
            sd.Show();
        }
    }
}
