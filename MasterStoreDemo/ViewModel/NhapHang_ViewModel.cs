using MasterStoreDemo.Model;
using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using MasterStoreDemo.View;
using System.Windows.Input;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

using MasterStoreDemo.Helper;

namespace MasterStoreDemo.ViewModel
{
    public class NhapHang_ViewModel : BaseViewModel
    {

        #region Declare Command Variables
        public ICommand CloseWindowCommand { get; set; }
        public ICommand AddNCCFromFileCommand { get; set; }
        public ICommand AddNSXFromFileCommand { get; set; }
        public ICommand AddNCCCommand { get; set; }
        public ICommand EditNCCCommand { get; set; }
        public ICommand ThemMatHangCommand { get; set; }
        public ICommand ThemNhaCungCapCommand { get; set; }
        public ICommand ThemNhaSanXuatCommand { get; set; }
        public ICommand ThemHangCommand { get; set; }
        public ICommand LapPhieuDNNHCommand { get; set; }
        public ICommand GetPhieuNhapCommand { get; set; }
        public ICommand GetMaPhieNhapCommand { get; set; }
        public ICommand XoaHangCommand { get; set; }
        public ICommand XacNhanCommand { get; set; }
        public ICommand HuyCommand { get; set; }
        public ICommand DialogOK { get; set; }
        public ICommand AddNSXCommand { get; set; }
        public ICommand EditNSXCommand { get; set; }
        public ICommand EditMHCommand { get; set; }
        public ICommand ChangeNCC { get; set; }

        #endregion

        #region nha cung cap

        private ObservableCollection<NHACUNGCAP> _List;
        public ObservableCollection<NHACUNGCAP> ListNCC { get => _List; set { _List = value; OnPropertyChanged(); } }

        private string GetCodeNCC()
        {

            ObservableCollection<NHACUNGCAP> ListNCC = new ObservableCollection<NHACUNGCAP>(DataProvider.Ins.DB.NHACUNGCAPs);
            int tmp = ListNCC.Count();
            return "NCC" + format((tmp + 1).ToString());

        }

        public static string mancc_nhaphang;

        private string _tenncc;
        public string TenNCC { get => _tenncc; set { _tenncc = value; OnPropertyChanged(); } }

        private string _Diachi;
        public string DiaChi { get => _Diachi; set { _Diachi = value; OnPropertyChanged(); } }

        private string _sdt;
        public string SDT { get => _sdt; set { _sdt = value; OnPropertyChanged(); } }

        private string _fax;
        public string Fax { get => _fax; set { _fax = value; OnPropertyChanged(); } }

        public void InitNCC()
        {
            TenNCC = "";
            DiaChi = "";
            SDT = "";
            Fax = "";
        }

        #endregion

        #region nhà sản xuất

        private bool _NCC_NotNull = false;
        public bool NCC_NotNull
        {
            get => _NCC_NotNull;
            set { _NCC_NotNull = value; OnPropertyChanged(); }
        }

        public void InitNSX()
        {
            TenNSX = "";
            DiaChiNSX = "";
            SDTNSX = "";
        }

        private ObservableCollection<NHASANXUAT> _Listnsx;
        public ObservableCollection<NHASANXUAT> ListNSX { get => _Listnsx; set { _Listnsx = value; OnPropertyChanged(); } }

        private string _tennsx;
        public string TenNSX { get => _tennsx; set { _tennsx = value; OnPropertyChanged(); } }

        private string _DiachiNSX;
        public string DiaChiNSX { get => _DiachiNSX; set { _DiachiNSX = value; OnPropertyChanged(); } }

        private string _sdtNSX;
        public string SDTNSX { get => _sdtNSX; set { _sdtNSX = value; OnPropertyChanged(); } }

        private string GetCodeNSX()
        {
            ObservableCollection<NHASANXUAT> ListNSX = new ObservableCollection<NHASANXUAT>(DataProvider.Ins.DB.NHASANXUATs);
            int tmp = ListNSX.Count();
            return "NSX" + format((tmp + 1).ToString());
        }

