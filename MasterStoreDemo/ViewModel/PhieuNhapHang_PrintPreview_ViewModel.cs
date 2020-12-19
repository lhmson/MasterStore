using MasterStoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using MasterStoreDemo.Helper;
namespace MasterStoreDemo.ViewModel
{
    public class PhieuNhapHang_PrintPreview_ViewModel : BaseViewModel
    {
        public ICommand CloseWindowCommand { get; set; }
        public ICommand Print_Command { get; set; }

        private string _maphieunhapkho;
        public string MaPhieuNhapKho
        {
            get { return _maphieunhapkho; }
            set { _maphieunhapkho = value; OnPropertyChanged(); }
        }

        private string _TongTien;
        public string TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; OnPropertyChanged(); }
        }

        private ObservableCollection<ListMatHangMua> _ListMatHang;
        public ObservableCollection<ListMatHangMua> ListMatHang
        {
            get { return _ListMatHang; }
            set { _ListMatHang = value; OnPropertyChanged(); }
        }

        private string _NgayLap;
        public string NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; OnPropertyChanged(); }
        }

        private string _TenNhanVien;
        public string TenNhanVien
        {
            get { return _TenNhanVien; }
            set { _TenNhanVien = value; OnPropertyChanged(); }
        }

        private string _TenNCC;
        public string TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; OnPropertyChanged(); }
        }

        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; OnPropertyChanged(); }
        }

        private string _SDT;
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; OnPropertyChanged(); }
        }

        private string _Fax;
        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; OnPropertyChanged(); }
        }

        public void Load()
        {
            string NgayLapPNK = DateTime.Now.ToString("dd/MM/yyyy");
            NgayLap = "Ngày " + NgayLapPNK[0] + NgayLapPNK[1] + ", Tháng " + NgayLapPNK[3] + NgayLapPNK[4] + ", Năm " + NgayLapPNK.Substring(6);
        }

        public PhieuNhapHang_PrintPreview_ViewModel(string mapnk, string tennhanvien, string ngaylap, string tenncc, String diachi, string sdt, string fax, string tongtien, ObservableCollection<ListMatHangMua> list)
        {
            MaPhieuNhapKho = mapnk;
            TongTien = tongtien;
            TenNhanVien = tennhanvien;
            NgayLap = ngaylap;
            TenNCC = tenncc;
            DiaChi = diachi;
            SDT = sdt;
            Fax = fax;
            ListMatHang = list;
            Load();

            CloseWindowCommand = new RelayCommand<Window>((p) => { return p == null ? false : true; }, (p) => {
                p.Close();
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
