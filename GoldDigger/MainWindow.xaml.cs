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

namespace GoldDigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ CB;
        UserControlUpdateMetalPrice userControlUpdateMetalPrice;
        public MainWindow()
        {
            InitializeComponent();
            CB = new ClassBIZ();
            userControlUpdateMetalPrice = new UserControlUpdateMetalPrice(CB);
            SubGridMetalPrice.Children.Add(userControlUpdateMetalPrice);
        }
    }
}