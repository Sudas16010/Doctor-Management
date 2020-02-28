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
            string name = txt_name.Text;
            string password = pwb_pass.Password;

            string connectionString = @"Data Source=DESKTOP-QTC2OR9;Initial Catalog=Doctor;Integrated Security=True";

            SqlConnection sqlcon = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("insert into users(name,password) values(@a,@b)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = password;


            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Save");
            sqlcon.Close();
        }

        private void btn_exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
