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
    /// Interaction logic for Update_doctor.xaml
    /// </summary>
    public partial class Update_doctor : Window
    {
        public Update_doctor()
        {
            InitializeComponent();
        }

        private void btn_close_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_update_click(object sender, RoutedEventArgs e)
        {
            string id = txt_id.Text;
            string email = txt_email.Text;
            string location = txt_loc.Text;
            string phone = txt_pn.Text;
            string address = txt_add.Text;
            





            string connectionstring = @"Data Source=DESKTOP-QTC2OR9;Initial Catalog=Doctor;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "update doctor_1 set email=@a,location=@b,phone=@c,address=@d where id='" + id + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@a", SqlDbType.VarChar).Value = email;
            sqlcmd.Parameters.Add("@b", SqlDbType.VarChar).Value =location;
            sqlcmd.Parameters.Add("@c", SqlDbType.VarChar).Value = phone;
            sqlcmd.Parameters.Add("@d", SqlDbType.VarChar).Value = address;

            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();

            if (rows == 1)
                MessageBox.Show("Information Has Updated.");

        }
    }
}