        private NHASANXUAT _SelectedItemNSX;
        public NHASANXUAT SelectedItemNSX
        {
            get => _SelectedItemNSX;
            set
            {
                _SelectedItemNSX = value;
                OnPropertyChanged();
                if (SelectedItemNSX != null)
                {
                    TenNSX = SelectedItemNSX.TenNSX;
                    DiaChiNSX = SelectedItemNSX.DiaChi;
                    SDTNSX = SelectedItemNSX.SDT;

                }

            }
        }



        private NHACUNGCAP _SelectedItemNCC;
        public NHACUNGCAP SelectedItemNCC
        {
            get => _SelectedItemNCC;
            set
            {
                _SelectedItemNCC = value;
                OnPropertyChanged();
                NCC_NotNull = _SelectedItemNCC != null;

                if (SelectedItemNCC != null)
                {
                    TenNCC = SelectedItemNCC.TenNCC;
                    DiaChi = SelectedItemNCC.DiaChi;
                    SDT = SelectedItemNCC.SDT;
                    Fax = SelectedItemNCC.Fax;
                    mancc_nhaphang = SelectedItemNCC.MaNCC;
                }

            }
        }
        #endregion

        #region mặt hàng
        public static ObservableCollection<ListMatHangMua> temp_MH_Mua = new ObservableCollection<ListMatHangMua>();
        private ListMatHangMua _SelectedMatHang;

        public ListMatHangMua SelectedMatHang
        {
            get { return _SelectedMatHang; }
            set { _SelectedMatHang = value; OnPropertyChanged(); }
        }

        private string _Images;
        public string Images { get => _Images; set { _Images = value; OnPropertyChanged(); } }

        public ICommand AddMHCommand { get; set; }
        public ICommand AddImage { get; set; }

        private ObservableCollection<MATHANG> _Listmh;
        public ObservableCollection<MATHANG> ListMH { get => _Listmh; set { _Listmh = value; OnPropertyChanged(); } }

        private string _tenmh;
        public string TenMH { get => _tenmh; set { _tenmh = value; OnPropertyChanged(); } }

        private ObservableCollection<NHACUNGCAP> _ncc;
        public ObservableCollection<NHACUNGCAP> NCC { get => _ncc; set { _ncc = value; OnPropertyChanged(); } }

        private ObservableCollection<NHASANXUAT> _nsx;
        public ObservableCollection<NHASANXUAT> NSX { get => _nsx; set { _nsx = value; OnPropertyChanged(); } }

        private decimal _gianhap;
        public decimal GiaNhap { get => _gianhap; set { _gianhap = value; OnPropertyChanged(); } }

        private string _donvitinh;
        public string DonViTinh { get => _donvitinh; set { _donvitinh = value; OnPropertyChanged(); } }

        private int _soluongtongian;
        public int SoLuongTonGian { get => _soluongtongian; set { _soluongtongian = value; OnPropertyChanged(); } }

        private decimal _giaban;
        public decimal GiaBan { get => _giaban; set { _giaban = value; OnPropertyChanged(); } }

        public string image { get; set; }
        public void xoa_MatHang()
        {
            int stt = int.Parse(SelectedMatHang.STT);

            ObservableCollection<ListMatHangMua> temp = new ObservableCollection<ListMatHangMua>();

            int index = 1;
            for (int i = 0; i < ListMatHang.Count; i++)
                if (i != stt - 1)
                {
                    ListMatHang[i].STT = index + "";
                    index++;
                    temp.Add(ListMatHang[i]);
                }

            ListMatHang = temp;
            Cal_TongTien();
        }

        private MATHANG _SelectedItemMH;
        public MATHANG SelectedItemMH
        {
            get => _SelectedItemMH;
            set
            {
                _SelectedItemMH = value;
                OnPropertyChanged();
                if (SelectedItemMH != null)
                {
                    SoLuongTonGian = SelectedItemMH.SoLuongTonGian;
                    TenMH = SelectedItemMH.TenMH;
                    GiaBan = SelectedItemMH.GiaBan;
                    GiaNhap = SelectedItemMH.GiaNhap;
                    SoLuongTonGian = SelectedItemMH.SoLuongTonGian;
                    DonViTinh = SelectedItemMH.DonViTinh;
                    SelectedNCC = SelectedItemMH.NHACUNGCAP;
                    SelectedNSX = SelectedItemMH.NHASANXUAT;
                }
            }
        }

