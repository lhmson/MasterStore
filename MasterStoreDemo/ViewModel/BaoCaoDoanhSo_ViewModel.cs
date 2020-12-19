using MasterStoreDemo.Model;
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
using System.Windows.Data;
using System.Globalization;

namespace MasterStoreDemo.ViewModel
{
  


    public class BaoCaoDoanhSo_ViewModel : BaseViewModel
    {


        #region Old code
            // /*
            // Format của list BCDS để hiển thị lúc lấy từ database lên khác với format lúc tạo (0 khác 0.0000)
            //     */
            //    #region Variables
            //    public bool isLoaded = false;

            //    // date chosen for reporting
            //    private DateTime _SelectedDateReport;
            //    public DateTime SelectedDateReport
            //    {
            //        get => _SelectedDateReport;
            //        set { _SelectedDateReport = value; OnPropertyChanged(); }
            //    }
            //    // date chosen for displaying
            //    private DateTime _SelectedDateReportDisplay;
            //    public DateTime SelectedDateReportDisplay
            //    {
            //        get => _SelectedDateReportDisplay;
            //        set { _SelectedDateReportDisplay = value; OnPropertyChanged(); }
            //    }
            //    // list of BAOCAODOANHSOes in the date chosen
            //    private ObservableCollection<BAOCAODOANHSO> _ListBaoCaoDoanhSo;
            //    public ObservableCollection<BAOCAODOANHSO> ListBaoCaoDoanhSo
            //    {
            //        get => _ListBaoCaoDoanhSo;
            //        set { _ListBaoCaoDoanhSo = value; OnPropertyChanged(); }
            //    }
            //    // 
            //    private ObservableCollection<DateTime> _ListNgayBaoCao;
            //    public ObservableCollection<DateTime> ListNgayBaoCao
            //    {
            //        get => _ListNgayBaoCao;
            //        set { _ListNgayBaoCao = value; OnPropertyChanged(); }
            //    }
            //    // list of BAOCAODOANHSOes in the date chosen for display
            //    private ObservableCollection<BaoCaoDS> _ListBaoCaoDisplay;
            //    public ObservableCollection<BaoCaoDS> ListBaoCaoDisplay
            //    {
            //        get => _ListBaoCaoDisplay;
            //        set { _ListBaoCaoDisplay = value; OnPropertyChanged(); }
            //    }
            //    // list Loaitietkiem
            //    private ObservableCollection<LOAITIETKIEM> _ListLTK;
            //    public ObservableCollection<LOAITIETKIEM> ListLTK
            //    {
            //        get => _ListLTK;
            //        set { _ListLTK = value; OnPropertyChanged(); }
            //    }
            //    // list Phieugui
            //    private ObservableCollection<PHIEUGUI> _ListPhieuGui;
            //    public ObservableCollection<PHIEUGUI> ListPhieuGui
            //    {
            //        get => _ListPhieuGui;
            //        set { _ListPhieuGui = value; OnPropertyChanged(); }
            //    }
            //    // list Phieurut
            //    private ObservableCollection<PHIEURUT> _ListPhieuRut;
            //    public ObservableCollection<PHIEURUT> ListPhieuRut
            //    {
            //        get => _ListPhieuRut;
            //        set { _ListPhieuRut = value; OnPropertyChanged(); }
            //    }
            //    // list Sotietkiem
            //    private ObservableCollection<SOTIETKIEM> _ListSTK;
            //    public ObservableCollection<SOTIETKIEM> ListSTK
            //    {
            //        get => _ListSTK;
            //        set { _ListSTK = value; OnPropertyChanged(); }
            //    }
            //    //TenLoaiTietKiem
            //    private string _TenLoaiTietKiem;
            //    public string TenLoaiTietKiem
            //    {
            //        get => _TenLoaiTietKiem;
            //        set { _TenLoaiTietKiem = value; OnPropertyChanged(); }
            //    }
            //    //So Thu Tu  
            //    private int _SoThuTu;
            //    public int SoThuTu
            //    {
            //        get => _SoThuTu;
            //        set { _SoThuTu = value; OnPropertyChanged(); }
            //    }
            //    // tong thu
            //    private decimal _TongThu;
            //    public decimal TongThu
            //    {
            //        get => _TongThu;
            //        set { _TongThu = value; OnPropertyChanged(); }
            //    }
            //    // tong chi
            //    private decimal _TongChi;
            //    public decimal TongChi
            //    {
            //        get => _TongChi;
            //        set { _TongChi = value; OnPropertyChanged(); }
            //    }
            //    // chenh lech thu chi
            //    private decimal _ChenhLech;
            //    public decimal ChenhLech
            //    {
            //        get => _ChenhLech;
            //        set { _ChenhLech = value; OnPropertyChanged(); }
            //    }
            //    //
            //    private string _FormattedDate;
            //    public string FormattedDate
            //    {
            //        get => _FormattedDate;
            //        set { _FormattedDate = value; OnPropertyChanged(); }
            //    }

