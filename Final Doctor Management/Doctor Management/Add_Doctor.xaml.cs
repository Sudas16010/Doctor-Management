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
    /// Interaction logic for Add_Doctor.xaml
    /// </summary>
    public partial class Add_Doctor : Window
    {
        public Add_Doctor()
        {
            InitializeComponent();
        }

        private void btn_add_click(object sender, RoutedEventArgs e)
        {
            //start text box........................
            string name = txt_name.Text;
            string id = txt_id.Text;
            string email = txt_email.Text;
            string phone = txt_pn.Text;
            string address = txt_add.Text;
            string location = txt_loc.Text;
            string type = txt_ty.Text;
            //end text box........................


            //start radio button........................
            string gender;
            if (rdo_male.IsChecked.Value == true)
            {
                gender = "Male";
            }
            else if (rdo_female.IsChecked.Value == true)
            {
                gender = "Female";
            }
            else
            {
                gender = "Others";
            }

            //end radio button........................



            //start checkbox........................

            string married;
            if (ckb_check.IsChecked.Value == true)
            {
                married = "Yes";
            }
            else
            {
                married = "No";
            }


            //end checkbox........................


            //start combobox........................

            var a = (ComboBoxItem)cmb_bd.SelectedItem;
            var blood = (string)a.Content;

            //end combobox..........................

            //start listbox........................

            var b = (ListBoxItem)listb_reli.SelectedItem;
            var religion = (string)b.Content;

            //end listbox..........................


            //start datepiker........................

            string birth;
            birth = dpic_dob.SelectedDate.Value.ToShortDateString();

            //end ldatepiker..........................

            //start calender........................

            string enrollment;
            enrollment = calen_enroll.SelectedDate.Value.ToShortDateString();

            //end calender..........................


            string connectionstring = @"Data Source=DESKTOP-QTC2OR9;Initial Catalog=Doctor;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into doctor_1 values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = location;
            cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = married;
            cmd.Parameters.Add("@h", SqlDbType.Date).Value = birth;
            cmd.Parameters.Add("@i", SqlDbType.Date).Value = enrollment;
            cmd.Parameters.Add("@j", SqlDbType.VarChar).Value = blood;
            cmd.Parameters.Add("@k", SqlDbType.VarChar).Value = religion;
            cmd.Parameters.Add("@l", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@m", SqlDbType.VarChar).Value = address;
            // cmd.Parameters.Add("@c", SqlDbType.Int).Value = amount;

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Save");
            sqlcon.Close();

        }

        private void btn_close_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_home_click(object sender, RoutedEventArgs e)
        {
            MainWindow sd = new MainWindow();
            sd.Show();
        }
    }
}
