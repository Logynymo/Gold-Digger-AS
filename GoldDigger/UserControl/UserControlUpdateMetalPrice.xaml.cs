﻿using System;
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
    /// Interaction logic for UserControlUpdateMetalPrice.xaml
    /// </summary>
    public partial class UserControlUpdateMetalPrice : UserControl
    {
        public UserControlUpdateMetalPrice(ClassBIZ CB)
        {
            InitializeComponent();
            ClassCustomer CC = new ClassCustomer();
            MainMetalGrid.DataContext = CB;
        }

        private void UCUpdateMetalPriceSaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UCUpdateMetalPriceCancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainMetalGrid.Children.Clear();
            MainMetalGrid.Children.Remove(this);
        }
    }
}