            //    //
            //    private FlowDocument _FlowDoc;
            //    public FlowDocument FlowDoc
            //    {
            //        get => _FlowDoc;
            //        set { _FlowDoc = value; OnPropertyChanged(); }
            //    }

            //    //
            //    private Visibility _VisibilityDatePickerPopup;
            //    public Visibility VisibilityDatePickerPopup
            //    {
            //        get => _VisibilityDatePickerPopup;
            //        set { _VisibilityDatePickerPopup = value; OnPropertyChanged(); }
            //    }

            //    private bool _DialogOpen;
            //    public bool DialogOpen
            //    {
            //        get => _DialogOpen;
            //        set { _DialogOpen = value; OnPropertyChanged(); }
            //    }

            //    private string _Notify;
            //    public string Notify
            //    {
            //        get => _Notify;
            //        set { _Notify = value; OnPropertyChanged(); }
            //    }

            //    private string _PopupContent;
            //    public string PopupContent
            //    {
            //        get => _PopupContent;
            //        set { _PopupContent = value; OnPropertyChanged(); }
            //    }
            //    #endregion

            //    #region Function
            //    private void LoadData()
            //    {
            //        VisibilityDatePickerPopup = Visibility.Hidden;

            //        var listLTK_Using = DataProvider.Ins.DB.LOAITIETKIEMs.Where(x => x.DangSuDung == "Có");
            //        ListLTK = new ObservableCollection<LOAITIETKIEM>(listLTK_Using);

            //        ListSTK = new ObservableCollection<SOTIETKIEM>(DataProvider.Ins.DB.SOTIETKIEMs);
            //        ListPhieuGui = new ObservableCollection<PHIEUGUI>(DataProvider.Ins.DB.PHIEUGUIs);
            //        ListPhieuRut = new ObservableCollection<PHIEURUT>(DataProvider.Ins.DB.PHIEURUTs);
            //        ListBaoCaoDoanhSo = new ObservableCollection<BAOCAODOANHSO>(DataProvider.Ins.DB.BAOCAODOANHSOes);
            //        ListBaoCaoDisplay = new ObservableCollection<BaoCaoDS>();

            //        var listNgay = (from bc in ListBaoCaoDoanhSo
            //                        orderby bc.NgayDoanhSo descending
            //                        select bc.NgayDoanhSo).Distinct();
            //        ListNgayBaoCao = new ObservableCollection<DateTime>(listNgay);

            //        SelectedDateReport = DateTime.Today;
            //    }

