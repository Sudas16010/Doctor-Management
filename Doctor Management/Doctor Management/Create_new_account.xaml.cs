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
    /// Interaction logic for Create_new_account.xaml
    /// </summary>
    public partial class Create_new_account : Window
    {
        public Create_new_account()
        {
            InitializeComponent();
        }

        private void btn_submit_click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
