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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BIZ;
using Repository;

namespace GoldDigger
{
    /// <summary>
    /// Interaction logic for UserControlAddCreateUser.xaml
    ///  Arthur Patwix
    /// </summary>
    public partial class UserControlAddCreateUser : UserControl
    {
        // ClassCustomer CC; 
        ClassBiz Biz;
        Grid SubGridMetalPrice;
        Grid SubGridCustomer;
        public UserControlAddCreateUser(ClassBiz inBiz, Grid inSubGridMetalPrice, Grid inSubGridCustomer)
        {
            InitializeComponent();
            Biz = inBiz;
            // cc = new ClassCustomer();
            GridUserMain.DataContext = Biz;
            SubGridCustomer = inSubGridCustomer;
            SubGridMetalPrice = inSubGridCustomer;  
        }

        private void buttonUCCUANewCustomer_Click(object sender, RoutedEventArgs e)
        {
            ((Grid)Parent).Children.Remove(this);
            SubGridMetalPrice.IsEnabled = true;

        }

        private void buttonUCCAUCancelNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            ((Grid)Parent).Children.Remove(this);
            SubGridMetalPrice.IsEnabled = true;
            // Needs Fallback Call
        }
    }
}
