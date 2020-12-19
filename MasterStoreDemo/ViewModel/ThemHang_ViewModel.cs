using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Collections.ObjectModel;
using MasterStoreDemo.Model;
using MasterStoreDemo.Helper;

namespace MasterStoreDemo.ViewModel
{
    public class ThemHang_ViewModel : BaseViewModel
    {
        #region Sub Functions

        public void init_ListView()
        {
            ObservableCollection<MATHANG> listMatHang = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);
            ListMatHang = new ObservableCollection<ListMatHangThem>();
            int stt = 1;
            foreach (var mh in listMatHang)
            {
                ListMatHangThem mh_them = new ListMatHangThem(stt + "", mh.MaMH, mh.TenMH, mh.GiaBan + "", mh.SoLuongTonGian - get_SoLuongDaMua(mh.MaMH)+ "");
                ListMatHang.Add(mh_them);
                stt++;
            }
        }

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

        public void search_MatHang(string ma, string ten)
        {
            ObservableCollection<MATHANG> listMatHang = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);
            ListMatHang = new ObservableCollection<ListMatHangThem>();
            int stt = 1;
            foreach (var mh in listMatHang)
                if (duyet_MatHang(mh,ma,ten)) 
                {
                    ListMatHangThem mh_them = new ListMatHangThem(stt + "", mh.MaMH, mh.TenMH, mh.GiaBan + "", mh.SoLuongTonGian - get_SoLuongDaMua(mh.MaMH) + "");
                    ListMatHang.Add(mh_them);
                    stt++;
                }
        }

        public bool check_AllNumber(string str)
        {
            if (str == null) return false;

            for (int i = 0; i < str.Length; i++)
                if (str[i] < '0' || str[i] > '9')
                    return false;
            return true;
        }

        public int get_SoLuongQuay(string maMH)
        {
            ObservableCollection<MATHANG> list = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);

            foreach (var mh in list)
                if (mh.MaMH == maMH)
                {
                    return mh.SoLuongTonGian - get_SoLuongDaMua(maMH);
                }

            return 0;
        }

        public void add_MatHang()
        {
            if (check_AllNumber(SoLuong)==false)
            {
                MessageBox.Show("Số lượng chỉ được chứa ký tự số! Mời bạn nhập lại");
                SoLuong = "1";
                return;
            }

            int sl = int.Parse(SoLuong);
            if (sl == 0)
            {
                MessageBox.Show("Số lượng không thể bằng 0");
                return;
            }

            if (sl > get_SoLuongQuay(maMH))
            {
                MessageBox.Show("Mặt hàng này không đủ số lượng! Cần phải lập phiếu đề nghị xuất hàng");
                return;
            }
            MessageBox.Show("Bạn đã săn phẩm thành công");
            okAdd = true;
            soLuong = sl;
        }


        public int get_SoLuongDaMua(string maMH)
        {
            ObservableCollection<ListMatHangMua> list = BanHang_ViewModel.temp_MH_Mua;

            int sl = 0;
            foreach (var mh in list)
                if (mh.MaMH == maMH)
                    sl += int.Parse(mh.SoLuong);

            return sl;
        }
        #endregion

        #region Declare Variable
        private ObservableCollection<ListMatHangThem> _ListMatHang;
        public ObservableCollection<ListMatHangThem> ListMatHang
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

        private string _SoLuong;
        public string SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; OnPropertyChanged(); }
        }

        private ListMatHangThem _SelectedMatHang;
        public ListMatHangThem SelectedMatHang
        {
            get { return _SelectedMatHang; }
            set { _SelectedMatHang = value; OnPropertyChanged(); }
        }
        #endregion

        #region Declare Icommand
        public ICommand ThoatCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand ThemHangCommand { get; set; }
        public ICommand SelectionChangedCommand { get; set; }
        #endregion

        #region Declare Static Variables
        public static string maMH { get; set; }
        public static int soLuong { get; set; }
        public static bool okAdd { get; set; }
        #endregion

        public ThemHang_ViewModel()
        {
            okAdd = false;
            init_ListView();
            ThoatCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                p.Close();
            });

            SearchCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                search_MatHang(txtMaMH,txtTenMH);
            });

            ThemHangCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                add_MatHang();
                if (okAdd)
                    ThoatCommand.Execute(p);
            });


            SelectionChangedCommand = new RelayCommand<Window>((p) => { if (SelectedMatHang!=null) return true; return false; }, (p) => {
                MaMH = SelectedMatHang.Ten;
                maMH = SelectedMatHang.Ma;
                SoLuong = "1";
            });
        }
    }
}
