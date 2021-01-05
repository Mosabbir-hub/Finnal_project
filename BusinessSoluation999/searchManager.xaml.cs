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
    /// Interaction logic for searchManager.xaml
    /// </summary>
    public partial class searchManager : Window
    {
        public searchManager()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string m1 = sManager.Text;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-43D7CPC\SQLEXPRESS;Initial Catalog=BusinessSoluation999;Integrated Security=True");
            con.Open();

            try
            {
                string query = "SELECT *  from [userDetails] where userName='" + m1 + "' ";

                //
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, con);
                DataTable dt2 = new DataTable();
                sqlDA.Fill(dt2);
                dbgv.ItemsSource = dt2.DefaultView;



            }

            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
