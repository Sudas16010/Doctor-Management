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
    /// Interaction logic for Total_User_id.xaml
    /// </summary>
    public partial class Total_User_id : Window
    {
        public Total_User_id()
        {
            InitializeComponent();
            
        }

        private void btn_search_click(object sender, RoutedEventArgs e)
        {
            txt_total.Text = "";

            string connectionstring = @"Data Source=DESKTOP-QTC2OR9;Initial Catalog=Doctor;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from dbo.users";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            var count = (string)txt_total.Text;


            while (read.Read())
            {
                 count = txt_total.Text;
            

                sqlcon.Close(); ;
            }
        }
    }
}
