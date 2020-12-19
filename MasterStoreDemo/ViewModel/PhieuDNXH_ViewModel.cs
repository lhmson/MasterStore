using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Drawing;
using System.Collections.ObjectModel;
using MasterStoreDemo.Helper;
using MasterStoreDemo.Model;
using System.Windows.Forms;
using MasterStoreDemo.View;

namespace MasterStoreDemo.ViewModel
{
    public class PhieuDNXH_ViewModel : BaseViewModel
    {
        #region Declare Variables

        private ObservableCollection<ListMatHangKho> _ListMHDN;
        public ObservableCollection<ListMatHangKho> ListMHDN
        {
            get { return _ListMHDN; }
            set { _ListMHDN = value; OnPropertyChanged(); }
        }

        private string _MaPhieu;
        public string MaPhieu
        {
            get { return _MaPhieu; }
            set { _MaPhieu = value; OnPropertyChanged(); }
        }

        private string _Quay;
        public string Quay
        {
            get { return _Quay; }
            set { _Quay = value; OnPropertyChanged(); }
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

        private string _TongSoLuong;
        public string TongSoLuong
        {
            get { return _TongSoLuong; }
            set { _TongSoLuong = value; OnPropertyChanged(); }
        }

        private ObservableCollection<ListMatHangKho> _ListMatHang;
        public ObservableCollection<ListMatHangKho> ListMatHang
        {
            get { return _ListMatHang; }
            set { _ListMatHang = value; OnPropertyChanged(); }
        }

        private string _txtMaMH;
        public string txtMaMH
        {
            get { return _txtMaMH; }
            set { _txtMaMH = value; OnPropertyChanged(); }
        }

        private string _txtTenMH;
        public string txtTenMH
        {
            get { return _txtTenMH; }
            set { _txtTenMH = value; OnPropertyChanged(); }
        }

        private string _MaMH;
        public string MaMH
        {
            get { return _MaMH; }
            set { _MaMH = value; OnPropertyChanged(); }
        }

        private string _TenMH;
        public string TenMH
        {
            get { return _TenMH; }
            set { _TenMH = value; OnPropertyChanged(); }
        }

        private string _SoLuong;
        public string SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; OnPropertyChanged(); }
        }

        private ListMatHangKho _SelectedMatHang;
        public ListMatHangKho SelectedMatHang
        {
            get { return _SelectedMatHang; }
            set { _SelectedMatHang = value; OnPropertyChanged(); }
        }
        #endregion

        #region Declare Icommand
        public ICommand CloseWindowCommand { get; set; }
        public ICommand ThemCommand { get; set; }
        public ICommand XemDSCommand { get; set; }
        public ICommand TaoPhieuCommand { get; set; }
        public ICommand HuyPhieuCommand { get; set; }
        public ICommand SelectionChangedCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        #endregion

        #region Sub Functions

        public bool duyet_MatHang(MATHANG mh, string ma, string ten)
        {
            if (!String.IsNullOrWhiteSpace(ma))
            {
                return (mh.MaMH.ToLower().Contains(ma.ToLower()));
            }

            if (!String.IsNullOrWhiteSpace(ten))
            {
                return mh.TenMH.ToLower().Contains(ten.ToLower());
            }

            return true;
        }

        public string get_TonKho(string maHD)
        {
            ObservableCollection<THEKHO> list_tk = new ObservableCollection<THEKHO>(DataProvider.Ins.DB.THEKHOes);
            
            int res = 0;

            foreach (var tk in list_tk)
                if (tk.MaMH == maHD)
                    res = tk.SoLuongTonKho;

            return res.ToString();
        }

        public void search()
        {
            ListMatHang.Clear();

            ObservableCollection<MATHANG> list_mh = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);

