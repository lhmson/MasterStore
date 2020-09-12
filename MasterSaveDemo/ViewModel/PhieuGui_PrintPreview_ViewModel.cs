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
    public class PhieuGui_PrintPreview_ViewModel : BaseViewModel
    {
        //---------------



        //---------------
        private string _NguoiTaoPhieu;

        public string NguoiTaoPhieu
        {
            get { return _NguoiTaoPhieu; }
            set { _NguoiTaoPhieu = value; OnPropertyChanged(); }
        }
        //---------------
        private string _MaPhieuGui;

        public string MaPhieuGui
        {
            get { return _MaPhieuGui; }
            set { _MaPhieuGui = value; OnPropertyChanged(); }
        }
        //---------------
        private string _NgayTaoPhieu;

        public string NgayTaoPhieu
        {
            get { return _NgayTaoPhieu; }
            set { _NgayTaoPhieu = value; OnPropertyChanged(); }
        }
        //---------------
        private string _TenKhachhang;

        public string TenKhachhang
        {
            get { return _TenKhachhang; }
            set { _TenKhachhang = value; OnPropertyChanged(); }
        }
        //---------------
        private string _NgayGui;

        public string NgayGui
        {
            get { return _NgayGui; }
            set { _NgayGui = value; OnPropertyChanged(); }
        }
        private string _SoTienGui;

        public string SoTienGui
        {
            get { return _SoTienGui; }
            set { _SoTienGui = value; OnPropertyChanged(); }
        }

        //---------------


        //--------------

        public ICommand CloseWindowCommand { get; set; }
        public ICommand Print_Command { get; set; }

        public PhieuGui_PrintPreview_ViewModel(string MaPG, string TenKH, string Ngay, string Tien)
        {
            NguoiTaoPhieu = LoginViewModel.TaiKhoanSuDung.HoTen;
            MaPhieuGui = MaPG;
            TenKhachhang = TenKH;
            NgayGui = Ngay;
            SoTienGui = Tien;
            NgayTaoPhieu = DateTime.Now.ToString("dd/MM/yyyy");
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
