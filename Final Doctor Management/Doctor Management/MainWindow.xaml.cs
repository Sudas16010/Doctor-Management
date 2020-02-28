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
namespace Doctor_Management
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

        private void btn_admin_click(object sender, RoutedEventArgs e)
        {
            admin_panel sd = new admin_panel();
            sd.Show();
        }

        private void btn_users_click(object sender, RoutedEventArgs e)
        {
            users_panel sd = new users_panel();
            sd.Show();
        }

        private void btn_exit_click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("Do you realy want to exit?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Stop);

            switch (mr)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    break;

                case MessageBoxResult.No:
                    MessageBox.Show("Thank you for your openion.");
                    break;
            }
        }

        private void btn_home_click(object sender, RoutedEventArgs e)
        {
            MainWindow sd = new MainWindow();
            sd.Show();
        }
    }
}
