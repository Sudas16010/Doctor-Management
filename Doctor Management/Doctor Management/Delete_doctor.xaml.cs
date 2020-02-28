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
    /// Interaction logic for Delete_doctor.xaml
    /// </summary>
    public partial class Delete_doctor : Window
    {
        public Delete_doctor()
        {
            InitializeComponent();
        }

        private void btn_delete_click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_close_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
