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
    /// Interaction logic for User_delete.xaml
    /// </summary>
    public partial class User_delete : Window
    {
        public User_delete()
        {
            InitializeComponent();
        }

        private void btn_delete_click(object sender, RoutedEventArgs e)
        {

            string name = txt_name.Text;

            string connectionstring = @"Data Source=DESKTOP-QTC2OR9;Initial Catalog=Doctor;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "delete from users where name= @a";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@a", SqlDbType.VarChar).Value = name;
            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();

            if (rows > 0)
                MessageBox.Show("Information Has Deleted.");

        }

        private void btn_close_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
