using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using MasterSaveDemo.Model;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;

namespace MasterSaveDemo.ViewModel
{
    public class BaoCaoDoanhSo_PrintPreview_ViewModel : BaseViewModel
    {
        //---------------
        private DateTime _NgayBaoCao;
        public DateTime NgayBaoCao
        {
            get { return _NgayBaoCao; }
            set { _NgayBaoCao = value; OnPropertyChanged(); }
        }
        //---------------
        private string _MaBaoCao;

        public string MaBaoCao
        {
            get { return _MaBaoCao; }
            set { _MaBaoCao = value; OnPropertyChanged(); }
        }

        private string _NguoiTaoPhieu;

        public string NguoiTaoPhieu
        {
            get { return _NguoiTaoPhieu; }
            set { _NguoiTaoPhieu = value; OnPropertyChanged(); }
        }

        //---------------
        private ObservableCollection<BaoCaoDS> _ListBaoCaoDoanhSo;

        public ObservableCollection<BaoCaoDS> ListBaoCaoDoanhSo
        {
            get { return _ListBaoCaoDoanhSo; }
            set { _ListBaoCaoDoanhSo = value; OnPropertyChanged(); }
        }
        //--------------

        public ICommand CloseWindowCommand { get; set; }
        public ICommand Print_Command { get; set; }

        public BaoCaoDoanhSo_PrintPreview_ViewModel(ObservableCollection<BaoCaoDS> listBaoCao, DateTime ngayBaoCao)
        {
            ListBaoCaoDoanhSo = listBaoCao;
            //for (int i = 0; i < listBaoCao.Count(); i++)
            //    ListBaoCaoDoanhSo[i].SoThuTu = i + 1;
                
            NgayBaoCao = ngayBaoCao;
            NguoiTaoPhieu = LoginViewModel.TaiKhoanSuDung.HoTen;

            CloseWindowCommand = new RelayCommand<object>((p) => { return p == null ? false : true; }, (p) => {
                var ex = p as Window;
                ex.Close();

            });

            Print_Command = new RelayCommand<object>((p) => { return p == null ? false : true; }, (p) =>
            {
                var ex = p as Window;
                try
                {
                    System.Windows.Controls.PrintDialog printDialog = new System.Windows.Controls.PrintDialog();
                    if (printDialog.ShowDialog() == true)
                    {
                        printDialog.PrintVisual(ex, "Print report");

                    }
                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show("Cannot print");
                }

            });


        }

    }

}
