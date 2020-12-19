﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MasterStoreDemo.View
{
    /// <summary>
    /// Interaction logic for BanHang_Page.xaml
    /// </summary>
    public partial class BanHang_Page : Page
    {
        public BanHang_Page()
        {
            InitializeComponent();
        }

        private void SoTienRutTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9,]+");
        }
    }
}