            int stt = 1;
            foreach (var mh in list_mh)
                if (duyet_MatHang(mh, txtMaMH, txtTenMH))
                {
                    ListMatHangKho mh_kho = new ListMatHangKho(stt + "", mh.MaMH, mh.TenMH, get_TonKho(mh.MaMH));
                    ListMatHang.Add(mh_kho);
                    stt++;
                }
        }

        public void Load()
        {
            ListMHDN = new ObservableCollection<ListMatHangKho>();
            ListMatHang = new ObservableCollection<ListMatHangKho>();

            Quay = "Quầy số 1";
            TenNhanVien = "Sơn";

            if (LoginViewModel.TaiKhoanSuDung != null)
            TenNhanVien = LoginViewModel.TaiKhoanSuDung.HoTen;

            if (LoginViewModel.Quay != null)
                Quay = LoginViewModel.Quay.TenQuay;

            NgayLap = DateTime.Now.ToString("dd/MM/yyyy");
            TongSoLuong = "0";

            MaPhieu = "MÃ PHIẾU : " + create_MaPhieuDN("PDN");
        }

        public bool check_AllNumber(string str)
        {
            if (str == null) return false;

            for (int i = 0; i < str.Length; i++)
                if (str[i] < '0' || str[i] > '9')
                    return false;
            return true;
        }

        public string check_ThemYeuCau()
        {
            string error = "";

            if (!check_AllNumber(SoLuong))
            {
                error = "Số lượng nhập không đúng! Mời bạn kiểm tra lại cú pháp";
                return error;
            }

            int sl_kho = int.Parse(get_TonKho(MaMH));
            if (sl_kho < int.Parse(SoLuong))
            {
                error = "Số lượng tại kho không đủ, vui lòng kiểm trai lại!";
                return error;
            }

            foreach (var mh_dathem in ListMHDN)
                if (mh_dathem.Ma == MaMH)
                {
                    error = "Mặt hàng này đã được có trong yêu cầu! Không thể yêu cầu trùng mặt hàng";
                    return error;
                }    

            return error;
        }

        public void them_YeuCau(string maMH, string ten, string sl)
        {
            string stt = (ListMHDN.Count +1 ).ToString();

            ListMatHangKho mh_kho = new ListMatHangKho(stt, maMH, ten, sl);

            ListMHDN.Add(mh_kho);
        }

        public string create_MaPhieuDN(string dauchuoi)
        {
            ObservableCollection<PHIEUXUATKHO> list_phieu = new ObservableCollection<PHIEUXUATKHO>(DataProvider.Ins.DB.PHIEUXUATKHOes);

            int max = 0;
            foreach (var phieu in list_phieu)
            {
                int value = int.Parse(phieu.MaPhieuXK.Substring(3));
                if (max < value) max = value;
            }

            max++;

            string ma = dauchuoi;

            for (int i = 0; i < 5 - max.ToString().Length; i++)
                ma += "0";

            ma += max + "";

            return ma;
        }

        public string create_MaPhieuCTPDN()
        {
            ObservableCollection<CT_PHIEUXUATKHO> list_phieu = new ObservableCollection<CT_PHIEUXUATKHO>(DataProvider.Ins.DB.CT_PHIEUXUATKHO);

            int max = 0;
            foreach (var phieu in list_phieu)
            {
                int value = int.Parse(phieu.MaCTPhieuXK.Substring(4));
                if (max < value) max = value;
            }

            max++;

            string ma = "CTXK";

            for (int i = 0; i < 5 - max.ToString().Length; i++)
                ma += "0";

            ma += max + "";

            return ma;
        }

        public string get_DonGia(string maMH)
        {
            ObservableCollection<MATHANG> list_MH = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);

            foreach (var mh in list_MH)
                if (mh.MaMH == maMH)
                    return mh.GiaBan.ToString();

            return "0";
        }
        public void save_PhieuDN()
        {
            string maPhieu = create_MaPhieuDN("PDN");

            PHIEUXUATKHO phieu = new PHIEUXUATKHO()
            {
                MaPhieuXK = maPhieu,
                NgayLap = DateTime.Now,
                MaQuay = LoginViewModel.Quay.MaQuay,
                MaNguoiLap = LoginViewModel.TaiKhoanSuDung.MaNguoiDung,
                TrangThai = 0
            };

            DataProvider.Ins.DB.PHIEUXUATKHOes.Add(phieu);
            DataProvider.Ins.DB.SaveChanges();

            #region Lưu chi tiết phiếu
            
            foreach (var mh_dn in ListMHDN)
            {
                CT_PHIEUXUATKHO ct_phieu = new CT_PHIEUXUATKHO()
                {
                    MaCTPhieuXK = create_MaPhieuCTPDN(),
                    MaPhieuXK = maPhieu,
                    MaMH = mh_dn.Ma,
                    DonGia = decimal.Parse(get_DonGia(mh_dn.Ma)),
                    SoLuong = int.Parse(mh_dn.Ton),
                    GhiChu = ""
                };
                DataProvider.Ins.DB.CT_PHIEUXUATKHO.Add(ct_phieu);
                DataProvider.Ins.DB.SaveChanges();
            }
            #endregion
        }

        #endregion

        public PhieuDNXH_ViewModel()
        {
            Load();

            CloseWindowCommand = new RelayCommand<Window>((p) => { return p == null ? false : true; }, (p) => {
                p.Close();
            });

            SearchCommand = new RelayCommand<Object>((p) => { return true; }, (p) => {
                search();
            });

            SelectionChangedCommand = new RelayCommand<Window>((p) => { if (SelectedMatHang != null) return true; return false; }, (p) => {
                MaMH = SelectedMatHang.Ma;
                TenMH = SelectedMatHang.Ten;
                SoLuong = SelectedMatHang.Ton;
            });

            HuyPhieuCommand = new RelayCommand<Window>((p) => { if (TongSoLuong != "0") return true; return false; }, (p) => {
                Load();
            });

            ThemCommand = new RelayCommand<Window>((p) => {  return true;}, (p) => {
                string error = check_ThemYeuCau();
                if (error != "")
                {
                    System.Windows.MessageBox.Show(error);
                    return;
                }

                System.Windows.MessageBox.Show("Bạn đã thêm đề xuất mặt hàng này thành công");
                TongSoLuong = int.Parse(TongSoLuong) + 1 + "";
                them_YeuCau(MaMH, TenMH, SoLuong);
            });

            TaoPhieuCommand = new RelayCommand<Window>((p) => { if (TongSoLuong != "0") return true; return false; }, (p) => {
                System.Windows.MessageBox.Show("Bạn đã tạo phiếu đề nghị xuất hàng thành công");
                save_PhieuDN();
                Load();
            });

            XemDSCommand = new RelayCommand<Window>((p) => { if (TongSoLuong != "0") return true; return false; }, (p) => {
                PDNXH_PrintPreview win = new PDNXH_PrintPreview();
                win.ShowDialog();
            });
        }
    } 
};