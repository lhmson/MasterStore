﻿using MasterStoreDemo.Helper;
using MasterStoreDemo.Model;
using MaterialDesignColors.Recommended;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

namespace MasterStoreDemo.ViewModel
{
    public class XuatHang_ViewModel : BaseViewModel
    {
        #region Old code
        //#region variables
        //private bool Result_KiemTraNhapLai;
        //private int kyHan;

        //private string _Notify;

        //public string Notify
        //{
        //    get { return _Notify; }
        //    set { _Notify = value; OnPropertyChanged(); }
        //}

        //private bool _OpenDialog;

        //public bool OpenDialog
        //{
        //    get { return _OpenDialog; }
        //    set { _OpenDialog = value; OnPropertyChanged();}
        //}

        //private ObservableCollection<ListLichSuPhieuGui> _ListLichSuGD;

        //public ObservableCollection<ListLichSuPhieuGui> ListLichSuGD
        //{
        //    get { return _ListLichSuGD; }
        //    set { _ListLichSuGD = value; OnPropertyChanged(); }
        //}

        //private string _SoTienGuiToiThieu;

        //public string SoTienGuiToiThieu
        //{
        //    get { return _SoTienGuiToiThieu; }
        //    set { _SoTienGuiToiThieu = value; OnPropertyChanged(); }
        //}

        //private string _MaPG;

        //public string MaPG
        //{
        //    get { return _MaPG; }
        //    set { _MaPG = value; OnPropertyChanged(); }
        //}

        //private string _NgayGuiTien;

        //public string NgayGuiTien
        //{
        //    get { return _NgayGuiTien; }
        //    set { _NgayGuiTien = value; OnPropertyChanged(); }
        //}


        //private string _TienGui;
        //public string TienGui
        //{
        //    get { return _TienGui; }
        //    set { _TienGui = value; OnPropertyChanged(); }
        //}

        //private string _Notify_Ma;

        //public string Notify_Ma
        //{
        //    get { return _Notify_Ma; }
        //    set { _Notify_Ma = value; OnPropertyChanged(); }
        //}
        //private string _Notify_date;

        //public string Notify_date
        //{
        //    get { return _Notify_date; }
        //    set { _Notify_date = value; OnPropertyChanged(); }
        //}
        //private string _Notify_money;

        //public string Notify_money
        //{
        //    get { return _Notify_money; }
        //    set { _Notify_money = value; OnPropertyChanged(); }
        //}


        //private string _MaSoTietKiem_check;
        //public string MaSoTietKiem_check
        //{
        //    get => _MaSoTietKiem_check;
        //    set { _MaSoTietKiem_check = value; OnPropertyChanged(); }
        //}

        //private string _SoTienGui_check;
        //public string SoTienGui_check
        //{
        //    get { return _SoTienGui_check; }
        //    set { _SoTienGui_check = value; OnPropertyChanged(); }
        //}
        //private string _NgayDaoHanKeTiep_check;
        //public string NgayDaoHanKeTiep_check
        //{
        //    get { return _NgayDaoHanKeTiep_check; }
        //    set { _NgayDaoHanKeTiep_check = value; OnPropertyChanged(); }
        //}
        //private bool _CanCreate;
        //public bool CanCreate
        //{
        //    get => _CanCreate;
        //    set { _CanCreate = value; OnPropertyChanged(); }
        //}

        //private string _SoDu;

        //public string SoDu
        //{
        //    get { return _SoDu; }
        //    set { _SoDu = value; OnPropertyChanged(); }
        //}


        //private string _NgayGui;
        //public string NgayGui
        //{
        //    get => _NgayGui;
        //    set { _NgayGui = value; OnPropertyChanged(); }
        //}

        //private string _MaSoTietKiem;
        //public string MaSoTietKiem
        //{
        //    get => _MaSoTietKiem;
        //    set { _MaSoTietKiem = value; OnPropertyChanged(); }
        //}

        //private string _SoTienGui;
        //public string SoTienGui
        //{
        //    get { return _SoTienGui; }
        //    set { _SoTienGui = value; OnPropertyChanged(); }
        //}

