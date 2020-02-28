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
    /// Interaction logic for Add_Doctor.xaml
    /// </summary>
    public partial class Add_Doctor : Window
    {
        public Add_Doctor()
        {
            InitializeComponent();
        }

        private void btn_add_click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_close_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_home_click(object sender, RoutedEventArgs e)
        {
            MainWindow sd = new MainWindow();
            sd.Show();
        }
    }
}
