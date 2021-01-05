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
using System.Data;

namespace BusinessSoluation999
{
    /// <summary>
    /// Interaction logic for updateManager.xaml
    /// </summary>
    public partial class updateManager : Window
    {
        public updateManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string User_Name="";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-43D7CPC\SQLEXPRESS;Initial Catalog=BusinessSoluation999;Integrated Security=True");
            con.Open();
            string u1 = Mupdate.Text;

            try
            {
                string Sql2 = "select *  from userDetails where userName like '" + u1 + "' ";
                SqlCommand command2 = new SqlCommand(Sql2, con);
                DataTable dt2 = new DataTable();
                dt2.Load(command2.ExecuteReader());
                User_Name = dt2.Rows[0]["userName"].ToString();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            if(u1.Equals(User_Name))
            {
                Update_User_Info up = new Update_User_Info(u1);
                this.Hide();
                up.Show();
            }
            else
            {
                MessageBox.Show("UserName Doesn't Found !!! ");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new manager().Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Intro().Show();
        }
    }
}
