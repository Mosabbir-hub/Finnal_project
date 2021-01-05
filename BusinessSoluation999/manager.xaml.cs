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
    /// Interaction logic for manager.xaml
    /// </summary>
    public partial class manager : Window
    {
        public manager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new createAccount().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Intro().Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new adminPanel().Show();



        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
                totalUser tu1 = new totalUser();
                this.Hide();
                tu1.Show();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new searchManager().Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            updateManager up = new updateManager();
            this.Hide();
            up.Show();
        }
    }
}