        private NHASANXUAT _SelectedNSX;
        public NHASANXUAT SelectedNSX
        {
            get => _SelectedNSX;
            set
            {
                _SelectedNSX = value;

                OnPropertyChanged();
            }
        }

        private NHACUNGCAP _SelectedNCC;
        public NHACUNGCAP SelectedNCC
        {
            get => _SelectedNCC;
            set
            {
                _SelectedNCC = value;
                OnPropertyChanged();
            }
        }

        public void InitMH()
        {
            TenMH = "";
            GiaNhap = 0;
            SelectedNCC = null;
            SelectedNSX = null;
            GiaBan = 0;
            DonViTinh = null;
            SoLuongTonGian = 0;
        }

        public string format(string a)
        {
            string tmp = a;
            for (int i = 1; i <= 4 - a.Length; i++)
                tmp = "0" + tmp;
            return tmp;
        }

        private string GetCodeMH()
        {
            ObservableCollection<MATHANG> ListMH = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);
            int tmp = ListMH.Count();
            return "MH" + format((tmp + 1).ToString());
        }

        private ObservableCollection<ListMatHangMua> _ListMatHang;
        public ObservableCollection<ListMatHangMua> ListMatHang
        {
            get { return _ListMatHang; }
            set { _ListMatHang = value; OnPropertyChanged(); }
        }

