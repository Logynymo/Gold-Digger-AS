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
using Repository;
using BIZ;

namespace GoldDigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBiz CB;
        UserControlUpdateMetalPrice userControlUpdateMetalPrice;
        UserControlAddCreateUser userControlAddCreateUser;
        public MainWindow()
        {
            InitializeComponent();
            CB = new ClassBiz();
            userControlUpdateMetalPrice = new UserControlUpdateMetalPrice(CB);
            userControlAddCreateUser = new UserControlAddCreateUser(CB, SubGridCustomer, SubGridMetalPrice);
            MainWindowGrid.DataContext = CB;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView Lva = (ListView)sender;
            if (Lva.SelectedItem != null)
            {
                CB.currentCustomer = null;
                CB.currentCustomer = (Customer)Lva.SelectedItem;
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubGridCustomer.Children.Add(userControlAddCreateUser);
            SubGridMetalPrice.IsEnabled = false;
        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            SubGridMetalPrice.Children.Add(userControlUpdateMetalPrice);
            SubGridCustomer.IsEnabled = false; 
        }
    }
}