            //    private BAOCAODOANHSO FindBaoCao(LOAITIETKIEM ltk)
            //    {
            //        var baoCao = (from bc in ListBaoCaoDoanhSo
            //                      where bc.MaLoaiTietKiem == ltk.MaLoaiTietKiem && bc.NgayDoanhSo == SelectedDateReport
            //                      select bc).SingleOrDefault();
            //        return baoCao;
            //    }
            //    public string Create_MaBCDS(int stt)
            //    {
            //        string res = "BCDS";
            //        for (int i = 5; i <= 11 - stt.ToString().Length; i++)
            //            res += '0';
            //        res += stt.ToString();
            //        return res;
            //    }
            //    private void GetBaoCaoToDisplay(int i, LOAITIETKIEM ltk, BAOCAODOANHSO baoCao)
            //    {
            //        SoThuTu = i + 1;
            //        TenLoaiTietKiem = ltk.TenLoaiTietKiem;
            //        TongThu += baoCao.TongThu;
            //        TongChi += baoCao.TongChi;
            //        ChenhLech = baoCao.ChenhLech;

            //        BaoCaoDS baoCaoDisplay = new BaoCaoDS(SoThuTu, TenLoaiTietKiem, TongThu, TongChi, ChenhLech);
            //        ListBaoCaoDisplay.Add(baoCaoDisplay);
            //    }
            //    private BAOCAODOANHSO CreateBaoCao(int i, LOAITIETKIEM ltk)
            //    {
            //        SoThuTu = i + 1;
            //        TenLoaiTietKiem = ltk.TenLoaiTietKiem;

            //        int index = ListBaoCaoDoanhSo.Count() + 1;
            //        string maBaoCao = Create_MaBCDS(index);
            //        string maLoai = ltk.MaLoaiTietKiem;
            //        var soMoToday = ListSTK.Where(x => x.NgayMoSo.Date == DateTime.Today && x.MaLoaiTietKiem == ltk.MaLoaiTietKiem).ToList();

            //        foreach (var temp in soMoToday)
            //        {
            //            TongThu += temp.SoTienGuiBanDau;
            //        }

            //        var listThu = from phieuGui in ListPhieuGui
            //                      join stk in ListSTK on phieuGui.MaSoTietKiem equals stk.MaSoTietKiem
            //                      where (stk.MaLoaiTietKiem == ltk.MaLoaiTietKiem && phieuGui.NgayGui.Date == SelectedDateReport.Date)
            //                      select phieuGui.SoTienGui;
            //        TongThu += listThu.Sum();

            //        var listChi = from phieuRut in ListPhieuRut
            //                      join stk in ListSTK on phieuRut.MaSoTietKiem equals stk.MaSoTietKiem
            //                      where (stk.MaLoaiTietKiem == ltk.MaLoaiTietKiem && phieuRut.NgayRut.Date == SelectedDateReport.Date)
            //                      select phieuRut.SoTienRut;
            //        TongChi += listChi.Sum();

            //        ChenhLech = (TongThu - TongChi);

            //        BaoCaoDS baoCaoDisplay = new BaoCaoDS(SoThuTu, TenLoaiTietKiem, TongThu, TongChi, ChenhLech);
            //        ListBaoCaoDisplay.Add(baoCaoDisplay);

            //        BAOCAODOANHSO baoCao = new BAOCAODOANHSO()
            //        {
            //            MaBaoCaoDoanhSo = maBaoCao,
            //            NgayDoanhSo = SelectedDateReport,
            //            MaLoaiTietKiem = maLoai,
            //            TongThu = TongThu,
            //            TongChi = TongChi,
            //            ChenhLech = ChenhLech
            //        };
            //        return baoCao;
            //    }


            //    #endregion

            //    #region ICommand
            //    public ICommand SelectionChangedCommand { get; set; }
            //    public ICommand CreateReportCommand { get; set; }
            //    public ICommand PrintCommand { get; set; }
            //    public ICommand SelectedDateChangedCommand { get; set; }


            //    #endregion

            //    public BaoCaoDoanhSo_ViewModel()
            //    {
            //        LoadData();

