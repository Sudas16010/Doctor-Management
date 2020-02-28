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
            txt_details.Text = "";

            string connectionstring = @"Data Source=DESKTOP-QTC2OR9;Initial Catalog=Doctor;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from dbo.doctor_1 where   location='" + txt_loc.Text + "' and type='" + txt_ty.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            if (read.Read())
            {
                    txt_details.Text = "Name:" + read[0].ToString();
                    txt_details.Text += "\nLocation:" + read[3].ToString();
                    txt_details.Text += "\nType:" + read[4].ToString();
                    txt_details.Text += "\nGender:" + read[5].ToString();
                    txt_details.Text += "\nMarried:" + read[6].ToString();
                    txt_details.Text += "\nBirth:" + read[7].ToString();
                    txt_details.Text += "\nReligion:" + read[10].ToString();
                    txt_details.Text += "\nPhone:" + read[11].ToString();
                    txt_details.Text += "\nAddress:" + read[12].ToString();


         

                sqlcon.Close(); ;
            }
            else
            {
                MessageBox.Show("Sorry,doctor is not find.", "Search Status", MessageBoxButton.OK);
                txt_loc.Text = "";
                txt_ty.Text = "";

            }


           
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
