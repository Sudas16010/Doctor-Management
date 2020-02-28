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
            Search_doctor sd = new Search_doctor();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QTC2OR9;Initial Catalog=Doctor;Integrated Security=True");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from users where name='" + txt_name.Text + "' and password='" + pwb_pass.Password + "'", con);
            da.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                sd.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Don't match", "signin Status", MessageBoxButton.YesNoCancel);
                txt_name.Text = "";
                pwb_pass.Password = "";

            }
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
