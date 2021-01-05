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
    /// Interaction logic for productAdd.xaml
    /// </summary>
    public partial class productAdd : Window
    {
        public productAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Intro().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string n1 = pDate.Text;
            string n2 = pType.Text;
            string n3 = pName.Text;
            string n4 = pDetails.Text;
            string n5 = pQuantity.Text;
            string n6 = pCode.Text;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-43D7CPC\SQLEXPRESS;Initial Catalog=BusinessSoluation999;Integrated Security=True");
            con.Open();
            try
            {
                string query = "insert into [productAdd] (date, productType, productName, productDetails, quantity, code) values ('" + n1 + "','" + n2 + "','" + n3 + "','" + n4 + "','" + n5 + "','" + n6 + "')";
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