        //private string _TenKhachHang;
        //public string TenKhachHang
        //{
        //    get { return _TenKhachHang; }
        //    set { _TenKhachHang = value; OnPropertyChanged(); }
        //}

        //private string _TenLoaiTietKiem;
        //public string TenLoaiTietKiem
        //{
        //    get { return _TenLoaiTietKiem; }
        //    set { _TenLoaiTietKiem = value; OnPropertyChanged(); }
        //}

        //private string _SoCMND;
        //public string SoCMND
        //{
        //    get { return _SoCMND; }
        //    set { _SoCMND = value; OnPropertyChanged(); }
        //}

        //private string _NgayDaoHanKeTiep;
        //public string NgayDaoHanKeTiep
        //{
        //    get { return _NgayDaoHanKeTiep; }
        //    set { _NgayDaoHanKeTiep = value; OnPropertyChanged(); }
        //}

        //private bool _CreateReport;

        //public bool CreateReport
        //{
        //    get { return _CreateReport; }
        //    set { _CreateReport = value; OnPropertyChanged(); }
        //}

        //#endregion
        //#region function 
        //#region function to DataBase
        //private LOAITIETKIEM search_MaLTK(string mltk)
        //{
        //    ObservableCollection<LOAITIETKIEM> List_LoaiTietKiem = new ObservableCollection<LOAITIETKIEM>(DataProvider.Ins.DB.LOAITIETKIEMs);
        //    foreach (LOAITIETKIEM ltk in List_LoaiTietKiem)
        //    {
        //        if (ltk.MaLoaiTietKiem == mltk)
        //            return ltk;
        //    }
        //    return null;
        //}
        //private SOTIETKIEM search_MaSo(string MaSo)
        //{
        //    ObservableCollection<SOTIETKIEM> List_STK = new ObservableCollection<SOTIETKIEM>(DataProvider.Ins.DB.SOTIETKIEMs);

        //    foreach (SOTIETKIEM STK in List_STK)
        //    {
        //        if (STK.MaSoTietKiem == MaSo)
        //            return STK;


        //    }
        //    return null;
        //}
        //private string search_TenLTK(string MaLTK)
        //{
        //    ObservableCollection<LOAITIETKIEM> List_LTK = new ObservableCollection<LOAITIETKIEM>(DataProvider.Ins.DB.LOAITIETKIEMs);

        //    foreach (LOAITIETKIEM LTK in List_LTK)
        //    {
        //        if (LTK.MaLoaiTietKiem == MaLTK)
        //            return LTK.TenLoaiTietKiem;
        //    }
        //    return "0";
        //}

        //private decimal search_ThamSo(string MaThamSo)
        //{
        //    ObservableCollection<THAMSO> List_TS = new ObservableCollection<THAMSO>(DataProvider.Ins.DB.THAMSOes);

        //    foreach (THAMSO TS in List_TS)
        //    {

        //        if (TS.TenThamSo == MaThamSo)
        //            return TS.GiaTri;

        //    }
        //    return 0;
        //}
        //#endregion
        //public void BindingLichSu(string mastk)
        //{
        //    ListLichSuGD = new ObservableCollection<ListLichSuPhieuGui>();

        //    ObservableCollection<PHIEUGUI> List_PG = new ObservableCollection<PHIEUGUI>(DataProvider.Ins.DB.PHIEUGUIs);
        //    var lichsu = from list in List_PG
        //                 where list.MaSoTietKiem == mastk
        //                 orderby list.MaPhieuGui descending
        //                 select new ListLichSuPhieuGui(list.MaPhieuGui, list.NgayGui.ToString("dd/MM/yyyy"), list.SoTienGui.ToString("0,000"));
        //    foreach (var ls in lichsu)
        //        ListLichSuGD.Add(ls);
        //}
        ////Ham ben duoi duoc lay tu MoSo
        //private bool check_hasaWhiteSpace(string chuoi)
        //{
        //    if (chuoi == null) return false;
        //    foreach (var item in chuoi)
        //        if (item == ' ')
        //            return true;
        //    return false;
        //}

