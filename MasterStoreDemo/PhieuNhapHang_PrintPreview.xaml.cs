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
using MasterStoreDemo.ViewModel;

namespace MasterStoreDemo
{
    /// <summary>
    /// Interaction logic for PhieuNhapHang_PrintPreview.xaml
    /// </summary>
    public partial class PhieuNhapHang_PrintPreview : Window
    {
        public PhieuNhapHang_PrintPreview(PhieuNhapHang_PrintPreview_ViewModel x)
        {
            InitializeComponent();
            this.DataContext = x;
        }
    }
}
