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
    /// Interaction logic for Update_User_Info.xaml
    /// </summary>
    public partial class Update_User_Info : Window
    {
        string UserName;
        public Update_User_Info(string u1)
        {
            InitializeComponent();
            UserName = u1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-43D7CPC\SQLEXPRESS;Initial Catalog=BusinessSoluation999;Integrated Security=True");
            con.Open();
            string m1 = MuserName.Text;
            string m2 = Mname.Text;
            string m3 = Mphone.Text;
            string m4 = Mpass.Password;
            string m5 = Maddress.Text;

            try
            {
                string sql = "update [userDetails] set userName='" + m1 + "' , name='" + m2 + "' , phoneNumber='" + m3 + "' , password= '"+m4+"',address='"+m5+"' where userName='"+UserName+"' ";
                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Information Updated Successfully !!");
                

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            updateManager um1 = new updateManager();
            this.Hide();
            um1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Intro i1 = new Intro();
            this.Hide();
            i1.Show();
        }
    }
}
