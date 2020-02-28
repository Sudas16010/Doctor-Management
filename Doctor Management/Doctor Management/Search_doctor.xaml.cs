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
using System.Data;
using System.Data.SqlClient;

namespace Doctor_Management
{
    /// <summary>
    /// Interaction logic for Search_doctor.xaml
    /// </summary>
    public partial class Search_doctor : Window
    {
        public Search_doctor()
        {
            InitializeComponent();
        }

        private void btn_search_click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btn_logout_click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult mr = MessageBox.Show("Do you realy want to log out?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Stop);

            switch (mr)
            {
                case MessageBoxResult.Yes:
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                    break;

                case MessageBoxResult.No:
                    MessageBox.Show("Thank you for your openion.");
                    break;
            }
        }
    }
}
