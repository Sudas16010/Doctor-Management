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
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : Window
    {
        public MenuBar()
        {
            InitializeComponent();
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

        private void btn_add_doctor_click(object sender, RoutedEventArgs e)
        {
            Add_Doctor sd = new Add_Doctor();
            sd.Show();
        }

        private void btn_update_click(object sender, RoutedEventArgs e)
        {
            Update_doctor sd = new Update_doctor();
            sd.Show();
        }

        private void btn_delete_click(object sender, RoutedEventArgs e)
        {
            Delete_doctor sd = new Delete_doctor();
            sd.Show();
        }

        private void btn_user_delete_click(object sender, RoutedEventArgs e)
        {
            User_delete sd = new User_delete();
            sd.Show();
        }

        private void btn_total_users_click(object sender, RoutedEventArgs e)
        {
            Total_User_id sd = new Total_User_id();
            sd.Show();
        }
    }
}