        //private bool KiemTraNhapLai()
        //{
        //    try
        //    {
        //        Result_KiemTraNhapLai = true;
        //        SOTIETKIEM info_stk = search_MaSo(MaSoTietKiem);
        //        LOAITIETKIEM info_loaitietkiem = search_MaLTK(info_stk.MaLoaiTietKiem);
        //        kyHan = info_loaitietkiem.KyHan;
        //        if (info_loaitietkiem.KyHan != 0)
        //        {
        //            if (info_stk.NgayDaoHanKeTiep == DateTime.Today)
        //            {
        //                Result_KiemTraNhapLai = false;
        //            }
        //        }
        //        else
        //        {
        //            if (info_stk.NgayDaoHanKeTiep != DateTime.Today.AddDays(1))
        //            {
        //                Result_KiemTraNhapLai = false;
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Result_KiemTraNhapLai = true;
        //        return false;
        //    }
        //}
        //private void Init()
        //{

        //    SoTienGui_check = "None";
        //    NgayDaoHanKeTiep_check = "None";
        //    TenKhachHang = "";
        //    SoDu = "";
        //    SoCMND = "";
        //    TenLoaiTietKiem = "";
        //    NgayDaoHanKeTiep = "";
        //    SoTienGui = "";
        //    Notify_date = "";
        //    Notify_money = "";
        //    Result_KiemTraNhapLai = true;
        //    CanCreate = false;

        //}

        //private void CheckValid()
        //{
        //    try
        //    {
        //        try
        //        {
        //            if (decimal.Parse(SoTienGui) < 1000)
        //            {

        //            }
        //            else
        //            {
        //                SoTienGui = decimal.Parse(SoTienGui).ToString("0,000");
        //            }
        //        }
        //        catch (Exception e)
        //        {

        //        }

        //        if ( String.IsNullOrWhiteSpace(MaSoTietKiem))
        //        {
        //            Notify_Ma= "Hãy nhập mã sổ tiết kiệm trước khi bấm kiểm tra!";
        //            MaSoTietKiem_check = "Error";
        //        }
        //        else
        //        {
        //            if (TenKhachHang == "")
        //            {
        //                Notify_Ma = "Chưa thực hiện kiểm tra mã sổ";
        //                MaSoTietKiem_check = "Error";
        //            }
        //            else
        //            {
        //                if (!KiemTraNhapLai())
        //                {
        //                    NgayDaoHanKeTiep_check = "Error";
        //                    Notify_date = "Lỗi, không xác định được thông tin đáo hạn.";
        //                }
        //                else
        //                {
        //                    if (Result_KiemTraNhapLai == false)
        //                    {
        //                        NgayDaoHanKeTiep_check = "Error";
        //                        Notify_date = "Cần nhập lãi trước khi rút.";
        //                    }
        //                    else
        //                    {

        //                    }
        //                }
        //                MaSoTietKiem_check = "None";
        //                Notify_Ma = "";
        //                if (String.IsNullOrWhiteSpace(SoTienGui))
        //                {
        //                    Notify_money = "Chưa nhập số tiền gửi";
        //                    SoTienGui_check = "Error";
        //                }
        //                else
        //                if (check_hasaWhiteSpace(SoTienGui))
        //                {
        //                    Notify_money = "Số tiền không thể chứa khoảng trắng";
        //                    SoTienGui_check = "Error";
        //                }
        //                else
        //                if (decimal.Parse(SoTienGui) < decimal.Parse(SoTienGuiToiThieu))
        //                {
        //                    Notify_money = "Số tiền gửi tối thiểu không đủ";
        //                    SoTienGui_check = "Error";
        //                }
        //                else
        //                if (decimal.Parse(SoTienGui) >= decimal.Parse(SoTienGuiToiThieu))
        //                {
        //                    SoTienGui_check = "None";
        //                    Notify_money = "";
        //                }
        //                if (DateTime.Today.AddDays(kyHan).ToString("dd/MM/yyyy") != NgayDaoHanKeTiep && kyHan != 0)
        //                {
        //                    Notify_date = "Không thể gửi hôm nay";
        //                    NgayDaoHanKeTiep_check = "Error";
        //                }
        //            }
        //        }
        //        //if (TenLoaiTietKiem== "Không kì hạn")
        //        //{
        //        //    NgayDaoHanKeTiep_check = "None";
        //        //    Notify_date = ""; 
        //        //}
        //        if (MaSoTietKiem_check == "Error" || SoTienGui_check == "Error" || NgayDaoHanKeTiep_check == "Error")
        //        {
        //            CanCreate = false;
        //        }
        //        else
        //        {
        //            CanCreate = true;

