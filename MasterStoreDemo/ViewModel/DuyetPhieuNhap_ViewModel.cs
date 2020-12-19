using MasterStoreDemo.Helper;
using MasterStoreDemo.Model;
using MaterialDesignColors.Recommended;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;
using System.IO;

namespace MasterStoreDemo.ViewModel
{
    class DuyetPhieuNhap_ViewModel : BaseViewModel
    {
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
            ObservableCollection<PHIEUNHAPKHO> list_PXK = new ObservableCollection<PHIEUNHAPKHO>(DataProvider.Ins.DB.PHIEUNHAPKHOes);

            foreach (var pxk in list_PXK)
                if (pxk.MaPhieuNhapKho == SelectedPhieu.Ma)
                {
                    pxk.Duyet = 2;
                    DataProvider.Ins.DB.SaveChanges();
                    break;
                }
            ListCTPhieu = new ObservableCollection<ListCTPhieu>();
            init_ListView();
            MessageBox.Show("Phiếu đề nghị đã hủy thành công");
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

        public void update_nhapkho(string maMH, int slnhap)
        {
            ObservableCollection<THEKHO> list_TK = new ObservableCollection<THEKHO>(DataProvider.Ins.DB.THEKHOes);

            string maTK = "";
            foreach (var tk in list_TK)
                if (tk.MaMH == maMH)
                {
                    maTK = tk.MaTheKho;
                    tk.SoLuongTonKho += slnhap;
                    break;
                }

            #region Update chi tiết xuất kho
            CT_THEKHO temp = new CT_THEKHO()
            {
                MaTheKho = maTK,
                MaCTTheKho = create_MaCTTK(),
                NgayNhapXuat = DateTime.Now,
                DienGiai = "",
                MaPhieuNhapXuat = maPhieuDuyet,
            };

            //MessageBox.Show(temp.MaTheKho + " " + temp.MaCTTheKho + " " + temp.MaPhieuNhapXuat);
            DataProvider.Ins.DB.CT_THEKHO.Add(temp);
            DataProvider.Ins.DB.SaveChanges();
            #endregion
        }

        public void duyet()
        {
            if (SelectedPhieu == null)
                return;

            ObservableCollection<CT_PHIEUNHAPKHO> list_CTNK = new ObservableCollection<CT_PHIEUNHAPKHO>(DataProvider.Ins.DB.CT_PHIEUNHAPKHO);

            foreach (var ct in list_CTNK)
                if (ct.MaPhieuNhapKho == SelectedPhieu.Ma)
                {
                    maPhieuDuyet = ct.MaPhieuNhapKho;
                    update_nhapkho(ct.MaMH, ct.SoLuong);
                }

            ObservableCollection<PHIEUNHAPKHO> list_PXK = new ObservableCollection<PHIEUNHAPKHO>(DataProvider.Ins.DB.PHIEUNHAPKHOes);

            foreach (var pxk in list_PXK)
                if (pxk.MaPhieuNhapKho == SelectedPhieu.Ma)
                {
                    pxk.Duyet = 1;
                    DataProvider.Ins.DB.SaveChanges();
                    break;
                }

            MessageBox.Show("Đã duyệt phiếu mua hàng");
            init_ListView();
            init_ListCTPhieu("");
        }

        public void init_ListCTPhieu(string maPhieu)
        {
            ObservableCollection<CT_PHIEUNHAPKHO> list_CTXK = new ObservableCollection<CT_PHIEUNHAPKHO>(DataProvider.Ins.DB.CT_PHIEUNHAPKHO);
            ListCTPhieu = new ObservableCollection<ListCTPhieu>();
            int stt = 1;

            foreach (var ct in list_CTXK)
                if (ct.MaPhieuNhapKho == maPhieu)
                {
                    ListCTPhieu temp = new ListCTPhieu(stt.ToString(), ct.MaMH, ct.MATHANG.TenMH, ct.SoLuong.ToString());
                    stt++;
                    ListCTPhieu.Add(temp);
                }
        }

        public void init_ListView()
        {
            ObservableCollection<PHIEUNHAPKHO> list_PXK = new ObservableCollection<PHIEUNHAPKHO>(DataProvider.Ins.DB.PHIEUNHAPKHOes);


            ObservableCollection<ListPhieu> ListPhieu_temp = new ObservableCollection<ListPhieu>();

            int stt = 1;

            foreach (var phieu in list_PXK)
                if (phieu.Duyet == 0)
                {
                    string nguoilap = phieu.NGUOIDUNG.HoTen;
                    ListPhieu temp = new ListPhieu(stt.ToString(), phieu.MaPhieuNhapKho, phieu.NgayLap.ToString("dd/MM/yyyy"),nguoilap);
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

        #region Icommand
        public ICommand DuyetCommand { get; set; }
        public ICommand KhongDuyetCommand { get; set; }
        public ICommand SelectionChangedCommand { get; set; }
        #endregion
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

        public DuyetPhieuNhap_ViewModel()
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
