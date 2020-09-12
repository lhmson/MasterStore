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
    public class MoSo_PrintPreview_ViewModel : BaseViewModel
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
        private string _MaSo;

        public string MaSo
        {
            get { return _MaSo; }
            set { _MaSo = value; OnPropertyChanged(); }
        }
        //---------------
        private string _LoaiTietKiem;

        public string LoaiTietKiem
        {
            get { return _LoaiTietKiem; }
            set { _LoaiTietKiem = value; OnPropertyChanged(); }
        }
        //---------------
        private string _TenKH;

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; OnPropertyChanged(); }
        }
        //---------------
        private string _SoTienGui;

        public string SoTienGui
        {
            get { return _SoTienGui; }
            set { _SoTienGui = value; OnPropertyChanged(); }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; OnPropertyChanged(); }
        }

        private string _CMND;

        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; OnPropertyChanged(); }
        }

        private string _NgayMoSo;

        public string NgayMoSo
        {
            get { return _NgayMoSo; }
            set { _NgayMoSo = value; OnPropertyChanged(); }
        }


        //---------------


        //--------------

        public ICommand CloseWindowCommand { get; set; }
        public ICommand Print_Command { get; set; }

        public MoSo_PrintPreview_ViewModel(string MaSo, string TenKH, string Tien, string LTK, string CMND, string DiaChi)
        {
            NguoiTaoPhieu = LoginViewModel.TaiKhoanSuDung.HoTen;
            this.MaSo = MaSo;
            this.TenKH = TenKH;
            SoTienGui = Tien;
            NgayMoSo = DateTime.Now.ToString("dd/MM/yyyy");
            LoaiTietKiem = LTK;
            this.CMND = CMND;
            this.DiaChi = DiaChi;
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