        //            Notify = "Thông tin phiếu gửi hợp lệ";
        //            OpenDialog = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return;
        //    }

        //}
        //public string formatPG(string a)
        //{
        //    string tmp = a;
        //    for (int i = 1; i <= 7 - a.Length;i++)
        //        tmp = "0" + tmp;
        //    return tmp;
        //}
        //private string GetCodeMPG()
        //{
        //    ObservableCollection<PHIEUGUI> List_PG = new ObservableCollection<PHIEUGUI>(DataProvider.Ins.DB.PHIEUGUIs);
        //    int tmp = List_PG.Count();
        //    return "PG" + formatPG((tmp + 1).ToString());
        //}
        //private void ExecuteSTK()
        //{
        //    SOTIETKIEM stk = search_MaSo(MaSoTietKiem);
        //    if (stk == null)
        //    {
        //        MaSoTietKiem_check = "Error";
        //        Notify_Ma = "Mã STK không đúng hoặc không tồn tại, kiểm tra xem đã đúng định dạng hay chưa";
        //    }
        //    else
        //    if (stk.NgayDongSo != null)
        //    {
        //        MaSoTietKiem_check = "Error";
        //        Notify_Ma = "Sổ đã đóng không thể gửi tiền";
        //    }
        //    else

        //    {

        //        SoTienGui_check = "None";
        //        NgayDaoHanKeTiep_check = "None";
        //        MaSoTietKiem_check = "None";
        //        TenKhachHang = stk.TenKhachHang;
        //        TenLoaiTietKiem = search_TenLTK(stk.MaLoaiTietKiem);
        //        if (TenLoaiTietKiem != "Không kì hạn")
        //            NgayDaoHanKeTiep = stk.NgayDaoHanKeTiep.ToString("dd/MM/yyyy");
        //        else NgayDaoHanKeTiep = "Không xác định";
        //        SoCMND = stk.SoCMND;
        //        if (stk.SoDu < 1000)
        //        {
        //            SoDu = stk.SoDu.ToString();
        //        }
        //        else
        //        {
        //            SoDu = stk.SoDu.ToString("0,000");
        //        }

        //        SoTienGui = "";
        //        BindingLichSu(stk.MaSoTietKiem);
        //    }
        //}
        //#endregion
        //#region command Binding
        //public ICommand MSTK_TextChangedCommand { get; set; }
        //public ICommand CheckoutCommand { get; set; }
        //public ICommand CheckCommand { get; set; }
        //public ICommand ShowINFO { get; set; }
        //public ICommand Click_CapNhatCommand { get; set; }
        //public ICommand STG_TextChangedCommand { get; set; }
        //public ICommand Refresh { get; set; }

        //#endregion
        //public XuatHang_ViewModel()
        //{
        //    Init();
        //    MaSoTietKiem_check = "None"; Notify_Ma = "";
        //    OpenDialog = false;
        //    NgayGui = DateTime.Now.ToString("dd/MM/yyyy");
        //    decimal temp = search_ThamSo("Tiền gửi thêm tối thiểu");
        //    if (temp< 1000)
        //    {
        //        SoTienGuiToiThieu = temp.ToString();
        //    }
        //    else
        //    {
        //        SoTienGuiToiThieu = temp.ToString("0,000");
        //    }
        //    CreateReport = true;
        //    MSTK_TextChangedCommand = new RelayCommand<TextBox>((p) => { return true; }, (p) =>
        //    {
        //        try
        //        {
        //            Init();
        //            Result_KiemTraNhapLai = true;
        //        }
        //        catch (Exception e)
        //        {

        //        }
        //    });
        //    ShowINFO = new RelayCommand<object>((p) =>
        //    {
        //        return true;
        //    }, (p) =>
        //    {
        //        ExecuteSTK();
        //        KiemTraNhapLai();

