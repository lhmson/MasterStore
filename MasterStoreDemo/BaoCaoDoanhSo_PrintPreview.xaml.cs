﻿using MasterStoreDemo.ViewModel;
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

namespace MasterStoreDemo
{
    /// <summary>
    /// Interaction logic for BaoCaoDoanhSo_PrintPreview.xaml
    /// </summary>
    public partial class BaoCaoDoanhSo_PrintPreview : Window
    {
        public BaoCaoDoanhSo_PrintPreview(BaseViewModel x)
        {
            InitializeComponent();
            this.DataContext = x;
        }
    }
}
