﻿using MasterSaveDemo.Helper;
using MasterSaveDemo.Model;
﻿using MasterSaveDemo.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Threading;

namespace MasterSaveDemo.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Variable

        static public DispatcherTimer _timer;

        private bool _Selected_HOME;
        public bool Selected_HOME
        {
            get => _Selected_HOME;
            set { _Selected_HOME = value; OnPropertyChanged(); }
        }

        private bool _Selected_DangXuat;
        public bool Selected_DangXuat
        {
            get => _Selected_DangXuat;
            set { _Selected_DangXuat = value; OnPropertyChanged(); }
        }
        private bool _Enable_Home;
        public bool Enable_Home
        {
            get => _Enable_Home;
            set { _Enable_Home = value; OnPropertyChanged(); }
        }

        private bool _Enable_MoSo;
        public bool Enable_XuatHang
        {
            get => _Enable_MoSo;
            set { _Enable_MoSo = value; OnPropertyChanged(); }
        }

        private bool _Enable_GuiTien;
        public bool Enable_BanHang
        {
            get => _Enable_GuiTien;
            set { _Enable_GuiTien = value; OnPropertyChanged(); }
        }

        private bool _Enable_RutTien;
        public bool Enable_TraCuu
        {
            get => _Enable_RutTien;
            set { _Enable_RutTien = value; OnPropertyChanged(); }
        }

        private bool _Enable_TraCuu;
        public bool Enable_BCDS
        {
            get => _Enable_TraCuu;
            set { _Enable_TraCuu = value; OnPropertyChanged(); }
        }

        private bool _Enable_BCDS;
        public bool Enable_BCTK
        {
            get => _Enable_BCDS;
            set { _Enable_BCDS = value; OnPropertyChanged(); }
        }

        private bool _Enable_BCMD;
        public bool Enable_TDQD
        {
            get => _Enable_BCMD;
            set { _Enable_BCMD = value; OnPropertyChanged(); }
        }

        private Page _FrameContent;

        public Page FrameContent
        { 
            get { return _FrameContent; }
            set { _FrameContent = value; OnPropertyChanged(); }
        }

        #region ICommand
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand Home_Page_SelectedCommand { get; set; }
        public ICommand NhapHang_Page_SelectedCommand { get; set; }
        public ICommand XuatHang_Page_SelectedCommand { get; set; }
        public ICommand BanHang_Page_SelectedCommand { get; set; }
        public ICommand TraCuu_Page_SelectedCommand { get; set; }
        public ICommand BaoCaoDoanhSo_Page_SelectedCommand { get; set; }
        public ICommand BaoCaoTonKho_Page_SelectedCommand { get; set; }
        public ICommand ThayDoiQuyDinh_Page_SelectedCommand { get; set; }
        public ICommand QuanLyNhanSu_Page_SelectedCommand { get; set; }
        public ICommand CaiDatKhac_Page_SelectedCommand { get; set; }
        public ICommand DangXuat_SelectedCommand { get; set; }
        #endregion

        private bool _Enable_TDQD;
        public bool Enable_QLNS
        {
            get => _Enable_TDQD;
            set { _Enable_TDQD = value; OnPropertyChanged(); }
        }

        private bool _Enable_QLNS;
        public bool Enable_NhapHang
        {
            get => _Enable_QLNS;
            set { _Enable_QLNS = value; OnPropertyChanged(); }
        }

        // tool tip of navigation
        private string _Home_Tooltip;
        public string Home_Tooltip
        {
            get => _Home_Tooltip;
            set { _Home_Tooltip = value; OnPropertyChanged(); }
        }

        private string _MoSo_Tooltip;
        public string XuatHang_Tooltip
        {
            get => _MoSo_Tooltip;
            set { _MoSo_Tooltip = value; OnPropertyChanged(); }
        }

        private string _GuiTien_Tooltip;
        public string BanHang_Tooltip
        {
            get => _GuiTien_Tooltip;
            set { _GuiTien_Tooltip = value; OnPropertyChanged(); }
        }

        private string _RutTien_Tooltip;
        public string TraCuu_Tooltip
        {
            get => _RutTien_Tooltip;
            set { _RutTien_Tooltip = value; OnPropertyChanged(); }
        }

        private string _TraCuu_Tooltip;
        public string BaoCaoDS_Tooltip
        {
            get => _TraCuu_Tooltip;
            set { _TraCuu_Tooltip = value; OnPropertyChanged(); }
        }

        private string _BaoCaoDS_Tooltip;
        public string BaoCaoTK_Tooltip
        {
            get => _BaoCaoDS_Tooltip;
            set { _BaoCaoDS_Tooltip = value; OnPropertyChanged(); }
        }

        private string _BaoCaoMD_Tooltip;
        public string TDQD_Tooltip
        {
            get => _BaoCaoMD_Tooltip;
            set { _BaoCaoMD_Tooltip = value; OnPropertyChanged(); }
        }

        private string _TDQD_Tooltip;
        public string QLNS_Tooltip
        {
            get => _TDQD_Tooltip;
            set { _TDQD_Tooltip = value; OnPropertyChanged(); }
        }

        private string _QLNS_Tooltip;
        public string NhapHang_Tooltip
        {
            get => _QLNS_Tooltip;
            set { _QLNS_Tooltip = value; OnPropertyChanged(); }
        }

        #endregion


        public bool isLoaded = false;

   

        #region Function
        private void Init_Button_User(NGUOIDUNG user)
        {
            Init_Button();
            ObservableCollection<PHANQUYEN> list_PhanQuyen= new ObservableCollection<PHANQUYEN>(DataProvider.Ins.DB.PHANQUYENs);
            foreach (var item in list_PhanQuyen)
            {
                if (item.MaNhom == user.MaNhom)
                {
                    Init_Valid_Button(item.MaChucNang);
                    Init_Valid_Tooltip(item.MaChucNang);
                }
            }
        }

        private void Init_Button()
        {
            Enable_Home = Enable_BanHang = Enable_TraCuu = Enable_BCDS = Enable_BCTK = Enable_TDQD = Enable_NhapHang = Enable_QLNS = Enable_XuatHang =  false;
            Enable_Home = true;
            // tooltip handle
            XuatHang_Tooltip = BanHang_Tooltip = TraCuu_Tooltip = BaoCaoDS_Tooltip = BaoCaoTK_Tooltip = TDQD_Tooltip = NhapHang_Tooltip = QLNS_Tooltip = "Không thể truy cập";
            Home_Tooltip = "Có thể truy cập";
        }

        private void Init_Valid_Button(int maChucNang)
        {
            switch (maChucNang)
            {
                case 1:
                    Enable_NhapHang = true;
                    break;
                case 2:
                    Enable_XuatHang = true;
                    break;
                case 3:
                    Enable_BanHang = true;
                    break;
                case 4:
                    Enable_TraCuu = true;
                    break;
                case 5:
                    Enable_BCDS = true;
                    break;
                case 6:
                    Enable_BCTK = true;
                    break;
                case 7:
                    Enable_TDQD = true;
                    break;
                case 8:
                    Enable_QLNS = true;
                    break;
                case 9:
                    break;
            }
        }

        // tool tip
        private void Init_Valid_Tooltip(int maChucNang)
        {
            switch (maChucNang)
            {
                case 1:
                    NhapHang_Tooltip = "Có thể truy cập";
                    break;
                case 2:
                    XuatHang_Tooltip = "Có thể truy cập";
                    break;
                case 3:
                    BanHang_Tooltip = "Có thể truy cập";
                    break;
                case 4:
                    TraCuu_Tooltip = "Có thể truy cập";
                    break;
                case 5:
                    BaoCaoDS_Tooltip = "Có thể truy cập";
                    break;
                case 6:
                    BaoCaoTK_Tooltip = "Có thể truy cập";
                    break;
                case 7:
                    TDQD_Tooltip = "Có thể truy cập";
                    break;
                case 8:
                    QLNS_Tooltip = "Có thể truy cập";
                    break;
            }
        }

        static public void Start_Timer()
        {
            _timer.Start();
        }
        static public void LogOut()
        {
            
        }
        public ICommand Home_Select { get; set; }
        #endregion
        public MainViewModel() // all main page handling goes there
        {
            updateThongKeNgay();
            // set bang true sau nay phai sua hihi
            Enable_BCTK = Enable_TDQD = Enable_BanHang = Enable_Home = Enable_XuatHang = Enable_NhapHang = Enable_TraCuu = Enable_QLNS = Enable_BCDS = true;
            //Selected_HOME = true;
            //Selected_DangXuat = false;
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {

                //if (p == null) return;
                p.Hide(); // main view hide in login window

                // cmt de chay main, sau nay code cho login sau hihi
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
                isLoaded = true;

                //if (loginWindow.DataContext == null) return;
                //var loginVM = loginWindow.DataContext as LoginViewModel;
                //if (loginVM.isLogin)
                //{
                p.Show();
                //    LoadRemainsData(); // show remain table
                //}
                //else
                //{

                //}

                _timer = new DispatcherTimer(DispatcherPriority.Render);
                _timer.Interval = TimeSpan.FromSeconds(1);
                _timer.Tick += (sender, args) =>
                {
                    if (LoginViewModel.TaiKhoanSuDung != null)
                    {
                        Init_Button_User(LoginViewModel.TaiKhoanSuDung);
                        
                        _timer.Stop();
                    }
                };
                _timer.Start();

                FrameContent = new Home_Page();

            });

            Home_Page_SelectedCommand = new RelayCommand<HamburgerMenu.HamburgerMenu>((p) => { return true; }, (p) => {
                //Selected_HOME = true;
                //Selected_DangXuat = false;
                FrameContent = new Home_Page();
                FrameContent.DataContext = new Home_PageViewModel();
            });

            NhapHang_Page_SelectedCommand = new RelayCommand<HamburgerMenu.HamburgerMenu>((p) => { return true; }, (p) => {
                //Selected_HOME = false;
                //Selected_DangXuat = false;
                FrameContent = new NhapHang_Page();
                FrameContent.DataContext = new NhapHang_ViewModel();
            });

            XuatHang_Page_SelectedCommand = new RelayCommand<HamburgerMenu.HamburgerMenu>((p) => { return true; }, (p) => {
                //Selected_HOME = false;
                //Selected_DangXuat = false;
                FrameContent = new XuatHang_Page();
                FrameContent.DataContext = new XuatHang_ViewModel();
            });

            BanHang_Page_SelectedCommand = new RelayCommand<HamburgerMenu.HamburgerMenu>((p) => { return true; }, (p) => {
                //Selected_HOME = false;
                //Selected_DangXuat = false;
                FrameContent = new BanHang_Page();
                FrameContent.DataContext = new BanHang_ViewModel();
            });
            TraCuu_Page_SelectedCommand = new RelayCommand<HamburgerMenu.HamburgerMenu>((p) => { return true; }, (p) => {
                //Selected_HOME = false;
                //Selected_DangXuat = false;
                FrameContent = new TraCuu_Page();
                FrameContent.DataContext = new TraCuu_ViewModel();
            });
            BaoCaoDoanhSo_Page_SelectedCommand = new RelayCommand<HamburgerMenu.HamburgerMenu>((p) => { return true; }, (p) => {
                //Selected_HOME = false;
                //Selected_DangXuat = false;
                FrameContent = new BaoCaoDoanhSo_Page();
                FrameContent.DataContext = new BaoCaoDoanhSo_ViewModel();
            });
            BaoCaoTonKho_Page_SelectedCommand = new RelayCommand<HamburgerMenu.HamburgerMenu>((p) => { return true; }, (p) => {
                //Selected_HOME = false;
                //Selected_DangXuat = false;
                FrameContent = new BaoCaoTonKho_Page();
                FrameContent.DataContext = new BaoCaoTonKho_ViewModel();
            });
            ThayDoiQuyDinh_Page_SelectedCommand = new RelayCommand<HamburgerMenu.HamburgerMenu>((p) => { return true; }, (p) => {
                //Selected_HOME = false;
                //Selected_DangXuat = false;
                FrameContent = new ThayDoiQuyDinh_Page();
                FrameContent.DataContext = new ThayDoiQuyDinh_ViewModel();
            });
            QuanLyNhanSu_Page_SelectedCommand = new RelayCommand<HamburgerMenu.HamburgerMenu>((p) => { return true; }, (p) => {
                //Selected_HOME = false;
                //Selected_DangXuat = false;
                FrameContent = new QuanLyNhanSu_Page();
                FrameContent.DataContext = new QuanLyNhanSu_ViewModel();
            });
            CaiDatKhac_Page_SelectedCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                FrameContent = new CaiDatKhac_Page();
                FrameContent.DataContext = new CaiDatKhac_Page();
            });
            DangXuat_SelectedCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                System.Windows.Forms.DialogResult kq = System.Windows.Forms.MessageBox.Show("Bạn có chắc đăng xuất tài khoản này không?", "Đăng xuất", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
                if (kq == System.Windows.Forms.DialogResult.Yes)
                {
                    // restart the program
                    System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                    Application.Current.Shutdown();
                }
            });
        }
        public void updateThongKeNgay()
        {
            var ThongKeNgay = new ObservableCollection<THONGKENGAY>(DataProvider.Ins.DB.THONGKENGAYs);
            DateTime NgayKhaiTruong = new DateTime(2020, 09, 21);
            DateTime LastUpdatedDay = NgayKhaiTruong.AddDays(-1);
            int CountThongKe = (from tk in ThongKeNgay
                                select tk).Count();
            if (CountThongKe > 0)
                LastUpdatedDay = (from tk in ThongKeNgay
                                  select tk).Last().Ngay;
            for (DateTime i = LastUpdatedDay.AddDays(1); i < DateTime.Today; i = i.AddDays(1))
            {
                CountThongKe++;
                THONGKENGAY thongkengay = new THONGKENGAY()
                {
                    MaThongKe = "TKN" + "000".Substring(0, 4 - CountThongKe.ToString().Length) + CountThongKe.ToString(),
                    Ngay = i,
                };
                DataProvider.Ins.DB.THONGKENGAYs.Add(thongkengay);
                DataProvider.Ins.DB.SaveChanges();
                var MatHang = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);
                var ChiTietThongKe = new ObservableCollection<CT_THONGKENGAY>(DataProvider.Ins.DB.CT_THONGKENGAY);
                int CountChiTietThongKe = (from cttk in ChiTietThongKe
                                           select cttk).Count();
                var TheKho = new ObservableCollection<THEKHO>(DataProvider.Ins.DB.THEKHOes);
                var ChiTietTheKho = new ObservableCollection<CT_THEKHO>(DataProvider.Ins.DB.CT_THEKHO);
                var PhieuNhap = new ObservableCollection<PHIEUNHAPKHO>(DataProvider.Ins.DB.PHIEUNHAPKHOes);
                var ChiTietPhieuNhap = new ObservableCollection<CT_PHIEUNHAPKHO>(DataProvider.Ins.DB.CT_PHIEUNHAPKHO);
                var PhieuXuat = new ObservableCollection<PHIEUXUATKHO>(DataProvider.Ins.DB.PHIEUXUATKHOes);
                var ChiTietPhieuXuat = new ObservableCollection<CT_PHIEUXUATKHO>(DataProvider.Ins.DB.CT_PHIEUXUATKHO);
                var HoaDon = new ObservableCollection<HOADON>(DataProvider.Ins.DB.HOADONs);
                var ChiTietHoaDon = new ObservableCollection<CT_HOADON>(DataProvider.Ins.DB.CT_HOADON);
                foreach (var item in MatHang)
                {
                    CountChiTietThongKe++;
                    var AllPhieuNhap = (from ctpn in ChiTietPhieuNhap
                                        join pn in PhieuNhap on ctpn.MaPhieuNhapKho equals pn.MaPhieuNhapKho
                                        where (ctpn.MaMH == item.MaMH && pn.NgayLap.Date == i.Date && pn.Duyet == 1)
                                        select ctpn);
                    int TongNhap = 0;
                    if (AllPhieuNhap.Count() > 0)
                        TongNhap += AllPhieuNhap.Select(a => a.SoLuong).Sum();
                    var AllPhieuXuat = (from ctpx in ChiTietPhieuXuat
                                        join px in PhieuXuat on ctpx.MaPhieuXK equals px.MaPhieuXK
                                        where (ctpx.MaMH == item.MaMH && px.NgayLap.Date == i.Date && px.TrangThai == 1)
                                        select ctpx);
                    int TongXuat = 0;
                    if (AllPhieuXuat.Count() > 0)
                        TongXuat += AllPhieuXuat.Select(a => a.SoLuong).Sum();
                    var LayTon = (from tk in TheKho
                                  where (tk.MaMH == item.MaMH)
                                  select tk);
                    int SoLuongTon = 0;
                    if (LayTon.Count() > 0)
                        SoLuongTon += LayTon.First().SoLuongTonKho;
                    var LayThu = (from cthd in ChiTietHoaDon
                                  join hd in HoaDon on cthd.MaHoaDon equals hd.MaHoaDon
                                  where (hd.NgayLap.Date == i.Date && cthd.MaMH == item.MaMH)
                                  select cthd);
                    decimal TongThu = 0;
                    foreach (var moihoadon in LayThu)
                    {
                        TongThu += moihoadon.SoLuong * moihoadon.DonGiaBan;
                    }
                    decimal TongChi = 0;
                    foreach (var moihoadon in AllPhieuNhap)
                    {
                        TongChi += moihoadon.DonGiaNhap * moihoadon.SoLuong;
                    }
                    CT_THONGKENGAY ctthongkengay = new CT_THONGKENGAY()
                    {
                        MaCTTK = "CTTKN" + "00000".Substring(0, 5 - CountChiTietThongKe.ToString().Length) + CountChiTietThongKe.ToString(),
                        MaThongKe = thongkengay.MaThongKe,
                        MaMH = item.MaMH,
                        Nhap = TongNhap,
                        Xuat = TongXuat,
                        Ton = SoLuongTon,
                        Thu = TongThu,
                        Chi = TongChi,
                    };
                    DataProvider.Ins.DB.CT_THONGKENGAY.Add(ctthongkengay);
                    DataProvider.Ins.DB.SaveChanges();
                };
            }

        }

    }
}
