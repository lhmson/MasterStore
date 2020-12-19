﻿using MasterStoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace MasterStoreDemo.ViewModel
{
    public class BaoCaoTonKho_ViewModel : BaseViewModel
    {
        #region Old code
        //#region Variables
        ////copy tu mainwindow_VM
        //public bool isLoaded = false;
        //public string MaBaoCao = "";
        //public string ThangBaoCao_BD = "";
        //public string NamBaoCao_BD = "";
        //public string LoaiTietKiem_BD = "";
        ////--------------
        //private bool _canExecute;

        //public bool canExecute
        //{
        //    get { return _canExecute; }
        //    set { _canExecute = value; OnPropertyChanged(); }
        //}


        ////--------------
        //private string _Notify_Month;

        //public string Notify_Month
        //{
        //    get { return _Notify_Month; }
        //    set { _Notify_Month = value; OnPropertyChanged(); }
        //}
        ////--------------
        //private string _Notify_Year;

        //public string Notify_Year
        //{
        //    get { return _Notify_Year; }
        //    set { _Notify_Year = value; OnPropertyChanged(); }
        //}
        ////--------------
        //private string _Notify_LTK;

        //public string Notify_LTK
        //{
        //    get { return _Notify_LTK; }
        //    set { _Notify_LTK = value; OnPropertyChanged(); }
        //}
        ////--------------
        //private bool _EnableCreate;

        //public bool EnableCreate
        //{
        //    get { return _EnableCreate; }
        //    set { _EnableCreate = value; OnPropertyChanged(); }
        //}
        ////--------------
        //private ObservableCollection<string> _List_LTK;

        //public ObservableCollection<string> List_LTK
        //{
        //    get { return _List_LTK; }
        //    set { _List_LTK = value; OnPropertyChanged(); }
        //}
        ////--------------
        //private string _Selected_LTK;

        //public string Selected_LTK
        //{
        //    get { return _Selected_LTK; }
        //    set { _Selected_LTK = value; OnPropertyChanged(); }
        //}
        ////--------------
        //private string _LoaiTietKiem;

        //public string LoaiTietKiem
        //{
        //    get { return _LoaiTietKiem; }
        //    set { _LoaiTietKiem = value; OnPropertyChanged(); }
        //}
        ////------------
        //private string _Selected_Thang;

        //public string Selected_Thang
        //{
        //    get { return _Selected_Thang; }
        //    set { _Selected_Thang = value; OnPropertyChanged(); }
        //}
        ////--------------
        //private ObservableCollection<string> _List_Thang;

        //public ObservableCollection<string> List_Thang
        //{
        //    get { return _List_Thang; }
        //    set { _List_Thang = value; OnPropertyChanged(); }
        //}
        ////--------------
        //private ObservableCollection<string> _List_Nam;

        //public ObservableCollection<string> List_Nam
        //{
        //    get { return _List_Nam; }
        //    set { _List_Nam = value; OnPropertyChanged(); }
        //}
        ////-----------------
        //private string _Selected_Nam;

        //public string Selected_Nam
        //{
        //    get { return _Selected_Nam; }
        //    set { _Selected_Nam = value; OnPropertyChanged(); }
        //}
        ////----------------
        //private ObservableCollection<ListBaoCaoDongMo> _ListBaoCaoDM;

        //public ObservableCollection<ListBaoCaoDongMo> ListBaoCaoDM
        //{
        //    get { return _ListBaoCaoDM; }
        //    set { _ListBaoCaoDM = value; OnPropertyChanged(); }
        //}
        ////---------------
        //private string _STT;

        //public string STT
        //{
        //    get { return _STT; }
        //    set { _STT = value; OnPropertyChanged(); }
        //}
        ////---------------
        //private string _Ngay;

        //public string Ngay
        //{
        //    get { return _Ngay; }
        //    set { _Ngay = value; OnPropertyChanged(); }
        //}
        ////---------------
        //private string _SoMo;

        //public string SoMo
        //{
        //    get { return _SoMo; }
        //    set { _SoMo = value; OnPropertyChanged(); }
        //}
        ////---------------
        //private string _SoDong;

        //public string SoDong
        //{
        //    get { return _SoDong; }
        //    set { _SoDong = value; OnPropertyChanged(); }
        //}
        ////---------------
        //private string _ChenhLech;

        //public string ChenhLech
        //{
        //    get { return _ChenhLech; }
        //    set { _ChenhLech = value; OnPropertyChanged(); }
        //}
        ////---------------
        //private ObservableCollection<ListBaoCaoDongMo_DaBaoCao> _ListDaBaoCao;

        //public ObservableCollection<ListBaoCaoDongMo_DaBaoCao> ListDaBaoCao
        //{
        //    get { return _ListDaBaoCao; }
        //    set { _ListDaBaoCao = value; OnPropertyChanged(); }
        //}
        ////------------
        //private string _ThangNamDaBaoCao;

        //public string ThangNamDaBaoCao
        //{
        //    get { return _ThangNamDaBaoCao; }
        //    set { _ThangNamDaBaoCao = value; OnPropertyChanged(); }
        //}
        ////------------
        //private string _LTKDaBaoCao;

        //public string LTKDaBaoCao
        //{
        //    get { return _LTKDaBaoCao; }
        //    set { _LTKDaBaoCao = value; OnPropertyChanged(); }
        //}
        ////------------
        //private ListBaoCaoDongMo_DaBaoCao _SelectedMonth;

        //public ListBaoCaoDongMo_DaBaoCao SelectedMonth
        //{
        //    get { return _SelectedMonth; }
        //    set { _SelectedMonth = value; OnPropertyChanged(); }
        //}

        //// notify
        //private bool _DialogOpen;
        //public bool DialogOpen
        //{
        //    get => _DialogOpen;
        //    set { _DialogOpen = value; OnPropertyChanged(); }
        //}

        //private string _NotifyDialog;
        //public string NotifyDialog
        //{
        //    get => _NotifyDialog;
        //    set { _NotifyDialog = value; OnPropertyChanged(); }
        //}

        //#endregion
        //#region function
        //#region Code NgayThangNam
        //private bool isCheck(int nam)
        //{
        //    return ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0);
        //}

        //private int Daysinmonth(int thang, int nam)
        //{
        //    switch (thang)
        //    {
        //        case 1:
        //        case 3:
        //        case 5:
        //        case 7:
        //        case 8:
        //        case 10:
        //        case 12:
        //            return 31;
        //        case 4:
        //        case 6:
        //        case 9:
        //        case 11:
        //            return 30;
        //        case 2:
        //            if (isCheck(nam))
        //                return 29;
        //            else
        //                return 28;
        //        default: return 0;
        //    }
        //}

        //private string FormatBaoCao(string mbc)
        //{
        //    string tmp = mbc;
        //    for (int i = 1; i <= 7 - mbc.Length; i++)
        //    {
        //        tmp = "0" + tmp;
        //    }
        //    return tmp;
        //}
        //#endregion
        //private string CreateThangNam(string thang, string nam)
        //{
        //    string res = thang + "-" + nam;
        //    if (int.Parse(thang) < 10) res = "0" + res;
        //    return res;
        //}
        //private void BindingListDaBaoCao()
        //{
        //    ListDaBaoCao = new ObservableCollection<ListBaoCaoDongMo_DaBaoCao>();
        //    ObservableCollection<LOAITIETKIEM> LTK = new ObservableCollection<LOAITIETKIEM>(DataProvider.Ins.DB.LOAITIETKIEMs);
        //    ObservableCollection<BAOCAOMODONG> BCMD = new ObservableCollection<BAOCAOMODONG>(DataProvider.Ins.DB.BAOCAOMODONGs);

        //    var baocao = from bcmd in BCMD
        //                 join ltk in LTK on bcmd.MaLoaiTietKiem equals ltk.MaLoaiTietKiem
        //                 orderby bcmd.NamBaoCao descending, bcmd.ThangBaoCao descending, ltk.TenLoaiTietKiem ascending
        //                 select new ListBaoCaoDongMo_DaBaoCao(CreateThangNam(bcmd.ThangBaoCao.ToString(), bcmd.NamBaoCao.ToString()), ltk.TenLoaiTietKiem);

        //    foreach (var bc in baocao)
        //        ListDaBaoCao.Add(bc);
        //}
        //private string GetCodeMBCMD()
        //{
        //    ObservableCollection<BAOCAOMODONG> List_BCMD = new ObservableCollection<BAOCAOMODONG>(DataProvider.Ins.DB.BAOCAOMODONGs);
        //    int tmp = List_BCMD.Count();
        //    return "BCDM" + FormatBaoCao((tmp + 1).ToString());
        //}

        //private void BindingListThang(int ThangToiDa)
        //{
        //    List_Thang = new ObservableCollection<string>();


        //    string formatThang = "Tháng";

        //    for (int i = 1; i <= ThangToiDa; i++)
        //    {
        //        string month = i.ToString();
        //        if (i < 10) month = '0' + month;
        //        string temp = formatThang + ' ' + month;
        //        List_Thang.Add(temp);
        //    }

        //}
        //private void CheckValid()
        //{
        //    if (Selected_LTK == null || Selected_LTK == "")
        //        Notify_LTK = "Visible";
        //    else Notify_LTK = "Hidden";
        //    if (Selected_Thang == null || Selected_Thang == "")
        //        Notify_Month = "Visible";
        //    else Notify_Month = "Hidden";
        //    if (Selected_Nam == null || Selected_Nam == "")
        //        Notify_Year = "Visible";
        //    else Notify_Year = "Hidden";
        //}
        //#endregion
        //public ICommand SelectedYear_ChangedCommand { get; set; }
        //public ICommand CreateReportCommand { get; set; }
        //public ICommand SelectedMonthYear_Command { get; set; }
        //public ICommand ExportReportCommand { get; set; }
        //public BaoCaoTonKho_ViewModel()
        //{

        //    DialogOpen = false;
        //    NotifyDialog = "";

        //    BindingListDaBaoCao();

        //    //Binding LoaiTietKiem_CBB

        //    //Hiển thị loại tiết kiệm DangSuDung = 1 ____ by Sanh
        //    ObservableCollection<LOAITIETKIEM> LTK = new ObservableCollection<LOAITIETKIEM>(DataProvider.Ins.DB.LOAITIETKIEMs);
        //    List_LTK = new ObservableCollection<string>();
        //    foreach (LOAITIETKIEM temp in LTK)
        //        if (temp.DangSuDung == "Có")
        //            List_LTK.Add(temp.TenLoaiTietKiem);

        //    //Binding List_Nam
        //    List_Nam = new ObservableCollection<string>();
        //    DateTime tempNam = DateTime.Today;
        //    string nowYear = tempNam.Year.ToString();
        //    for (int i = 1990; i <= int.Parse(nowYear); i++)
        //    {
        //        List_Nam.Add(i.ToString());
        //    }


        //    //Binding List_Thang_CBB
        //    string Nam = DateTime.Now.Year.ToString();
        //    int NgayHomNay = int.Parse(DateTime.Now.Day.ToString());
        //    int ThangToiDa = int.Parse(DateTime.Now.Month.ToString());

        //    if (NgayHomNay != Daysinmonth(ThangToiDa, int.Parse(Nam)))
        //        ThangToiDa--;
        //    BindingListThang(ThangToiDa);
        //    //set auto Selected CBB
        //    string tempT = ThangToiDa.ToString();
        //    if (int.Parse(tempT) < 10) tempT = "0" + tempT;
        //    Selected_Thang = "Tháng " + tempT;
        //    Selected_Nam = DateTime.Now.Year.ToString();
        //    Selected_LTK = List_LTK[0];
        //    EnableCreate = false;
        //    CheckValid();
        //    //Binding Ngay thang
        //    SelectedYear_ChangedCommand = new RelayCommand<object>((p) =>
        //    {
        //        return true;
        //    },
        //     (p) =>
        //     {
        //         try
        //         {
        //             if (Selected_Nam == Nam)
        //             {
        //                 BindingListThang(ThangToiDa);

        //             }
        //             else if (int.Parse(Selected_Nam) < int.Parse(Nam))
        //             {
        //                 BindingListThang(12);

        //             }
        //         }
        //         catch (Exception e)
        //         {

        //         }
        //     });

        //    //Binding Selected Item
        //    SelectedMonthYear_Command = new RelayCommand<object>((p) =>
        //    {
        //        return true;
        //    },
        //   (p) =>
        //   {

        //       if (SelectedMonth != null)
        //       {
        //           EnableCreate = true;

        //           ObservableCollection<SOTIETKIEM> stk = new ObservableCollection<SOTIETKIEM>(DataProvider.Ins.DB.SOTIETKIEMs);
        //           ObservableCollection<LOAITIETKIEM> ltk = new ObservableCollection<LOAITIETKIEM>(DataProvider.Ins.DB.LOAITIETKIEMs);
        //           ObservableCollection<BAOCAOMODONG> BCMD = new ObservableCollection<BAOCAOMODONG>(DataProvider.Ins.DB.BAOCAOMODONGs);

        //           string ThangChon = SelectedMonth.ThangNamDaBaoCao.Substring(0, 2);
        //           string NamChon = SelectedMonth.ThangNamDaBaoCao.Substring(3, 4);
        //           int NgayToiDaThang = Daysinmonth(int.Parse(ThangChon), int.Parse(NamChon));

        //           ListBaoCaoDM = new ObservableCollection<ListBaoCaoDongMo>();
        //           string maltk = "";
        //           foreach (var _ltk in ltk)
        //               if (_ltk.TenLoaiTietKiem == SelectedMonth.LTKDaBaoCao)
        //                   maltk = _ltk.MaLoaiTietKiem;
        //           //binding list_thang
        //           if (Selected_Nam == Nam)
        //           {
        //               BindingListThang(ThangToiDa);

        //           }
        //           else if (int.Parse(Selected_Nam) < int.Parse(Nam))
        //           {
        //               BindingListThang(12);

        //           }

        //           //Binding CBB
        //           Selected_LTK = SelectedMonth.LTKDaBaoCao;
        //           Selected_Thang = "Tháng " + SelectedMonth.ThangNamDaBaoCao.Substring(0, 2);
        //           Selected_Nam = SelectedMonth.ThangNamDaBaoCao.Substring(3, 4);


        //           // BInding to PrintPreview
        //           ThangBaoCao_BD = ThangChon;
        //           NamBaoCao_BD = NamChon;
        //           LoaiTietKiem_BD = SelectedMonth.LTKDaBaoCao;
        //           foreach (var bc in BCMD)
        //               if (bc.NamBaoCao.ToString() == NamChon && maltk == bc.MaLoaiTietKiem && bc.ThangBaoCao.ToString() == ThangChon.Substring(1, 1))
        //                   MaBaoCao = bc.MaBaoCaoMoDong;
        //           //
        //           for (int date = 1; date <= NgayToiDaThang; date++)
        //           {
        //               string tempNgay = date.ToString();
        //               string SoTT = date.ToString();
        //               if ((date >= 1) && date <= 9) tempNgay = '0' + tempNgay;
        //               string ngaykt = tempNgay + '/' + ThangChon + "/" + NamChon;
        //               int SLSoMo = 0, SLSoDong = 0;
        //               foreach (var _stk in stk)
        //               {
        //                   string ngaymo = _stk.NgayMoSo.ToString("dd/MM/yyyy");
        //                   string ngaydong = _stk.NgayDongSo?.ToString("dd/MM/yyyy");
        //                   if (_stk.MaLoaiTietKiem == maltk && ngaymo == ngaykt)
        //                       SLSoMo++;
        //                   if (_stk.MaLoaiTietKiem == maltk && ngaydong == ngaykt)
        //                       SLSoDong++;
        //               }
        //               //add ListBaoCao
        //               ListBaoCaoDM.Add(new ListBaoCaoDongMo
        //               (
        //                   STT = SoTT,
        //                   Ngay = ngaykt,
        //                   SoMo = SLSoMo.ToString(),
        //                   SoDong = SLSoDong.ToString(),
        //                   ChenhLech = Math.Abs(SLSoMo - SLSoDong).ToString()
        //               ));
        //           }
        //           //NotifyDialog = "Lấy báo cáo thành công";
        //           //DialogOpen = true;
        //       }


        //   });
        //    //Binding ListBaoCao
        //    CreateReportCommand = new RelayCommand<object>((p) =>
        //    {
        //        return true;
        //    },
        //    (p) =>
        //    {
        //        try
        //        {
        //            CheckValid();
        //            if (Notify_LTK == "Hidden" && Notify_Month == Notify_LTK && Notify_Year == Notify_Month)
        //            {
        //                EnableCreate = true;
        //                ObservableCollection<SOTIETKIEM> stk = new ObservableCollection<SOTIETKIEM>(DataProvider.Ins.DB.SOTIETKIEMs);
        //                ObservableCollection<LOAITIETKIEM> ltk = new ObservableCollection<LOAITIETKIEM>(DataProvider.Ins.DB.LOAITIETKIEMs);
        //                ObservableCollection<BAOCAOMODONG> bcmd = new ObservableCollection<BAOCAOMODONG>(DataProvider.Ins.DB.BAOCAOMODONGs);


        //                string mabaocao = GetCodeMBCMD();
        //                int thangdangchon = int.Parse(Selected_Thang.Substring(6, 2));

        //                int namdangchon = int.Parse(Selected_Nam);

        //                string thangdangchon_st = thangdangchon.ToString();
        //                if (thangdangchon < 10)
        //                    thangdangchon_st = "0" + thangdangchon_st;
        //                int NgayToiDaThang = Daysinmonth(thangdangchon, namdangchon);
        //                ListBaoCaoDM = new ObservableCollection<ListBaoCaoDongMo>();
        //                string maltk = "";
        //                foreach (var _ltk in ltk)
        //                    if (_ltk.TenLoaiTietKiem == Selected_LTK)
        //                        maltk = _ltk.MaLoaiTietKiem;
        //                //Binding to PrintPreview
        //                ThangBaoCao_BD = thangdangchon.ToString();
        //                NamBaoCao_BD = namdangchon.ToString();
        //                LoaiTietKiem_BD = Selected_LTK;
        //                MaBaoCao = mabaocao;

        //                //Check already create
        //                bool CanAdd = true;
        //                foreach (var _bcmd in bcmd)
        //                    if (_bcmd.MaLoaiTietKiem == maltk &&
        //                       _bcmd.ThangBaoCao == thangdangchon &&
        //                       _bcmd.NamBaoCao == namdangchon
        //                      )
        //                    {
        //                        CanAdd = false;
        //                        NotifyDialog = "Lấy báo cáo thành công";
        //                    }
        //                if (CanAdd == true)
        //                {
        //                    BAOCAOMODONG baocaoMD = new BAOCAOMODONG()
        //                    {
        //                        MaBaoCaoMoDong = mabaocao,
        //                        MaLoaiTietKiem = maltk,
        //                        ThangBaoCao = thangdangchon,
        //                        NamBaoCao = namdangchon
        //                    };
        //                    DataProvider.Ins.DB.BAOCAOMODONGs.Add(baocaoMD);
        //                    DataProvider.Ins.DB.SaveChanges();
        //                }
        //                //Binding List


        //                for (int date = 1; date <= NgayToiDaThang; date++)
        //                {
        //                    string tempNgay = date.ToString();
        //                    string SoTT = date.ToString();
        //                    if ((date >= 1) && date <= 9) tempNgay = '0' + tempNgay;
        //                    string ngaykt = tempNgay + '/' + thangdangchon_st + "/" + namdangchon.ToString();
        //                    int SLSoMo = 0, SLSoDong = 0;
        //                    foreach (var _stk in stk)
        //                    {
        //                        string ngaymo = _stk.NgayMoSo.ToString("dd/MM/yyyy");
        //                        string ngaydong = _stk.NgayDongSo?.ToString("dd/MM/yyyy");
        //                        if (_stk.MaLoaiTietKiem == maltk && ngaymo == ngaykt)
        //                            SLSoMo++;
        //                        if (_stk.MaLoaiTietKiem == maltk && (ngaydong == ngaykt || _stk.NgayDongSo != null))
        //                            SLSoDong++;
        //                    }

        //                    //add ListBaoCao
        //                    ListBaoCaoDM.Add(new ListBaoCaoDongMo
        //                   (
        //                       STT = SoTT,
        //                       Ngay = ngaykt,
        //                       SoMo = SLSoMo.ToString(),
        //                       SoDong = SLSoDong.ToString(),
        //                       ChenhLech = Math.Abs(SLSoMo - SLSoDong).ToString()
        //                   ));



        //                    //Add Database
        //                    if (CanAdd == true)
        //                    {
        //                        CTBCMODONG baocao = new CTBCMODONG()
        //                        {
        //                            MaBaoCaoMoDong = mabaocao,
        //                            NgayXet = DateTime.ParseExact(ngaykt, "dd/MM/yyyy",
        //                                           CultureInfo.InvariantCulture),
        //                            SoLuongSoMo = SLSoMo,
        //                            SoLuongSoDong = SLSoDong,
        //                            ChenhLech = Math.Abs(SLSoMo - SLSoDong)
        //                        };
        //                        DataProvider.Ins.DB.CTBCMODONGs.Add(baocao);

        //                        DataProvider.Ins.DB.SaveChanges();

        //                    }
        //                }

        //                BindingListDaBaoCao();

        //                if (CanAdd)
        //                    NotifyDialog = "Tạo báo cáo thành công";
        //                DialogOpen = true;

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            return;
        //        }
        //    });
        //    // Create PrintPreview
        //    ExportReportCommand = new RelayCommand<object>((p) =>
        //    {
        //        return true;
        //    },
        //   (p) =>
        //   {
        //       BaoCaoTonKho_PrintPreview_ViewModel BaoCaoMoDongPPVM = new BaoCaoTonKho_PrintPreview_ViewModel(MaBaoCao, ThangBaoCao_BD, NamBaoCao_BD, LoaiTietKiem_BD, ListBaoCaoDM);
        //       BaoCaoTonKho_PrintPreview BaoCao = new BaoCaoTonKho_PrintPreview(BaoCaoMoDongPPVM);
        //       BaoCao.ShowDialog();
        //       isLoaded = true;
        //   });

        //}

        #endregion

        // new code from this
        public ICommand StartDateChangedCommand { get; set; }
        public ICommand EndDateChangedCommand { get; set; }
        public ICommand YearChangedCommand { get; set; }
        public ICommand CheDoXemChangedCommand { get; set; }
        public ICommand PrintCommand { get; set; }
        private DateTime _SelectedStartDate;
        public DateTime SelectedStartDate { get => _SelectedStartDate; set { _SelectedStartDate = value; OnPropertyChanged(); } }
        private DateTime _SelectedEndDate;
        public DateTime SelectedEndDate { get => _SelectedEndDate; set { _SelectedEndDate = value; OnPropertyChanged(); } }

        private Visibility _VisibilityDatePickerPopup;
        public Visibility VisibilityDatePickerPopup { get => _VisibilityDatePickerPopup; set { _VisibilityDatePickerPopup = value; OnPropertyChanged(); } }
        private string _PopupContent;
        public string PopupContent { get => _PopupContent; set { _PopupContent = value; OnPropertyChanged(); } }
        private ObservableCollection<string> _ListCheDoXem;
        public ObservableCollection<string> ListCheDoXem { get => _ListCheDoXem; set { _ListCheDoXem = value; OnPropertyChanged(); } }
        private string _SelectedCheDoXem;
        public string SelectedCheDoXem { get => _SelectedCheDoXem; set { _SelectedCheDoXem = value; OnPropertyChanged(); } }
        private Visibility _VisibilityChonNam;
        public Visibility VisibilityChonNam { get => _VisibilityChonNam; set { _VisibilityChonNam = value; OnPropertyChanged(); } }
        private Visibility _VisibilityTuNgayDenNgay;
        public Visibility VisibilityTuNgayDenNgay { get => _VisibilityTuNgayDenNgay; set { _VisibilityTuNgayDenNgay = value; OnPropertyChanged(); } }
        private Visibility _VisibilityChart;
        public Visibility VisibilityChart { get => _VisibilityChart; set { _VisibilityChart = value; OnPropertyChanged(); } }

        private Visibility _VisibilityBang;
        public Visibility VisibilityBang { get => _VisibilityBang; set { _VisibilityBang = value; OnPropertyChanged(); } }
        private string _YearHeader;
        public string YearHeader { get => _YearHeader; set { _YearHeader = value; OnPropertyChanged(); } }
        private string _TomTatTon;
        public string TomTatTon { get => _TomTatTon; set { _TomTatTon = value; OnPropertyChanged(); } }
        private int _Maximum;
        public int Maximum { get => _Maximum; set { _Maximum = value; OnPropertyChanged(); } }
        private ObservableCollection<DiemBieuDoTonKho> _ChartData;
        public ObservableCollection<DiemBieuDoTonKho> ChartData
        {
            get => _ChartData;
            set { _ChartData = value; OnPropertyChanged(); }
        }
        private ObservableCollection<int> _ListYear;
        public ObservableCollection<int> ListYear { get => _ListYear; set { _ListYear = value; OnPropertyChanged(); } }
        private int _SelectedYear;
        public int SelectedYear { get => _SelectedYear; set { _SelectedYear = value; OnPropertyChanged(); } }
        public BaoCaoTonKho_ViewModel()
        {
            ListCheDoXem = new ObservableCollection<string>();
            ListCheDoXem.Add("Bảng");
            ListCheDoXem.Add("Biểu đồ cột");
            SelectedCheDoXem = "Bảng";
            showTableView();
            StartDateChangedCommand = new RelayCommand<object>((p) => { return true; },
            (p) =>
            {
                if (SelectedStartDate > SelectedEndDate)
                {
                    BaoCaoTonKho = new ObservableCollection<DongBaoCaoTonKho>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Ngày bắt đầu không được lớn hơn ngày kết thúc.";
                }
                else if (SelectedStartDate >= DateTime.Today || SelectedEndDate >= DateTime.Today)
                {
                    BaoCaoTonKho = new ObservableCollection<DongBaoCaoTonKho>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Phạm vi báo cáo phải từ quá khứ đến trước ngày hiện tại";
                }
                else if (SelectedStartDate.Year < 1900 || SelectedEndDate.Year < 1900)
                {
                    BaoCaoTonKho = new ObservableCollection<DongBaoCaoTonKho>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Năm được chọn phải sau thế kỷ thứ 18";
                }
                else

                    LoadData();
            });
            EndDateChangedCommand = new RelayCommand<object>((p) => { return true; },
            (p) =>
            {
                if (SelectedStartDate > SelectedEndDate)
                {
                    BaoCaoTonKho = new ObservableCollection<DongBaoCaoTonKho>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Ngày bắt đầu không được lớn hơn ngày kết thúc.";
                }
                else if (SelectedStartDate >= DateTime.Today || SelectedEndDate >= DateTime.Today)
                {
                    BaoCaoTonKho = new ObservableCollection<DongBaoCaoTonKho>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Phạm vi báo cáo phải từ quá khứ đến trước ngày hiện tại";
                }
                else if (SelectedStartDate.Year < 1900 || SelectedEndDate.Year < 1900)
                {
                    BaoCaoTonKho = new ObservableCollection<DongBaoCaoTonKho>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Năm được chọn phải sau thế kỷ thứ 18";
                }
                else
                    LoadData();
            });
            YearChangedCommand = new RelayCommand<object>((p) => { return true; },
            (p) =>
            {
                LoadChart();
            });
            CheDoXemChangedCommand = new RelayCommand<object>((p) => { return true; },
            (p) =>
            {
                if (SelectedCheDoXem == "Bảng")
                {
                    showTableView();
                }
                if (SelectedCheDoXem == "Biểu đồ cột")
                {
                    showChartView();
                }
            });
            PrintCommand = new RelayCommand<object>((q) =>
            {
                if (BaoCaoTonKho.Count == 0)
                    return false;
                return true;
            },
    (q) =>
    {
        BaoCaoTonKho_PrintPreview_ViewModel printPreviewBaoCaoTonKho = new BaoCaoTonKho_PrintPreview_ViewModel(BaoCaoTonKho, SelectedStartDate, SelectedEndDate, "*insert nguoi tao here");
        BaoCaoTonKho_PrintPreview PrintPreviewWindow = new BaoCaoTonKho_PrintPreview(printPreviewBaoCaoTonKho);
        PrintPreviewWindow.ShowDialog();
    }
);
        }

        private ObservableCollection<DongBaoCaoTonKho> _BaoCaoTonKho;
        public ObservableCollection<DongBaoCaoTonKho> BaoCaoTonKho
        {
            get => _BaoCaoTonKho;
            set { _BaoCaoTonKho = value; OnPropertyChanged(); }
        }

        void LoadChart()
        {
            ChartData = new ObservableCollection<DiemBieuDoTonKho>();
            YearHeader = "Năm " + SelectedYear.ToString();
            Maximum = 0;
            for (int i = 1; i < 13; i++)
            {
                DiemBieuDoTonKho diembieudotonkho = new DiemBieuDoTonKho();
                diembieudotonkho.Month = "Tháng " + i.ToString();
                var ThongKeNgay = new ObservableCollection<THONGKENGAY>(DataProvider.Ins.DB.THONGKENGAYs);
                var ChiTiet = new ObservableCollection<CT_THONGKENGAY>(DataProvider.Ins.DB.CT_THONGKENGAY);
                var MatHang = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);
                var DataQuery = from ct in ChiTiet
                                join tkn in ThongKeNgay on ct.MaThongKe equals tkn.MaThongKe
                                where (tkn.Ngay.Month == i && tkn.Ngay.Year==SelectedYear)
                                select new { ct.MaMH, ct.Nhap, ct.Xuat, ct.Ton };
                var GroupedDataQuery = DataQuery
                    .GroupBy(x => x.MaMH)
                    .Select(g => new
                    {
                        MaMH = g.Key,
                        Nhap = g.Sum(x => x.Nhap),
                        Xuat = g.Sum(x => x.Xuat),
                    });
                diembieudotonkho.Nhap = DataQuery.Sum(x => x.Nhap);
                diembieudotonkho.Xuat = DataQuery.Sum(x => x.Xuat);
                int TonCuoiThang = 0;
                foreach (var item in GroupedDataQuery)
                {
                    var toncuoithang = (from ct in ChiTiet
                                        join tkn in ThongKeNgay on ct.MaThongKe equals tkn.MaThongKe
                                        where (tkn.Ngay.Month == i && item.MaMH == ct.MaMH)
                                        select ct);
                    if (toncuoithang.Count() > 0)
                        TonCuoiThang += toncuoithang.Last().Ton;
                }
                diembieudotonkho.Ton = TonCuoiThang;
                if (diembieudotonkho.Nhap > Maximum)
                    Maximum = diembieudotonkho.Nhap;
                if (diembieudotonkho.Xuat > Maximum)
                    Maximum = diembieudotonkho.Xuat;
                if (TonCuoiThang > Maximum)
                    Maximum = TonCuoiThang;
                ChartData.Add(diembieudotonkho);
            }
            Maximum += 10;
        }
        void LoadData()
        {
            VisibilityDatePickerPopup = Visibility.Hidden;
            var ThongKeNgay = new ObservableCollection<THONGKENGAY>(DataProvider.Ins.DB.THONGKENGAYs);
            var ChiTiet = new ObservableCollection<CT_THONGKENGAY>(DataProvider.Ins.DB.CT_THONGKENGAY);
            var MatHang = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);
            var DataQuery = from ct in ChiTiet
                            join tkn in ThongKeNgay on ct.MaThongKe equals tkn.MaThongKe
                            where (tkn.Ngay >= SelectedStartDate && tkn.Ngay <= SelectedEndDate)
                            select new { ct.MaMH, ct.Nhap, ct.Xuat, ct.Ton };
            var GroupedDataQuery = DataQuery
                .GroupBy(x => x.MaMH)
                .Select(g => new
                {
                    MaMH = g.Key,
                    Nhap = g.Sum(x => x.Nhap),
                    Xuat = g.Sum(x => x.Xuat),
                });
            var ExtendedDataQuery = from gdq in GroupedDataQuery
                                    join mh in MatHang on gdq.MaMH equals mh.MaMH
                                    select new
                                    {
                                        gdq.MaMH,
                                        mh.TenMH,
                                        gdq.Nhap,
                                        gdq.Xuat,
                                    };
            BaoCaoTonKho = new ObservableCollection<DongBaoCaoTonKho>();
            int i = 1;
            foreach (var item in ExtendedDataQuery)
            {
                DongBaoCaoTonKho dongbaocao = new DongBaoCaoTonKho();
                dongbaocao.STT = i++;
                dongbaocao.MaMH = item.MaMH;
                dongbaocao.TenHang = item.TenMH;
                int tondauki = 0;
                int cotondauki = (from ct in ChiTiet
                                  join tkn in ThongKeNgay on ct.MaThongKe equals tkn.MaThongKe
                                  where (tkn.Ngay == SelectedStartDate.AddDays(-1) && item.MaMH == ct.MaMH)
                                  select ct).Count();
                if (cotondauki > 0)
                {
                    tondauki = (from ct in ChiTiet
                                join tkn in ThongKeNgay on ct.MaThongKe equals tkn.MaThongKe
                                where (tkn.Ngay == SelectedStartDate.AddDays(-1) && item.MaMH == ct.MaMH)
                                select ct).First().Ton;
                }
                dongbaocao.TonDauKi = tondauki;
                dongbaocao.Nhap = item.Nhap;
                dongbaocao.Xuat = item.Xuat;
                int toncuoiki = 0;
                int cotoncuoiki = (from ct in ChiTiet
                                   join tkn in ThongKeNgay on ct.MaThongKe equals tkn.MaThongKe
                                   where (tkn.Ngay == SelectedEndDate && item.MaMH == ct.MaMH)
                                   select ct).Count();
                if (cotoncuoiki > 0)
                {
                    toncuoiki = (from ct in ChiTiet
                                 join tkn in ThongKeNgay on ct.MaThongKe equals tkn.MaThongKe
                                 where (tkn.Ngay == SelectedEndDate && item.MaMH == ct.MaMH)
                                 select ct).First().Ton;
                }
                dongbaocao.TonCuoiKi = toncuoiki;
                BaoCaoTonKho.Add(dongbaocao);
            }
        }
        void showTableView()
        {
            VisibilityChonNam = Visibility.Hidden;
            VisibilityTuNgayDenNgay = Visibility.Visible;
            VisibilityChart = Visibility.Hidden;
            VisibilityBang = Visibility.Visible;
            VisibilityDatePickerPopup = Visibility.Hidden;
            SelectedStartDate = DateTime.Today.AddDays(-1);
            SelectedEndDate = DateTime.Today.AddDays(-1);
            LoadData();
        }

        void showChartView()
        {
            VisibilityTuNgayDenNgay = Visibility.Hidden;
            VisibilityChonNam = Visibility.Visible;
            ListYear = new ObservableCollection<int>();
            VisibilityBang = Visibility.Hidden;
            VisibilityChart = Visibility.Visible;
            for (int i = 4; i >= 0; i--)
            {
                ListYear.Add(DateTime.Today.Year - i);
            }
            SelectedYear = DateTime.Today.Year;
            LoadChart();
        }
 
    }
    public class DongBaoCaoTonKho
    {
        public int STT { get; set; }
        public string MaMH { get; set; }
        public string TenHang { get; set; }
        public int TonDauKi { get; set; }
        public int Nhap { get; set; }
        public int Xuat { get; set; }
        public int TonCuoiKi { get; set; }

    }
    public class DiemBieuDoTonKho
    {
        public string Month { get; set; }
        public int Nhap { get; set; }
        public int Xuat { get; set; }
        public int Ton { get; set; }
    }
}