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

namespace BusinessSoluation999
{
    /// <summary>
    /// Interaction logic for userPanel.xaml
    /// </summary>
    public partial class userPanel : Window
    {
        public userPanel()
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
            this.Hide();
            new productAdd().Show();
        }
    }
}