            //        SelectionChangedCommand = new RelayCommand<object>((p) => { return true; },
            //            (p) => {
            //                ListBaoCaoDisplay.Clear();
            //                SelectedDateReport = SelectedDateReportDisplay;
            //                var listBaoCao = (from bc in ListBaoCaoDoanhSo
            //                                  where bc.NgayDoanhSo == SelectedDateReport
            //                                  select bc).ToList();
            //                for (int i = 0; i < listBaoCao.Count(); i++)
            //                {
            //                    TongThu = TongChi = 0;
            //                    GetBaoCaoToDisplay(i, listBaoCao[i].LOAITIETKIEM, listBaoCao[i]);
            //                }
            //            }
            //        );

            //        // button for finding report and create if ... not available
            //        CreateReportCommand = new RelayCommand<object>((p) => { return true; },
            //            (p) => {
            //                // clear all elements of ListBaoCaoDisplay to clear screen
            //                ListBaoCaoDisplay.Clear();

            //                if (SelectedDateReport > DateTime.Today)
            //                {
            //                    VisibilityDatePickerPopup = Visibility.Visible;
            //                    PopupContent = "Không thể lập báo cáo cho ngày sau ngày hiện tại";
            //                }
            //                else if (SelectedDateReport.Year < 1990)
            //                {
            //                    VisibilityDatePickerPopup = Visibility.Visible;
            //                    PopupContent = "Không thể lập báo cáo cho những ngày trước năm 1990";
            //                }
            //                else
            //                {
            //                    VisibilityDatePickerPopup = Visibility.Hidden;
            //                    bool isNew = false;

            //                    for (int i = 0; i < ListLTK.Count(); i++)
            //                    {
            //                        TongThu = TongChi = 0;
            //                        BAOCAODOANHSO baoCao = FindBaoCao(ListLTK[i]); ;

            //                        if (baoCao != null)
            //                        {
            //                            isNew = false;
            //                            GetBaoCaoToDisplay(i, ListLTK[i], baoCao);

            //                            DialogOpen = true;
            //                            Notify = "Lấy báo cáo doanh số thành công.";
            //                        }
            //                        else
            //                        {
            //                            isNew = true;
            //                            baoCao = CreateBaoCao(i, ListLTK[i]);
            //                            DataProvider.Ins.DB.BAOCAODOANHSOes.Add(baoCao);
            //                            DataProvider.Ins.DB.SaveChanges();

            //                            ListBaoCaoDoanhSo.Add(baoCao);

            //                            DialogOpen = true;
            //                            Notify = "Tạo báo cáo doanh số mới thành công.";
            //                        }
            //                    }
            //                    if (isNew)
            //                    {
            //                        if (ListNgayBaoCao.Count() == 0 || (SelectedDateReport < ListNgayBaoCao[ListNgayBaoCao.Count() - 1]))
            //                            ListNgayBaoCao.Add(SelectedDateReport);
            //                        else
            //                        {
            //                            for (int i = 0; i < ListNgayBaoCao.Count(); i++)
            //                            {
            //                                if (SelectedDateReport > ListNgayBaoCao[i])
            //                                {
            //                                    ListNgayBaoCao.Insert(i, SelectedDateReport);
            //                                    break;
            //                                }
            //                                else if(SelectedDateReport == ListNgayBaoCao[i])
            //                                {
            //                                    break;
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }

            //        );

            //        PrintCommand = new RelayCommand<object>((p) =>
            //        {
            //            if (SelectedDateReportDisplay == DateTime.MinValue || ListBaoCaoDisplay.Count == 0)
            //                return false;
            //            return true;
            //        },
            //            (p) => {
            //                BaoCaoDoanhSo_PrintPreview_ViewModel printPreviewBaoCaoDoanhSo = new BaoCaoDoanhSo_PrintPreview_ViewModel(ListBaoCaoDisplay, SelectedDateReport);
            //                BaoCaoDoanhSo_PrintPreview BaoCao = new BaoCaoDoanhSo_PrintPreview(printPreviewBaoCaoDoanhSo);
            //                BaoCao.ShowDialog();
            //                isLoaded = true;
            //            }
            //        );