        //    });
        //    CheckCommand = new RelayCommand<object>((p) =>
        //    {
        //        return true;
        //    }, (p) =>
        //    {
        //        CheckValid();

        //    });
        //    STG_TextChangedCommand = new RelayCommand<object>((p) =>
        //    {
        //        return true;
        //    }, (p) =>
        //    {
        //        CanCreate = false;
        //    });
        //    //button nhap lai vao von
        //    Click_CapNhatCommand = new RelayCommand<object>((p) => { return !Result_KiemTraNhapLai; }, (p) =>
        //    {
        //        MessageBoxResult re = MessageBox.Show("Bạn có chắc muốn nhập lãi vào vốn? Tiến trình này không thể hoàn tác.", "Thông báo", MessageBoxButton.OKCancel);
        //        if (re == MessageBoxResult.OK)
        //        {
        //            if (!NhapLaiVaoVon.Ins.StartThis(MaSoTietKiem, true))
        //            {
        //                Notify = "Có lỗi xảy ra hoặc sổ tiết kiệm này đã được nhập lãi rồi!";
        //                NgayDaoHanKeTiep_check = "Error";
        //                Notify_date = "Có lỗi xảy ra hoặc sổ tiết kiệm này đã được nhập lãi rồi!";
        //            }
        //            else
        //            {
        //                OpenDialog = true;
        //                Notify = "Đã cập nhật lãi vào số dư";
        //                KiemTraNhapLai();
        //                ExecuteSTK();
        //            }
        //        }
        //    });
        //    //Button Tao Phieu gui
        //    CheckoutCommand = new RelayCommand<object>((p) =>
        //    {
        //        return true;
        //    }, (p) =>
        //    {
        //        CheckValid();

        //        if (CanCreate == true)
        //        {

        //            string mapg = GetCodeMPG();
        //            PHIEUGUI Phieugui = new PHIEUGUI()
        //            {
        //                MaPhieuGui = mapg,
        //                MaSoTietKiem = MaSoTietKiem,
        //                NgayGui = DateTime.Now,
        //                SoTienGui = decimal.Parse(SoTienGui),
        //            };
        //            //edit PhieuGui
        //            DataProvider.Ins.DB.PHIEUGUIs.Add(Phieugui);
        //            DataProvider.Ins.DB.SaveChanges();
        //            //edit SoTietKiem
        //            var SotietKiem = DataProvider.Ins.DB.SOTIETKIEMs.Where(x => x.MaSoTietKiem == MaSoTietKiem).SingleOrDefault();
        //            SotietKiem.SoDu += decimal.Parse(SoTienGui);             
        //            DataProvider.Ins.DB.SaveChanges();
        //            BindingLichSu(MaSoTietKiem);

        //            Notify = "Đã tạo phiếu gửi thành công";
        //            OpenDialog = true;
        //            if (CreateReport==true)
        //            {
        //                XuatHang_PrintPreview_ViewModel PhieuGuiVM = new XuatHang_PrintPreview_ViewModel(mapg,TenKhachHang,NgayGui,SoTienGui);
        //                XuatHang_PrintPreview PhieuGui = new XuatHang_PrintPreview(PhieuGuiVM);
        //                PhieuGui.ShowDialog();

        //            }
        //            Init();
        //            MaSoTietKiem_check = "None"; Notify_Ma = "";
        //        }
        //    });

        //    Refresh = new RelayCommand<object>((p) => { return true; }, (p) =>
        //    {
        //        Init();
        //        MaSoTietKiem = "";
        //        Notify_Ma = "";
        //        MaSoTietKiem_check = "None";
        //    });
        //}
        #endregion

        // new code from this hihi

        #region declare binding variables

        public string maPhieuDuyet = "";

        private ObservableCollection<ListPhieu> _ListPhieu;
        public ObservableCollection<ListPhieu> ListPhieu
        {
            get { return _ListPhieu; }
            set { _ListPhieu = value; OnPropertyChanged(); }
        }

