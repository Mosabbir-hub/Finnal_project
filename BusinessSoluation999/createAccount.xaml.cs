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
    /// Interaction logic for createAccount.xaml
    /// </summary>
    public partial class createAccount : Window
    {
        public createAccount()
        {
            InitializeComponent();
        }

 
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Intro().Show();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string uname = uName.Text;
            string name = sname.Text;
            string phone = pNum.Text;
            string pass = uPass.Password;
            string address = uAdd.Text;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-43D7CPC\SQLEXPRESS;Initial Catalog=BusinessSoluation999;Integrated Security=True");
            con.Open();
            try
            {
                string query = "insert into [userDetails] (userName, name, phoneNumber, password, address) values ('" + uname + "','" + name + "','" + phone + "','" + pass + "','" + address + "')";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("succesful");

            }

            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

           

        }
    }
}