            //        //SelectedDateChangedCommand = new RelayCommand<object>((p) => { return true; },
            //        //    (p) => {
            //        //        ListBaoCaoDisplay.Clear();
            //        //        if (SelectedDateReport > DateTime.Now)
            //        //        {
            //        //            VisibilityDatePicker = Visibility.Visible;
            //        //        }
            //        //        else
            //        //        {
            //        //            VisibilityDatePicker = Visibility.Hidden;
            //        //        }
            //        //    }
            //        //);
            //    }


            #endregion

            // new code from this hihi

            /*
      private void reset()
      {
          SelectedTenThang = "";
      }

      private string _SelectedTenThang;
      public string SelectedTenThang
      {
          get => _SelectedTenThang; set
          {
              _SelectedTenThang = value;
              OnPropertyChanged();
          }
      }

      public BaoCaoDoanhSo_ViewModel()
      {
          ListTenThang = new ObservableCollection<String>();

          for (int i = 1; i < 13; i++)
              ListTenThang.Add("Tháng " + i);

          ListNam = new ObservableCollection<String>();
          DateTime now = DateTime.Today;
          for (int i = 0; i < 5; i++)
              ListNam.Add((Convert.ToInt32(now.ToString("yyyy")) - i).ToString());
      }

      private ObservableCollection<String> _ListTenThang;
      public ObservableCollection<String> ListTenThang { get => _ListTenThang; set { _ListTenThang = value; OnPropertyChanged(); } }


      private ObservableCollection<String> _ListNam;
      public ObservableCollection<String> ListNam { get => _ListNam; set { _ListNam = value; OnPropertyChanged(); } }

                    private void LoadData()
            {
                ListBaoCaoDisplay = new ObservableCollection<BaoCaoDS>();
            }

            private void GetBaoCaoToDisplay(BAOCAODOANHSO baoCao)
            {
                SoThuTu = i + 1;

                BaoCaoDS baoCaoDisplay = new BaoCaoDS(SoThuTu);
                ListBaoCaoDisplay.Add(baoCaoDisplay);
            }

            private ObservableCollection<BaoCaoDS> _ListBaoCaoDisplay;
            public ObservableCollection<BaoCaoDS> ListBaoCaoDisplay
            {
                get => _ListBaoCaoDisplay;
                set { _ListBaoCaoDisplay = value; OnPropertyChanged(); }
            }
      */

        public ICommand StartDateChangedCommand { get; set; }
        public ICommand EndDateChangedCommand { get; set; }
        public ICommand YearChangedCommand { get; set; }
        public ICommand CheDoXemChangedCommand { get; set; }
        private DateTime _SelectedStartDate;
        public DateTime SelectedStartDate { get => _SelectedStartDate; set { _SelectedStartDate = value; OnPropertyChanged(); } }
        private DateTime _SelectedEndDate;
        public DateTime SelectedEndDate { get => _SelectedEndDate; set { _SelectedEndDate = value; OnPropertyChanged(); } }

