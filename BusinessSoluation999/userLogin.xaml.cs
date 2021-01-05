using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace BusinessSoluation999
{
    /// <summary>
    /// Interaction logic for userLogin.xaml
    /// </summary>
    public partial class userLogin : Window
    {
        public userLogin()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Intro().Show();

        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String name = uName.Text;
            String pass = uPass.Password;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-43D7CPC\SQLEXPRESS;Initial Catalog=BusinessSoluation999;Integrated Security=True");
            con.Open();
            try
            {
                string query = "SELECT count(*)  from [adminPanel] where userName='" + name + "'  and  password='" + pass + "' ";
                string query2 = "SELECT count(*)  from [userDetails] where userName='" + name + "'  and  password='" + pass + "' ";
                SqlCommand command = new SqlCommand(query, con);
                SqlCommand command2 = new SqlCommand(query2, con);

               // int check = Convert.ToInt32(command.ExecuteScalar());
                if (Convert.ToInt32(command.ExecuteScalar()) == 1)
                {
                    MessageBox.Show("Loging Success To Admin Panel ");
                    adminPanel a1 = new adminPanel();
                    this.Hide();
                    a1.Show();
                    
                }
                else if(Convert.ToInt32(command2.ExecuteScalar()) == 1)
                {
                    MessageBox.Show("Loging Success To User Panel ");
                    userPanel u1 = new userPanel();
                    this.Hide();
                    u1.Show();
                }
                else
                {
                    MessageBox.Show("Loging Fail !! ");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error is : " + Ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
