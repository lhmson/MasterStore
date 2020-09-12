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
    public class PhieuRut_PrintPreview_ViewModel : BaseViewModel
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
        private string _MaPhieuRut;

        public string MaPhieuRut
        {
            get { return _MaPhieuRut; }
            set { _MaPhieuRut = value; OnPropertyChanged(); }
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
        private string _NgayRut;

        public string NgayRut
        {
            get { return _NgayRut; }
            set { _NgayRut = value; OnPropertyChanged(); }
        }
        private string _SoTienRut;

        public string SoTienRut
        {
            get { return _SoTienRut; }
            set { _SoTienRut = value; OnPropertyChanged(); }
        }

        //---------------
        
        
        //--------------

        public ICommand CloseWindowCommand { get; set; }
        public ICommand Print_Command { get; set; }

        public PhieuRut_PrintPreview_ViewModel(string MaPR, string TenKH, string Ngay, string Tien)
        {
            MaPhieuRut = MaPR;
            TenKhachhang = TenKH;
            NgayRut = Ngay;
            NguoiTaoPhieu = LoginViewModel.TaiKhoanSuDung.HoTen;
            SoTienRut = Tien;
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