        private Visibility _VisibilityDatePickerPopup;
        public Visibility VisibilityDatePickerPopup { get => _VisibilityDatePickerPopup; set { _VisibilityDatePickerPopup = value; OnPropertyChanged(); } }
        private string _PopupContent;
        public string PopupContent { get => _PopupContent; set { _PopupContent = value; OnPropertyChanged(); } }
        public ICommand PrintTableCommand { get; set; }
        public ICommand PrintChartCommand { get; set; }
        private ObservableCollection<DongBaoCao> _BaoCao;
        public ObservableCollection<DongBaoCao> BaoCao
        {
            get => _BaoCao;
            set { _BaoCao = value; OnPropertyChanged(); }
        }
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
        private string _DoanhThuCaNam;
        public string DoanhThuCaNam { get => _DoanhThuCaNam; set { _DoanhThuCaNam = value; OnPropertyChanged(); } }
        private int _Maximum;
        public int Maximum { get => _Maximum; set { _Maximum = value; OnPropertyChanged(); } }
        private ObservableCollection<DiemBieuDo> _ChartData;
        public ObservableCollection<DiemBieuDo> ChartData
        {
            get => _ChartData;
            set { _ChartData = value; OnPropertyChanged(); }
        }
        private ObservableCollection<int> _ListYear;
        public ObservableCollection<int> ListYear { get => _ListYear; set { _ListYear = value; OnPropertyChanged(); } }
        private int _SelectedYear;
        public int SelectedYear { get => _SelectedYear; set { _SelectedYear = value; OnPropertyChanged(); } }
        private string _TenNhanVien;
        public BaoCaoDoanhSo_ViewModel()
        {
            ListCheDoXem = new ObservableCollection<string>();
            ListCheDoXem.Add("Bảng");
            ListCheDoXem.Add("Biểu đồ đường");
            SelectedCheDoXem = "Bảng";
            showTableView();
            StartDateChangedCommand = new RelayCommand<object>((p) => { return true; },
            (p) => {
                if (SelectedStartDate>SelectedEndDate)
                {
                    BaoCao = new ObservableCollection<DongBaoCao>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Ngày bắt đầu không được lớn hơn ngày kết thúc.";                    
                }
                else if (SelectedStartDate>=DateTime.Today || SelectedEndDate >= DateTime.Today)
                {
                    BaoCao = new ObservableCollection<DongBaoCao>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Phạm vi báo cáo phải từ quá khứ đến trước ngày hiện tại";                   
                }
                else if (SelectedStartDate.Year < 1900 || SelectedEndDate.Year < 1900)
                {
                    BaoCao = new ObservableCollection<DongBaoCao>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Năm được chọn phải sau thế kỷ thứ 18";
                }
                else            
                    LoadData();
            });
            EndDateChangedCommand = new RelayCommand<object>((p) => { return true; },
            (p) => {
                if (SelectedStartDate > SelectedEndDate)
                {
                    BaoCao = new ObservableCollection<DongBaoCao>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Ngày bắt đầu không được lớn hơn ngày kết thúc.";
                }
                else if (SelectedStartDate >= DateTime.Today || SelectedEndDate >= DateTime.Today)
                {
                    BaoCao = new ObservableCollection<DongBaoCao>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Phạm vi báo cáo phải từ quá khứ đến trước ngày hiện tại";
                }
                else if (SelectedStartDate.Year < 1900 || SelectedEndDate.Year < 1900)
                {
                    BaoCao = new ObservableCollection<DongBaoCao>();
                    VisibilityDatePickerPopup = Visibility.Visible;
                    PopupContent = "Năm được chọn phải sau thế kỷ thứ 18";
                }
                else
                    LoadData();
            });
            YearChangedCommand = new RelayCommand<object>((p) => { return true; },
            (p) => {
                    LoadChart();
            });
            PrintTableCommand = new RelayCommand<object>((q) =>
            {
                if (BaoCao.Count == 0)
                    return false;
                return true;
            },
                (q) =>
                {
                    BaoCaoDoanhSo_PrintPreview_ViewModel printPreviewBaoCaoDoanhSo = new BaoCaoDoanhSo_PrintPreview_ViewModel(BaoCao, SelectedStartDate, SelectedEndDate, "*insert nguoi tao here");
                    BaoCaoDoanhSo_PrintPreview PrintPreviewWindow = new BaoCaoDoanhSo_PrintPreview(printPreviewBaoCaoDoanhSo);
                    PrintPreviewWindow.ShowDialog();
                }
            );
            CheDoXemChangedCommand = new RelayCommand<object>((p) => { return true; },
            (p) => {
                if (SelectedCheDoXem=="Bảng")
                {
                    showTableView();
                }
                if (SelectedCheDoXem=="Biểu đồ đường")
                {
                    showChartView();
                }
            });


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
            for (int i=4;i>=0;i--)
            {
                ListYear.Add(DateTime.Today.Year - i);
            }
            SelectedYear = DateTime.Today.Year;
            LoadChart();
        }
        void LoadChart()
        {
            ChartData = new ObservableCollection<DiemBieuDo>();
            YearHeader = "Năm " + SelectedYear.ToString();
            decimal doanhthucanam = 0;
            Maximum = 0;
            for (int i=1;i<13;i++)
            {
                var ThongKeNgay = new ObservableCollection<THONGKENGAY>(DataProvider.Ins.DB.THONGKENGAYs);
                var ChiTiet = new ObservableCollection<CT_THONGKENGAY>(DataProvider.Ins.DB.CT_THONGKENGAY);
                var MatHang = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);
                var DataQuery = from ct in ChiTiet
                                join tkn in ThongKeNgay on ct.MaThongKe equals tkn.MaThongKe
                                where (tkn.Ngay.Year == SelectedYear && tkn.Ngay.Month == i)
                                select new { ct.Thu};
                DiemBieuDo diembieudo = new DiemBieuDo();
                diembieudo.Month = "Tháng " + i.ToString();
                if (DataQuery.Count() == 0)
                    diembieudo.Thu = 0;
                else diembieudo.Thu = DataQuery.Sum(d => d.Thu);
                doanhthucanam += diembieudo.Thu;
                if (diembieudo.Thu > Maximum)
                    Maximum = Decimal.ToInt32(diembieudo.Thu);
                ChartData.Add(diembieudo);
            }
            Maximum += 1000000;
            DoanhThuCaNam = "Doanh thu cả năm: " + Decimal.ToInt32(doanhthucanam).ToString() + " VNĐ";
        }

        void LoadData()
        {
            BaoCao = new ObservableCollection<DongBaoCao>();
            VisibilityDatePickerPopup = Visibility.Hidden;
            var ThongKeNgay = new ObservableCollection<THONGKENGAY>(DataProvider.Ins.DB.THONGKENGAYs);
            var ChiTiet = new ObservableCollection<CT_THONGKENGAY>(DataProvider.Ins.DB.CT_THONGKENGAY);
            var MatHang = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);
            var DataQuery = from ct in ChiTiet
                            join tkn in ThongKeNgay on ct.MaThongKe equals tkn.MaThongKe
                            where (tkn.Ngay >= SelectedStartDate && tkn.Ngay <= SelectedEndDate)
                            select new { ct.MaMH, ct.Thu, ct.Chi };
            var GroupedDataQuery = DataQuery
                .GroupBy(x => x.MaMH)
                .Select(g => new
                {
                    MaMH = g.Key,
                    TongThu = g.Sum(x => x.Thu),
                    TongChi = g.Sum(x=>x.Chi),
                });
            var ExtendedDataQuery = from gdq in GroupedDataQuery
                                    join mh in MatHang on gdq.MaMH equals mh.MaMH
                                    select new
                                    {
                                        gdq.MaMH,
                                        mh.TenMH,
                                        gdq.TongChi,
                                        gdq.TongThu,
                                    };
            BaoCao = new ObservableCollection<DongBaoCao>();
            int i = 1;
            foreach (var item in ExtendedDataQuery)
            {
                DongBaoCao dongbaocao = new DongBaoCao();
                dongbaocao.STT = i++;
                dongbaocao.MaMH = item.MaMH;
                dongbaocao.TenHang = item.TenMH;
                dongbaocao.TongThu = item.TongThu;
                dongbaocao.TongChi = item.TongChi;
                dongbaocao.ChenhLech = item.TongThu - item.TongChi;
                BaoCao.Add(dongbaocao);
            }
        }

    }
    public class DongBaoCao
    {
        public int STT { get; set; }
        public string MaMH { get; set; }
        public string TenHang { get; set; }
        public decimal TongThu { get; set; }
        public decimal TongChi { get; set; }
        public decimal ChenhLech { get; set; }
    }

    public class DiemBieuDo
    {
        public string Month { get; set; }
        public decimal Thu { get; set; }  
    }
}