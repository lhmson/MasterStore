using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using MasterStoreDemo.Model;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;

namespace MasterStoreDemo.ViewModel
{
    public class BaoCaoTonKho_PrintPreview_ViewModel : BaseViewModel
    {
        #region Old code





        ////---------------



        ////---------------
        //private string _ThangBaoCao;

        //public string ThangBaoCao
        //{
        //    get { return _ThangBaoCao; }
        //    set { _ThangBaoCao = value; OnPropertyChanged(); }
        //}
        ////---------------
        //private string _NamBaoCao;

        //public string NamBaoCao
        //{
        //    get { return _NamBaoCao; }
        //    set { _NamBaoCao = value; OnPropertyChanged(); }
        //}
        ////---------------
        //private string _NgayLapBaoCao;

        //public string NgayLapBaoCao
        //{
        //    get { return _NgayLapBaoCao; }
        //    set { _NgayLapBaoCao = value; OnPropertyChanged(); }
        //}
        ////---------------
        //private string _MaBaoCao;

        //public string MaBaoCao
        //{
        //    get { return _MaBaoCao; }
        //    set { _MaBaoCao = value; OnPropertyChanged(); }
        //}
        ////---------------
        //private string _LoaiTietKiem;

        //public string LoaiTietKiem
        //{
        //    get { return _LoaiTietKiem; }
        //    set { _LoaiTietKiem = value; OnPropertyChanged(); }
        //}

        //private string _NguoiTaoPhieu;

        //public string NguoiTaoPhieu
        //{
        //    get { return _NguoiTaoPhieu; }
        //    set { _NguoiTaoPhieu = value; OnPropertyChanged(); }
        //}

        ////---------------
        //private ObservableCollection<ListBaoCaoDongMo> _ListBaoCaoDMPP;

        //public ObservableCollection<ListBaoCaoDongMo> ListBaoCaoDMPP
        //{
        //    get { return _ListBaoCaoDMPP; }
        //    set { _ListBaoCaoDMPP = value; OnPropertyChanged(); }
        //}
        ////--------------

        //public ICommand CloseWindowCommand { get; set; }
        //public ICommand Print_Command { get; set; }

        //public BaoCaoTonKho_PrintPreview_ViewModel(string MaBC, string Thang, string Nam, string LTK, ObservableCollection<ListBaoCaoDongMo> list)
        //{
        //    ListBaoCaoDMPP = list;
        //    NamBaoCao = Nam;
        //    MaBaoCao = MaBC;
        //    ThangBaoCao = Thang;
        //    LoaiTietKiem = LTK;
        //    NgayLapBaoCao = DateTime.Now.ToString("dd/MM/yyyy");
        //    NguoiTaoPhieu = LoginViewModel.TaiKhoanSuDung.HoTen;
        //    CloseWindowCommand = new RelayCommand<object>((p) => { return p == null ? false : true; }, (p) => {
        //        var ex = p as Window;
        //        ex.Close();

        //    });

        //    Print_Command = new RelayCommand<object>((p) => { return p == null ? false : true; }, (p) =>
        //    {
        //        var ex = p as Window;
        //        try
        //        {
        //            System.Windows.Controls.PrintDialog printDialog = new System.Windows.Controls.PrintDialog();
        //            if (printDialog.ShowDialog() == true)
        //            {
        //                printDialog.PrintVisual(ex, "Print report");

        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            System.Windows.MessageBox.Show("Cannot print");
        //        }

        //    });


        //}

        #endregion
        
         // new code from this
         private DateTime _StartDate;
         public DateTime StartDate
         {
             get { return _StartDate; }
             set { _StartDate = value; OnPropertyChanged(); }
         }
         private DateTime _EndDate;
         public DateTime EndDate
         {
             get { return _EndDate; }
             set { _EndDate = value; OnPropertyChanged(); }
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

        private string _NgayThangNam;

        public string NgayThangNam
        {
            get { return _NgayThangNam; }
            set { _NgayThangNam = value; OnPropertyChanged(); }
        }


        //---------------
        private ObservableCollection<DongBaoCaoTonKho> _ListBaoCaoTonKho;

         public ObservableCollection<DongBaoCaoTonKho> ListBaoCaoTonKho
         {
             get { return _ListBaoCaoTonKho; }
             set { _ListBaoCaoTonKho = value; OnPropertyChanged(); }
         }
         public ICommand CloseWindowCommand { get; set; }
         public ICommand Print_Command { get; set; }

         public BaoCaoTonKho_PrintPreview_ViewModel(ObservableCollection<DongBaoCaoTonKho> BaoCaoTonKho, DateTime inputStartDate, DateTime inputEndDate, String inputNguoiTao)
         {
             ListBaoCaoTonKho = BaoCaoTonKho;
             StartDate = inputStartDate;
             EndDate = inputEndDate;
             NguoiTaoPhieu = inputNguoiTao;
            //for (int i = 0; i < listBaoCao.Count(); i++)
            //    ListBaoCaoDoanhSo[i].SoThuTu = i + 1;
            if (LoginViewModel.TaiKhoanSuDung != null)
                NguoiTaoPhieu = LoginViewModel.TaiKhoanSuDung.HoTen;
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            NgayThangNam = "Ngày " + date.Substring(0, 2) + ", tháng " + date.Substring(3, 2) + ", năm " + date.Substring(6, 4);
            CloseWindowCommand = new RelayCommand<object>((p) => { return p == null ? false : true; }, (p) =>
             {
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