        private ObservableCollection<ListCTPhieu> _ListCTPhieu;
        public ObservableCollection<ListCTPhieu> ListCTPhieu
        {
            get { return _ListCTPhieu; }
            set { _ListCTPhieu = value; OnPropertyChanged(); }
        }

        private ListPhieu _SelectedPhieu;
        public ListPhieu SelectedPhieu
        {
            get { return _SelectedPhieu; }
            set { _SelectedPhieu = value; OnPropertyChanged(); }
        }
        #endregion

        public string get_TenQuay(string maQuay)
        {
            ObservableCollection<QUAY> list_Quay = new ObservableCollection<QUAY>(DataProvider.Ins.DB.QUAYs);

            foreach (var quay in list_Quay)
                if (quay.MaQuay == maQuay)
                    return quay.TenQuay;

            return "";
        }

        public void khongduyet()
        {
            if (SelectedPhieu == null)
                return;
            ObservableCollection<PHIEUXUATKHO> list_PXK = new ObservableCollection<PHIEUXUATKHO>(DataProvider.Ins.DB.PHIEUXUATKHOes);

            foreach (var pxk in list_PXK)
                if (pxk.MaPhieuXK == SelectedPhieu.Ma)
                {
                    pxk.TrangThai = 2;
                    DataProvider.Ins.DB.SaveChanges();
                    break;
                }
            ListCTPhieu = new ObservableCollection<ListCTPhieu>();
            init_ListView();
            MessageBox.Show("Phiếu đề nghị đã hủy thành công");
        }

        public int get_SoLuongTon(string maMH)
        {
            ObservableCollection<THEKHO> list_TK = new ObservableCollection<THEKHO>(DataProvider.Ins.DB.THEKHOes);

            foreach (var tk in list_TK)
                if (tk.MaMH == maMH)
                {
                    return tk.SoLuongTonKho;
                }
            return 0;
        }

        public string create_MaCTTK()
        {
            ObservableCollection<CT_THEKHO> list_PXK = new ObservableCollection<CT_THEKHO>(DataProvider.Ins.DB.CT_THEKHO);

            int max = 0;
            foreach (var phieu in list_PXK)
            {
                int value = int.Parse(phieu.MaCTTheKho.Substring(4));
                if (max < value) max = value;
            }

            max++;
            string code = "CTTK";
            for (int i = 0; i < 6 - max.ToString().Length; i++)
                code += "0";
            code += max.ToString();
            return code;
        }

        public void update_xuatkho(string maMH, int slxuat)
        {
            ObservableCollection<THEKHO> list_TK = new ObservableCollection<THEKHO>(DataProvider.Ins.DB.THEKHOes);

            string maTK = "";
            foreach (var tk in list_TK)
                if (tk.MaMH == maMH)
                {
                    maTK = tk.MaTheKho;
                    tk.SoLuongTonKho -= slxuat;
                    break;
                }

            #region Update chi tiết xuất kho
            CT_THEKHO temp = new CT_THEKHO()
            {
                MaTheKho = maTK,
                MaCTTheKho =create_MaCTTK(),
                NgayNhapXuat = DateTime.Now,
                DienGiai = "",
                MaPhieuNhapXuat = maPhieuDuyet,
            };

            DataProvider.Ins.DB.CT_THEKHO.Add(temp);
            DataProvider.Ins.DB.SaveChanges();
            #endregion
        }
        public void update_themgian(string maMH, int slthem)
        {
            ObservableCollection<MATHANG> list_MH = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);

            foreach (var mh in list_MH)
                if (mh.MaMH == maMH)
                {
                    mh.SoLuongTonGian += slthem;
                    DataProvider.Ins.DB.SaveChanges();
                    return;
                }
        }

