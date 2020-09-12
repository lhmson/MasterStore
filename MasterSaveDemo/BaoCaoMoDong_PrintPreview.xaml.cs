using MasterSaveDemo.ViewModel;
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

namespace MasterSaveDemo
{
    /// <summary>
    /// Interaction logic for BaoCaoMoDong_PrintPreview.xaml
    /// </summary>
    public partial class BaoCaoMoDong_PrintPreview : Window
    {
        public BaoCaoMoDong_PrintPreview(BaseViewModel x)
        {
            InitializeComponent();
            this.DataContext = x;
        }
    }
}