        private string _TongTien;
        public string TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; OnPropertyChanged(); }
        }

        #endregion

        #region Phiếu nhập kho

        private string _maphieunhapkho;
        public string MaPhieuNhapKho { get => _maphieunhapkho; set { _maphieunhapkho = value; OnPropertyChanged(); } }

        private bool _DialogOpen;

        public bool DialogOpen
        {
            get { return _DialogOpen; }
            set { _DialogOpen = value; OnPropertyChanged(); }
        }

        private bool _CreateReport;
        public bool CreateReport
        {
            get { return _CreateReport; }
            set { _CreateReport = value; OnPropertyChanged(); }
        }

        private string _ThongBao;
        public string ThongBao
        {
            get { return _ThongBao; }
            set { _ThongBao = value; OnPropertyChanged(); }
        }

        private string _NgayLapPhieu;
        public string NgayLapPhieu
        {
            get { return _NgayLapPhieu; }
            set { _NgayLapPhieu = value; OnPropertyChanged(); }
        }

        private string _NgayThangNam;
        public string NgayThangNam
        {
            get { return _NgayThangNam; }
            set { _NgayThangNam = value; OnPropertyChanged(); }
        }

        private string _NgayLap;
        public string NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; OnPropertyChanged(); }
        }

        public string get_DateNow()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        private string _TenNhanVien;
        public string TenNhanVien
        {
            get { return _TenNhanVien; }
            set { _TenNhanVien = value; OnPropertyChanged(); }
        }

        public void Init()
        {
            NgayLap = get_DateNow();
            TenNhanVien = get_NameofStaff();
            ListMatHang = new ObservableCollection<ListMatHangMua>();
            NgayThangNam = "Ngày " + NgayLap[0] + NgayLap[1] + ", Tháng " + NgayLap[3] + NgayLap[4] + ", Năm " + NgayLap.Substring(6);
        }

        public bool check_PN()
        {

            if (String.IsNullOrEmpty(MaPhieuNhapKho))
            {
                DialogOpen = true;
                ThongBao = "Bạn chưa tạo mã phiếu nhập! Vui lòng kiểm tra lại";
                return false;
            }

            if (TongTien == "" || TongTien == "0" || TongTien == null)
            {
                DialogOpen = true;
                ThongBao = "Không thể tạo một phiếu nhập rỗng!";
                return false;
            }

            return true;
        }

        public string get_NameofStaff()
        {
            string staff = "Thảo Cute";
            if (LoginViewModel.TaiKhoanSuDung != null)
                staff = LoginViewModel.TaiKhoanSuDung.HoTen;
            return staff;
        }

        public int trans_number_PNK(string maPNK)
        {
            string res = "";
            for (int i = 3; i < maPNK.Length; i++)
                res += maPNK[i];
            return int.Parse(res);
        }

        public string trans_string_PNK(int maPNK)
        {
            string res = maPNK + "";
            int n = 7 - res.Length;
            for (int i = 0; i < n; i++)
                res = "0" + res;
            return res;
        }

        public string create_MaCTPNK()
        {
            string ma = "CTPNK";

            ObservableCollection<CT_PHIEUNHAPKHO> listCTPNK = new ObservableCollection<CT_PHIEUNHAPKHO>(DataProvider.Ins.DB.CT_PHIEUNHAPKHO);

            int max = 0;
            foreach (var pnk in listCTPNK)
            {
                int value = int.Parse(pnk.MaCTPhieuNK.Substring(5));
                if (max < value) max = value;
            }

            max++;
            for (int i = 0; i < 5 - max.ToString().Length; i++) ma += "0";
            return ma += max.ToString();

        }

        public string create_MaCTTK()
        {
            string ma = "CTTK";

            ObservableCollection<CT_THEKHO> listCTTK = new ObservableCollection<CT_THEKHO>(DataProvider.Ins.DB.CT_THEKHO);

            int max = 0;
            foreach (var pnk in listCTTK)
            {
                int value = int.Parse(pnk.MaCTTheKho.Substring(4));
                if (max < value) max = value;
            }

            max++;
            for (int i = 0; i < 6 - max.ToString().Length; i++) ma += "0";
            return ma += max.ToString();

        }

        private string GetCodeTK()
        {
            ObservableCollection<THEKHO> ListTK = new ObservableCollection<THEKHO>(DataProvider.Ins.DB.THEKHOes);
            int tmp = ListTK.Count();
            return "TK" + format((tmp + 1).ToString());
        }

        public void huy_PNK()
        {
            ListMatHang.Clear();
            TongTien = "";
            MaPhieuNhapKho = "";
            DiaChi = "";
            SDT = "";
            Fax = "";
            SelectedItemNCC = null;
            ListNCC = new ObservableCollection<NHACUNGCAP>();
            temp_MH_Mua = ListMatHang;
        }

        public void save_PNK()
        {
            PHIEUNHAPKHO PNK = new PHIEUNHAPKHO()
            {
                MaNCC = NhapHang_ViewModel.mancc_nhaphang,
                MaPhieuNhapKho = MaPhieuNhapKho,
                NgayLap = DateTime.Now,
                TongTien = decimal.Parse(TongTien),
                MaNguoiLap = "1",
                Duyet = 0
            };

            DataProvider.Ins.DB.PHIEUNHAPKHOes.Add(PNK);
            DataProvider.Ins.DB.SaveChanges();

            #region CT_PNK
            foreach (var mh in ListMatHang)
            {
                CT_PHIEUNHAPKHO ct = new CT_PHIEUNHAPKHO()
                {
                    MaCTPhieuNK = create_MaCTPNK(),
                    MaMH = mh.MaMH,
                    MaPhieuNhapKho = MaPhieuNhapKho,
                    SoLuong = int.Parse(mh.SoLuong),
                    DonGiaNhap = decimal.Parse(mh.DonGia),
                };
                DataProvider.Ins.DB.CT_PHIEUNHAPKHO.Add(ct);
                DataProvider.Ins.DB.SaveChanges();

                #region Command của thảo
                //ObservableCollection<THEKHO> ListTK = new ObservableCollection<THEKHO>(DataProvider.Ins.DB.THEKHOes);
                //foreach (var tk in ListTK)
                //{
                //    if (tk.MaMH == mh.MaMH)
                //    {
                //        CT_THEKHO cttk = new CT_THEKHO()
                //        {
                //            MaCTTheKho = create_MaCTTK(),
                //            NgayNhapXuat = DateTime.Now,
                //            MaPhieuNhapXuat = ct.MaCTPhieuNK,
                //            MaTheKho = tk.MaTheKho,
                //            DienGiai = "",
                //        };
                //        DataProvider.Ins.DB.CT_THEKHO.Add(cttk);
                //        DataProvider.Ins.DB.SaveChanges();

                //        tk.SoLuongTonKho += ct.SoLuong;
                //        DataProvider.Ins.DB.SaveChanges();
                //        //MessageBox.Show(tk.SoLuongTonKho + "");
                //    }

                //}
                #endregion
            }
            #endregion 
        }

        public string create_MaPNK()
        {
            string ma = "PNK";

            ObservableCollection<PHIEUNHAPKHO> listPNK = new ObservableCollection<PHIEUNHAPKHO>(DataProvider.Ins.DB.PHIEUNHAPKHOes);

            int max = 0;
            foreach (var pnk in listPNK)
            {
                int value = trans_number_PNK(pnk.MaPhieuNhapKho);
                if (max < value) max = value;
            }
            max++;
            ma += trans_string_PNK(max);
            return ma;

        }
        #endregion

        public NhapHang_ViewModel()
        {
            Init();
            image = null;
            ListNSX = new ObservableCollection<NHASANXUAT>(DataProvider.Ins.DB.NHASANXUATs);
            ListNCC = new ObservableCollection<NHACUNGCAP>(DataProvider.Ins.DB.NHACUNGCAPs);
            ListMH = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);
            NSX = new ObservableCollection<NHASANXUAT>(DataProvider.Ins.DB.NHASANXUATs);
            NCC = new ObservableCollection<NHACUNGCAP>(DataProvider.Ins.DB.NHACUNGCAPs);
            ListMatHang = new ObservableCollection<ListMatHangMua>();

            #region mở/đóng window
            ThemMatHangCommand = new AppCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                InitMH();
                ThemMatHang wd = new ThemMatHang();
                wd.ShowDialog();
            });

            ThemNhaCungCapCommand = new AppCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ThemNhaCungCap wd = new ThemNhaCungCap();
                InitNCC();
                wd.ShowDialog();
                NCC = (wd.DataContext as NhapHang_ViewModel).NCC;
            });

            ThemNhaSanXuatCommand = new AppCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                ThemNhaSanXuat wd = new ThemNhaSanXuat();
                InitNSX();
                wd.ShowDialog();
            });

            ThemHangCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                ThemHangNhap_ViewModel.okAdd = false;
                Window themHANG = new ThemHangNhap_Window();
                themHANG.DataContext = new ThemHangNhap_ViewModel(SelectedItemNCC.MaNCC);
                themHANG.ShowDialog();
                if (ThemHangNhap_ViewModel.okAdd)
                {
                    add_MatHang(ThemHangNhap_ViewModel.maMH, ThemHangNhap_ViewModel.soLuong);
                }
            });

            //đóng
            CloseWindowCommand = new RelayCommand<object>((p) => { return p == null ? false : true; }, (p) => {
                var ex = p as Window;
                ex.Close();
            });
            #endregion

            #region thêm sửa xóa nhà cung cấp 
            AddNCCCommand = new AppCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TenNCC) || string.IsNullOrEmpty(DiaChi) || string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(Fax))
                    return false;

                var tenncc = DataProvider.Ins.DB.NHACUNGCAPs.Where(x => x.TenNCC.ToLower() == TenNCC.ToLower());
                if (tenncc == null || tenncc.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                string mancc = GetCodeNCC();
                var ncc = new NHACUNGCAP()
                {
                    MaNCC = mancc,
                    TenNCC = TenNCC,
                    DiaChi = DiaChi,
                    SDT = SDT,
                    Fax = Fax,
                };

                DataProvider.Ins.DB.NHACUNGCAPs.Add(ncc);
                DataProvider.Ins.DB.SaveChanges();
                NCC.Add(ncc);
                NCC = new ObservableCollection<NHACUNGCAP>(DataProvider.Ins.DB.NHACUNGCAPs);
                ListNCC.Add(ncc);
                InitNCC();
                MessageBox.Show("Thêm thành công");
            });

            AddNCCFromFileCommand = new AppCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                openFileDialog.Multiselect = false;
                openFileDialog.Title = "Open file excel to import books";
                if (openFileDialog.ShowDialog() == true)
                {

                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(openFileDialog.FileName);
                    Excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[1];
                    Excel.Range xlRange = xlWorkSheet.UsedRange;
                    int rowCount = xlRange.Rows.Count;
                    int colCount = xlRange.Columns.Count;

                    for (int i = 2; i <= rowCount; i++)
                    {
                        string mancc = GetCodeNCC();
                        string TenNCC = xlRange.Cells[i, 1].Value.ToString();
                        //MessageBox.Show(TenNCC);
                        string DiaChi = xlRange.Cells[i, 2].Value.ToString();
                        //MessageBox.Show(DiaChi);
                        string SDT = xlRange.Cells[i, 3].Value.ToString();
                        string Fax = xlRange.Cells[i, 4].Value.ToString();
                        var ncc = new NHACUNGCAP()
                        {
                            MaNCC = mancc,
                            TenNCC = TenNCC,
                            DiaChi = DiaChi,
                            SDT = SDT,
                            Fax = Fax,
                        };

                        DataProvider.Ins.DB.NHACUNGCAPs.Add(ncc);
                        DataProvider.Ins.DB.SaveChanges();

                        ListNCC.Add(ncc);
                        NCC = new ObservableCollection<NHACUNGCAP>(DataProvider.Ins.DB.NHACUNGCAPs);
                    }

                    // this.SetSelectedItemToFirstItemOfPage(false);
                    MessageBox.Show("Import thành công!");

                }
            });

            EditNCCCommand = new RelayCommand<object>((p) =>
            {

                if (SelectedItemNCC == null)
                    return false;
                ListNCC = new ObservableCollection<NHACUNGCAP>(DataProvider.Ins.DB.NHACUNGCAPs);
                return true;
            }, (p) =>
            {
                var ncc = DataProvider.Ins.DB.NHACUNGCAPs.Where(x => x.MaNCC == SelectedItemNCC.MaNCC).SingleOrDefault();
                SelectedItemNCC.TenNCC = TenNCC;
                SelectedItemNCC.DiaChi = DiaChi;
                SelectedItemNCC.Fax = Fax;
                SelectedItemNCC.SDT = SDT;
                DataProvider.Ins.DB.SaveChanges();
                OnPropertyChanged("SelectedItemNCC");

                //InitNCC();
                MessageBox.Show("Bạn lưu thành công nhà cung cấp");
            });

            AddNSXCommand = new AppCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TenNSX) || string.IsNullOrEmpty(DiaChiNSX) || string.IsNullOrEmpty(SDTNSX))
                    return false;
                var tennsx = DataProvider.Ins.DB.NHASANXUATs.Where(x => x.TenNSX.ToLower() == TenNSX.ToLower());
                if (tennsx == null || tennsx.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                string mansx = GetCodeNSX();
                var nsx = new NHASANXUAT()
                {
                    MaNSX = mansx,
                    TenNSX = TenNSX,
                    DiaChi = DiaChiNSX,
                    SDT = SDTNSX,
                };
                DataProvider.Ins.DB.NHASANXUATs.Add(nsx);
                DataProvider.Ins.DB.SaveChanges();
                ListNSX.Add(nsx);
                NSX.Add(nsx);
                InitNSX();
                MessageBox.Show("Thêm thành công");
            });


            AddNSXFromFileCommand = new AppCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                openFileDialog.Multiselect = false;
                openFileDialog.Title = "Open file excel to import books";
                if (openFileDialog.ShowDialog() == true)
                {

                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(openFileDialog.FileName);
                    Excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[1];
                    Excel.Range xlRange = xlWorkSheet.UsedRange;
                    int rowCount = xlRange.Rows.Count;
                    int colCount = xlRange.Columns.Count;

                    for (int i = 2; i <= rowCount; i++)
                    {
                        string mansx = GetCodeNSX();
                        string TenNSX = xlRange.Cells[i, 1].Value.ToString();
                        //MessageBox.Show(TenNCC);
                        string DiaChi = xlRange.Cells[i, 2].Value.ToString();
                        //MessageBox.Show(DiaChi);
                        string SDT = xlRange.Cells[i, 3].Value.ToString();

                        var nsx = new NHASANXUAT()
                        {
                            MaNSX = mansx,
                            TenNSX = TenNSX,
                            DiaChi = DiaChi,
                            SDT = SDT,

                        };

                        DataProvider.Ins.DB.NHASANXUATs.Add(nsx);
                        DataProvider.Ins.DB.SaveChanges();
                        NSX.Add(nsx);
                        ListNSX.Add(nsx);
                    }

                    // this.SetSelectedItemToFirstItemOfPage(false);
                    MessageBox.Show("Import thành công!");

                }
            });

            EditNSXCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItemNSX == null)
                    return false;
                ListNSX = new ObservableCollection<NHASANXUAT>(DataProvider.Ins.DB.NHASANXUATs);
                return true;

            }, (p) =>
            {
                var nsx = DataProvider.Ins.DB.NHASANXUATs.Where(x => x.MaNSX == SelectedItemNSX.MaNSX).SingleOrDefault();
                SelectedItemNSX.TenNSX = TenNSX;
                SelectedItemNSX.DiaChi = DiaChiNSX;
                SelectedItemNSX.SDT = SDTNSX;
                DataProvider.Ins.DB.SaveChanges();
                OnPropertyChanged("SelectedItemNSX");
                //InitNSX();
                MessageBox.Show("Bạn lưu thành công nhà sản xuất");

            });

            #endregion

            #region phiếu nhập hàng

            DialogOK = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                DialogOpen = false;
                if (ThongBao == "Lập phiếu nhập hàng thành công!")
                {
                    if (CreateReport)
                    {
                        ObservableCollection<ListMatHangMua> temp = new ObservableCollection<ListMatHangMua>();
                        foreach (var mh in ListMatHang)
                            temp.Add(mh);
                        PhieuNhapHang_PrintPreview_ViewModel x = new PhieuNhapHang_PrintPreview_ViewModel(MaPhieuNhapKho, TenNhanVien, NgayThangNam, SelectedItemNCC.TenNCC, DiaChi, SDT, Fax, TongTien, temp);
                        PhieuNhapHang_PrintPreview pnk = new PhieuNhapHang_PrintPreview(x);
                        pnk.Show();
                    }

                    ListMatHang.Clear();
                    TongTien = "";
                    MaPhieuNhapKho = "";
                    DiaChi = "";
                    SDT = "";
                    Fax = "";
                    SelectedItemNCC = null;
                    ListNCC = new ObservableCollection<NHACUNGCAP>();
                    temp_MH_Mua = ListMatHang;
                }

            });

            GetMaPhieNhapCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                MaPhieuNhapKho = create_MaPNK();
            });

            XoaHangCommand = new RelayCommand<Object>((p) => { if (SelectedMatHang != null) return true; return false; }, (p) =>
            {
                xoa_MatHang();
                temp_MH_Mua = ListMatHang;
            });

            HuyCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                System.Windows.Forms.DialogResult kq = System.Windows.Forms.MessageBox.Show("Bạn có chắc hủy phiếu nhập hàng này không", "Hủy phiếu nhập hàng", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning);

                if (kq == System.Windows.Forms.DialogResult.No) return;
                huy_PNK();

            });

            XacNhanCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                if (check_PN() == false) return;
                ThongBao = "Lập phiếu nhập hàng thành công!";
                save_PNK();
                DialogOpen = true;
            });

            ChangeNCC = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                if (ListMatHang == null || ListMatHang.Count() == 0) return;
                MessageBoxResult res = MessageBox.Show("Bạn có chắc thay đổi nhà cung cấp khi đang thêm mặt hàng? Danh sách mặt hàng sẽ hủy sau đó!!!", "Thay đổi", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)
                {
                    ListMatHang.Clear();
                }
            });
            #endregion

            #region mặt hàng
            AddMHCommand = new AppCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TenMH))
                    return false;
                if (GiaBan <= 0 || GiaNhap <= 0 || SelectedNCC == null || SelectedNSX == null || DonViTinh == null)
                    return false;
                var tenmh = DataProvider.Ins.DB.MATHANGs.Where(x => x.TenMH.ToLower() == TenMH.ToLower());
                if (tenmh == null || tenmh.Count() != 0)
                    return false;
                return true;
            }, (p) =>
            {
                if (GiaBan < GiaNhap)
                {
                    MessageBox.Show("Giá bán phải lớn hơn giá nhập!");
                    return;
                }

                string newFileName = GetImageName();
                /// Copy image to project path
                if (image != null)
                {
                    string destinationFile = GetFullPath(newFileName);
                    try
                    {
                        System.IO.File.Copy(image, destinationFile, true);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi lưu file!");
                    }
                }

                string mamh = GetCodeMH();
                var mathang = new MATHANG()
                {
                    MaMH = mamh,
                    TenMH = TenMH,
                    MaNCC = SelectedNCC.MaNCC,
                    MaNSX = SelectedNSX.MaNSX,
                    SoLuongTonGian = 0,
                    GiaBan = GiaBan,
                    GiaNhap = GiaNhap,
                    DonViTinh = DonViTinh,
                    HinhAnh = image != null ? newFileName : "1-MoSo.png",
                };
                DataProvider.Ins.DB.MATHANGs.Add(mathang);
                DataProvider.Ins.DB.SaveChanges();
                ListMH.Add(mathang);
                MessageBox.Show("Thêm thành công!");

                THEKHO thekho = new THEKHO()
                {
                    MaTheKho = GetCodeTK(),
                    MaMH = mamh,
                    NgayLap = DateTime.Now,
                    MaNguoiLap = "1",
                    SoLuongTonKho = 0,
                };
                DataProvider.Ins.DB.THEKHOes.Add(thekho);
                DataProvider.Ins.DB.SaveChanges();
                InitMH();

            });

            EditMHCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItemMH == null)
                    return false;
                ListMH = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);
                return true;
            }, (p) =>
            {
                string newFileName = GetImageName();
                /// Copy image to project path
                if (image != null)
                {
                    string destinationFile = GetFullPath(newFileName);
                    try
                    {
                        System.IO.File.Copy(image, destinationFile, true);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi lưu file!");
                    }
                }

                var mh = DataProvider.Ins.DB.MATHANGs.Where(x => x.MaMH == SelectedItemMH.MaMH).SingleOrDefault();
                SelectedItemMH.TenMH = TenMH;
                SelectedItemMH.NHACUNGCAP.MaNCC = mh.MaNCC;
                SelectedItemMH.NHASANXUAT.MaNSX = mh.MaNSX;
                SelectedItemMH.GiaNhap = GiaNhap;
                SelectedItemMH.GiaBan = GiaBan;
                SelectedItemMH.DonViTinh = DonViTinh;
                //mh.HinhAnh = image != null ? newFileName : "1-MoSo.png";
                SelectedItemMH.SoLuongTonGian = SoLuongTonGian;
                DataProvider.Ins.DB.SaveChanges();

                image = null;
                OnPropertyChanged("SelectedItemMH");

                //InitMH();
                MessageBox.Show("Bạn lưu thành công mặt hàng");


            });



            AddImage = new AppCommand<object>(
               p => true,
               p =>
               {
                   OpenFileDialog fileDialog = new OpenFileDialog();
                   fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                   if (fileDialog.ShowDialog() == true)
                   {
                       image = fileDialog.FileName;
                       Images = image;
                   }
                   else
                   {
                       image = null;
                   }
               });
            LapPhieuDNNHCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                PhieuDNNH_Window win = new PhieuDNNH_Window();
                win.ShowDialog();
            });
        }

        private string GetFullPath(string fileName)
        {
            string destPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string destinationFile = Path.Combine($"{destPath}\\Images", fileName);
            return destinationFile;
        }

        private string GetImageName()
        {
            /*
            List<String> images = DataProvider.Ins.DB.MATHANGs.Select(b => b.HinhAnh).ToList();
            int max = 0;
            foreach (var el in images)
            {
                string idPart = el.Split('-')[1].Split('.')[0];
                int id;
                if (Int32.TryParse(idPart, out id))
                {
                    if (id > max) max = id;
                }
            }
            max += 1;
            */
            return $"favorite.png"; 
        }

        public void add_MatHang(string ma, int sl)
        {
            ObservableCollection<MATHANG> listMatHang = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);

            foreach (var mh in listMatHang)
            {

                if (mh.MaMH == ma)
                {
                    int stt = ListMatHang.Count + 1;
                    decimal tt = mh.GiaBan * sl;
                    ListMatHangMua mh_them = new ListMatHangMua(stt + "", mh.MaMH, mh.TenMH, mh.DonViTinh, mh.GiaBan + "", sl + "", tt + "");
                    ListMatHang.Add(mh_them);
                    break;
                }
            }

            Cal_TongTien();
        }

        private void Cal_TongTien()
        {
            decimal tongBill = 0;
            foreach (var mh_them in ListMatHang)
                tongBill += decimal.Parse(mh_them.ThanhTien);

            TongTien = tongBill.ToString();
        }

        #endregion

    }
}