        public void duyet()
        {
            if (SelectedPhieu == null)
                return;

            ObservableCollection<CT_PHIEUXUATKHO> list_CTXK = new ObservableCollection<CT_PHIEUXUATKHO>(DataProvider.Ins.DB.CT_PHIEUXUATKHO);

            foreach (var ct in list_CTXK)
                if (ct.MaPhieuXK == SelectedPhieu.Ma)
                {
                    if (ct.SoLuong > get_SoLuongTon(ct.MaMH))
                    {
                        MessageBox.Show("Số lượng hàng kho không thể đáp ứng phiếu đề nghị này!");
                        return;
                    }
                }

            foreach (var ct in list_CTXK)
                if (ct.MaPhieuXK == SelectedPhieu.Ma)
                {
                    maPhieuDuyet = ct.MaPhieuXK;
                    update_xuatkho(ct.MaMH, ct.SoLuong);
                    update_themgian(ct.MaMH, ct.SoLuong);
                }

            ObservableCollection<PHIEUXUATKHO> list_PXK = new ObservableCollection<PHIEUXUATKHO>(DataProvider.Ins.DB.PHIEUXUATKHOes);

            foreach (var pxk in list_PXK)
                if (pxk.MaPhieuXK == SelectedPhieu.Ma)
                {
                    pxk.TrangThai = 1;
                    DataProvider.Ins.DB.SaveChanges();
                    break;
                }

            MessageBox.Show("Xuất hàng thành công");
            init_ListView();
            init_ListCTPhieu("");
        }

        #region Sub Functions 
        public void init_ListView()
        {
            ObservableCollection<PHIEUXUATKHO> list_PXK = new ObservableCollection<PHIEUXUATKHO>(DataProvider.Ins.DB.PHIEUXUATKHOes);
            ObservableCollection<ListPhieu> ListPhieu_temp = new ObservableCollection<ListPhieu>();

            int stt = 1;

            foreach (var phieu in list_PXK)
                if (phieu.TrangThai == 0)
                {
                    ListPhieu temp = new ListPhieu(stt.ToString(), phieu.MaPhieuXK, phieu.NgayLap.ToString("dd/MM/yyyy"), phieu.QUAY.TenQuay,phieu.NGUOIDUNG.HoTen);
                    stt++;
                    ListPhieu_temp.Add(temp);
                }

            if (ListPhieu == null)
            {
                ListPhieu = ListPhieu_temp;
                init_ListCTPhieu("");
            }
            else
            {
                if (ListPhieu.Count() != ListPhieu_temp.Count())
                {
                    ListPhieu = ListPhieu_temp;
                    init_ListCTPhieu("");
                    return;
                }

                for (int i = ListPhieu.Count()-1; i >= 0; i--)
                    if (ListPhieu[i].Ma != ListPhieu_temp[i].Ma)
                    {
                        ListPhieu = ListPhieu_temp;
                        init_ListCTPhieu("");
                        return;
                    }
            }
        }

        public void init_ListCTPhieu(string maPhieu)
        {
            ObservableCollection<CT_PHIEUXUATKHO> list_CTXK = new ObservableCollection<CT_PHIEUXUATKHO>(DataProvider.Ins.DB.CT_PHIEUXUATKHO);
            ListCTPhieu = new ObservableCollection<ListCTPhieu>();
            int stt = 1;

            foreach (var ct in list_CTXK)
                if (ct.MaPhieuXK == maPhieu)
                {
                    ListCTPhieu temp = new ListCTPhieu(stt.ToString(), ct.MaMH, ct.MATHANG.TenMH, ct.SoLuong.ToString());
                    stt++;
                    ListCTPhieu.Add(temp);
                }
        }
        private void OnTimerEvent(object sender, EventArgs e)
        {
            init_ListView();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            init_ListView();
        }

        private void TimerLoad()
        {
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            dispatcherTimer.Start();
        }

        #endregion

        #region Icommand
        public ICommand DuyetCommand { get; set; }
        public ICommand KhongDuyetCommand { get; set; }
        public ICommand SelectionChangedCommand { get; set; }
        #endregion

        public XuatHang_ViewModel()
        {
            init_ListView();
            TimerLoad();
            SelectionChangedCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                if (SelectedPhieu != null)
                    init_ListCTPhieu(SelectedPhieu.Ma);
            });

            KhongDuyetCommand = new RelayCommand<Object>((p) => { if (SelectedPhieu != null) return true; return false; }, (p) =>
            {
                khongduyet();
            });


            DuyetCommand = new RelayCommand<Object>((p) => { if (SelectedPhieu != null) return true; return false; }, (p) =>
            {
                duyet();
            });
        }
    }
}
