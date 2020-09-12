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
    /// Interaction logic for 
    /// </summary>
    public partial class PhieuRut_PrintPreview : Window
    {
        public PhieuRut_PrintPreview(BaseViewModel x)
        {
            InitializeComponent();
            this.DataContext = x;
        }
    }
}