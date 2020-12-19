﻿using MasterStoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace MasterStoreDemo.ViewModel
{
    public class QuanLyNhanSu_ViewModel : BaseViewModel
    {

        #region Tooltips
        private Visibility _Visibility_1;
        public Visibility Visibility_1
        {
            get => _Visibility_1;
            set { _Visibility_1 = value; OnPropertyChanged(); }
        }

        private Visibility _Visibility_2;
        public Visibility Visibility_2
        {
            get => _Visibility_2;
            set { _Visibility_2 = value; OnPropertyChanged(); }
        }

        private Visibility _Visibility_3;
        public Visibility Visibility_3
        {
            get => _Visibility_3;
            set { _Visibility_3 = value; OnPropertyChanged(); }
        }

        private Visibility _Visibility_4;
        public Visibility Visibility_4
        {
            get => _Visibility_4;
            set { _Visibility_4 = value; OnPropertyChanged(); }
        }

        private string _Error1;
        public string Error1
        {
            get => _Error1;
            set { _Error1 = value; OnPropertyChanged(); }
        }


        private string _Error2;
        public string Error2
        {
            get => _Error2;
            set { _Error2 = value; OnPropertyChanged(); }
        }


        private string _Error3;
        public string Error3
        {
            get => _Error3;
            set { _Error3 = value; OnPropertyChanged(); }
        }


        private string _Error4;
        public string Error4
        {
            get => _Error4;
            set { _Error4 = value; OnPropertyChanged(); }
        }
        #endregion

        #region Variables
        private bool isEdit;


        private bool _DialogOpen;
        public bool DialogOpen { get => _DialogOpen; set { _DialogOpen = value; OnPropertyChanged(); } }

        private string _ThongBao;
        public string ThongBao { get => _ThongBao; set { _ThongBao = value; OnPropertyChanged(); } }

        private ObservableCollection<NhanVien> _ListNhanVien;
        public ObservableCollection<NhanVien> ListNhanVien
        {
            get => _ListNhanVien;
            set { _ListNhanVien = value; OnPropertyChanged(); }
        }

        private ObservableCollection<NHOMNGUOIDUNG> _ListNhomNguoiDung;
        public ObservableCollection<NHOMNGUOIDUNG> ListNhomNguoiDung
        {
            get => _ListNhomNguoiDung;
            set { _ListNhomNguoiDung = value; OnPropertyChanged(); }
        }

        private ObservableCollection<BangPhanQuyen> _ListPhanQuyen;
        public ObservableCollection<BangPhanQuyen> ListPhanQuyen
        {
            get => _ListPhanQuyen;
            set { _ListPhanQuyen = value; OnPropertyChanged(); }
        }

        private NhanVien _SelectedItemNguoiDung;
        public NhanVien SelectedItemNguoiDung
        {
            get => _SelectedItemNguoiDung;
            set { _SelectedItemNguoiDung = value; OnPropertyChanged(); }
        }

        private NHOMNGUOIDUNG _SelectedItemNhomNguoiDung;
        public NHOMNGUOIDUNG SelectedItemNhomNguoiDung
        {
            get => _SelectedItemNhomNguoiDung;
            set { _SelectedItemNhomNguoiDung = value; OnPropertyChanged(); }
        }

        private BangPhanQuyen _SelectedPhanQuyen;
        public BangPhanQuyen SelectedPhanQuyen
        {
            get => _SelectedPhanQuyen;
            set { _SelectedPhanQuyen = value; OnPropertyChanged(); }
        }

        private int _SelectedIndexCbb;
        public int SelectedIndexCbb
        {
            get => _SelectedIndexCbb;
            set { _SelectedIndexCbb = value; OnPropertyChanged(); }
        }

        // Visibility of add elements
        private Visibility _VisibilityOfAdd;
        public Visibility VisibilityOfAdd
        {
            get => _VisibilityOfAdd;
            set { _VisibilityOfAdd = value; OnPropertyChanged(); }
        }

        // Visibility of edit elements
        private Visibility _VisibilityOfEdit;
        public Visibility VisibilityOfEdit
        {
            get => _VisibilityOfEdit;
            set { _VisibilityOfEdit = value; OnPropertyChanged(); }
        }

        // Visibility of listview NGUOIDUNG
        private Visibility _VisibilityOfListNguoiDung;
        public Visibility VisibilityOfListNguoiDung
        {
            get => _VisibilityOfListNguoiDung;
            set { _VisibilityOfListNguoiDung = value; OnPropertyChanged(); }
        }

        private Visibility _VisibilityOfListPhanQuyen;
        public Visibility VisibilityOfListPhanQuyen
        {
            get => _VisibilityOfListPhanQuyen;
            set { _VisibilityOfListPhanQuyen = value; OnPropertyChanged(); }
        }

        private Visibility _VisibilityOfTenNhomQuyen;
        public Visibility VisibilityOfTenNhomQuyen
        {
            get => _VisibilityOfTenNhomQuyen;
            set { _VisibilityOfTenNhomQuyen = value; OnPropertyChanged(); }
        }
        //TenDangNhap
        private string _TenDangNhap;
        public string TenDangNhap
        {
            get => _TenDangNhap;
            set { _TenDangNhap = value; OnPropertyChanged(); }
        }

        //Tên thanh trên bảng List
        private string _TenDanhSachNhom;
        public string TenDanhSachNhom
        {
            get => _TenDanhSachNhom;
            set { _TenDanhSachNhom = value; OnPropertyChanged(); }
        }

        private string _txtTenNhomQuyen;
        public string txtTenNhomQuyen
        {
            get => _txtTenNhomQuyen;
            set { _txtTenNhomQuyen = value; OnPropertyChanged(); }
        }
        //MatKhau
        private string _MatKhau;
        public string MatKhau
        {
            get => _MatKhau;
            set { _MatKhau = value; OnPropertyChanged(); }
        }

        //Hoten
        private string _HoTen;
        public string HoTen
        {
            get => _HoTen;
            set { _HoTen = value; OnPropertyChanged(); }
        }

        //Ten nhomquyen
        private List<string> _TenNhom;
        public List<string> TenNhom
        {
            get => _TenNhom;
            set { _TenNhom = value; OnPropertyChanged(); }
        }


        private ObservableCollection<string> _CbxTenNhom;
        public ObservableCollection<string> CbxTenNhom
        {
            get { return _CbxTenNhom; }
            set { _CbxTenNhom = value; OnPropertyChanged(); }
        }

        private string _TextTenNhom;
        public string TextTenNhom
        {
            get { return _TextTenNhom; }
            set { _TextTenNhom = value; OnPropertyChanged(); }
        }
        private string _SelectedTenNhom;
        public string SelectedTenNhom
        {
            get { return _SelectedTenNhom; }
            set { _SelectedTenNhom = value; OnPropertyChanged(); }
        }



        #endregion

        #region Function

        private void Reset()
        {
            SelectedItemNguoiDung = null;
            SelectedItemNhomNguoiDung = null;
            if (SelectedPhanQuyen != null)
            {
                BangPhanQuyen PQ = SelectedPhanQuyen;
                PQ.EnabledCheckBox = false;
                foreach (var pq in ListPhanQuyen)
                    if (pq.TenNhomQuyen == PQ.TenNhomQuyen)
                    {
                        ListPhanQuyen.Remove(pq);
                        ListPhanQuyen.Add(PQ);
                        SelectedPhanQuyen = PQ;
                        break;
                    }
                isEdit = true;
            }
            SelectedPhanQuyen = null;
        }

        private bool check_hasaWhiteSpace(string chuoi)
        {
            if (chuoi == null) return false;
            foreach (var item in chuoi)
                if (item == ' ')
                    return true;
            return false;
        }

        private bool check_hasallWhiteSpace(string chuoi)
        {
            if (chuoi == null) return false;
            foreach (var item in chuoi)
                if (item != ' ')
                    return false;
            return true;
        }

        public bool Check_TenNhomQuyen(string name)
        {
            ObservableCollection<NHOMNGUOIDUNG> nhom = new ObservableCollection<NHOMNGUOIDUNG>(DataProvider.Ins.DB.NHOMNGUOIDUNGs);

            foreach (var item in nhom)
                if (item.TenNhom.ToUpper() == name.ToUpper())
                    return true;

            return false;
        }

        public int CreateCodeNhomNguoiDung()
        {
            ObservableCollection<NHOMNGUOIDUNG> listNhom = new ObservableCollection<NHOMNGUOIDUNG>(DataProvider.Ins.DB.NHOMNGUOIDUNGs);
            int max = 0;
            foreach (var item in listNhom)
                if (max < item.MaNhom)
                    max = item.MaNhom;
            return max + 1;
        }

        private void LoadData()
        {
            ObservableCollection<NGUOIDUNG> ListNguoiDung = new ObservableCollection<NGUOIDUNG>(DataProvider.Ins.DB.NGUOIDUNGs);
            ListNhomNguoiDung = new ObservableCollection<NHOMNGUOIDUNG>(DataProvider.Ins.DB.NHOMNGUOIDUNGs);

            var nhanvien = from ng_Dung in ListNguoiDung
                           join nhom in ListNhomNguoiDung on ng_Dung.MaNhom equals nhom.MaNhom
                           select new NhanVien(ng_Dung.TenDangNhap, ng_Dung.MatKhau, ng_Dung.HoTen, nhom.TenNhom);
            ListNhanVien = new ObservableCollection<NhanVien>(nhanvien);

            VisibilityOfAdd = Visibility.Hidden;
            VisibilityOfEdit = Visibility.Hidden;

            // choosing list NguoiDung
            SelectedIndexCbb = 0;

            CbxTenNhom = new ObservableCollection<string>();
            foreach (var Nhom in ListNhomNguoiDung)
                CbxTenNhom.Add(Nhom.TenNhom);
        }

        public int search_MaNhom(string TenNhom)
        {
            int ma = 0;

            ObservableCollection<NHOMNGUOIDUNG> ListNhomNguoiDung = new ObservableCollection<NHOMNGUOIDUNG>(DataProvider.Ins.DB.NHOMNGUOIDUNGs);

            foreach (var nhom in ListNhomNguoiDung)
                if (nhom.TenNhom == TenNhom)
                    return nhom.MaNhom;
            return ma;
        }

        private void LoadDataPhanQuyen()
        {
            ListPhanQuyen = new ObservableCollection<BangPhanQuyen>();
            ObservableCollection<NHOMNGUOIDUNG> nhomNguoiDung = new ObservableCollection<NHOMNGUOIDUNG>(DataProvider.Ins.DB.NHOMNGUOIDUNGs);

            foreach (var item in nhomNguoiDung)
                ListPhanQuyen.Add(new BangPhanQuyen(item.TenNhom, false));
        }

        private string check_DeleteNhomNguoiDung(int maNhom)
        {
            ObservableCollection<NGUOIDUNG> ngDung = new ObservableCollection<NGUOIDUNG>(DataProvider.Ins.DB.NGUOIDUNGs);

            string res = "";
            foreach (var item in ngDung)
                if (item.MaNhom == maNhom)
                    res += item.HoTen + "\n";
            return res;

        }

        private void ResetCbxTenNhom()
        {
            Visibility vsAdd = VisibilityOfAdd;
            Visibility vsEdit = VisibilityOfEdit;
            VisibilityOfAdd = Visibility.Visible;
            VisibilityOfEdit = Visibility.Visible;
            CbxTenNhom.Clear();

            ObservableCollection<NHOMNGUOIDUNG> List_Nhom = new ObservableCollection<NHOMNGUOIDUNG>(DataProvider.Ins.DB.NHOMNGUOIDUNGs);
            foreach (var Nhom in List_Nhom)
            {
                CbxTenNhom.Add(Nhom.TenNhom);
            }
            VisibilityOfAdd = vsAdd;
            VisibilityOfEdit = vsEdit;
        }

        private bool CheckValidData()
        {
            if (VisibilityOfAdd == Visibility.Visible)
            {
                if (string.IsNullOrEmpty(TenDangNhap))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(MatKhau))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(HoTen))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(SelectedTenNhom))
                {
                    return false;
                }
                var tenDangNhap = DataProvider.Ins.DB.NGUOIDUNGs.Where(x => x.TenDangNhap == TenDangNhap);
                if (tenDangNhap == null || tenDangNhap.Count() != 0)
                    return false;
                return true;
            }
            else if (VisibilityOfEdit == Visibility.Visible)
            {
                if (string.IsNullOrEmpty(MatKhau))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(HoTen))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(SelectedTenNhom))
                {
                    return false;
                }
            }
            return true;
        }
        private void ResetTextbox()
        {
            TenDangNhap = "";
            MatKhau = "";
            HoTen = "";
            TextTenNhom = "";
            SelectedTenNhom = null;
        }

        private void Add_PhanQuyen(int maNhom, int maChucNang)
        {
            PHANQUYEN PQ = new PHANQUYEN();
            PQ.MaNhom = maNhom;
            PQ.MaChucNang = maChucNang;
            DataProvider.Ins.DB.PHANQUYENs.Add(PQ);
            DataProvider.Ins.DB.SaveChanges();
        }

        private void Delete_PhanQuyen(int maNhom)
        {
            ObservableCollection<PHANQUYEN> listPhanQuyen = new ObservableCollection<PHANQUYEN>(DataProvider.Ins.DB.PHANQUYENs);
            foreach (var pq in listPhanQuyen)
                if (pq.MaNhom == maNhom)
                    DataProvider.Ins.DB.PHANQUYENs.Remove(pq);
            DataProvider.Ins.DB.SaveChanges();
        }

        private void Delete_NhomNguoiDung(string tenNhom)
        {
            ObservableCollection<NHOMNGUOIDUNG> nhom = new ObservableCollection<NHOMNGUOIDUNG>(DataProvider.Ins.DB.NHOMNGUOIDUNGs);
            foreach (var item in nhom)
                if (item.TenNhom == tenNhom)
                    DataProvider.Ins.DB.NHOMNGUOIDUNGs.Remove(item);
            DataProvider.Ins.DB.SaveChanges();
        }
        #endregion

        #region ICommand
        public ICommand AddNguoiDungCommand { get; set; }
        public ICommand EditNguoiDungCommand { get; set; }
        public ICommand DeleteNguoiDungKCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ICommand CbbSelectionChangedCommand { get; set; }
        public ICommand DialogOK { get; set; }
        #endregion

        #region Function ToolTips
        private void Tat_ToolTip_1()
        {
            if (Error1 == "") Visibility_1 = Visibility.Hidden;
            if (Error2 == "") Visibility_2 = Visibility.Hidden;
            if (Error3 == "") Visibility_3 = Visibility.Hidden;
            if (Error4 == "") Visibility_4 = Visibility.Hidden;
        }

        private void Tat_ToolTip()
        {
            Visibility_1 = Visibility_2 = Visibility_3 = Visibility_4 = Visibility.Hidden;
            Error1 = Error2 = Error3 = Error4 = "";
        }

        private bool Check_ThemNhanVien()
        {
            Tat_ToolTip();
            bool check = true;
            if (TenDangNhap == null || TenDangNhap == "")
            {
                Error1 = "Tên đăng nhập không được để trống";
                Visibility_1 = Visibility.Visible;
                check = false;
            }
            else if (check_hasaWhiteSpace(TenDangNhap))
            {
                Error1 = "Tên đăng nhập không được chứa khoảng trắng";
                Visibility_1 = Visibility.Visible;
                check = false;
            }
            else
            {
                ObservableCollection<NGUOIDUNG> list_ngdung = new ObservableCollection<NGUOIDUNG>(DataProvider.Ins.DB.NGUOIDUNGs);

                foreach (var item in list_ngdung)
                {
                    if (item.TenDangNhap == TenDangNhap)
                    {
                        Error1 = "Tên đăng nhập đã tồn tại rồi";
                        Visibility_1 = Visibility.Visible;
                        check = false;
                        break;
                    }
                }
            }

            if (MatKhau == null || MatKhau == "")
            {
                Error2 = "Mật khẩu không được để trống";
                Visibility_2 = Visibility.Visible;
                check = false;
            }

            if (HoTen == null || HoTen == "" || check_hasallWhiteSpace(HoTen))
            {
                Error3 = "Họ tên không được để trống";
                Visibility_3 = Visibility.Visible;
                check = false;
            }
            if (SelectedTenNhom == null)
            {
                Error4 = "Chưa chọn vị trí nhóm quyền";
                Visibility_4 = Visibility.Visible;
                check = false;
            }
            Tat_ToolTip_1();
            return check;
        }

        private bool check_SuaNhanVien()
        {
            bool check = true;
            if (MatKhau == null || MatKhau == "")
            {
                Error1 = "Mật khẩu không được để trống";
                Visibility_1 = Visibility.Visible;
                check = false;
            }
            if (HoTen == null || HoTen == "" || check_hasallWhiteSpace(HoTen))
            {
                Error2 = "Họ tên không được để trống";
                Visibility_2 = Visibility.Visible;
                check = false;
            }
            if (SelectedTenNhom == null)
            {
                Error3 = "Chưa chọn vị trí nhóm quyền";
                Visibility_3 = Visibility.Visible;
                check = false;
            }
            Tat_ToolTip_1();
            return check;
        }

        private bool check_ThemNhomQuyen()
        {
            bool check = true;
            if (txtTenNhomQuyen == null || txtTenNhomQuyen == "" || check_hasallWhiteSpace(txtTenNhomQuyen))
            {
                Error1 = "Tên nhóm không để trống";
                Visibility_1 = Visibility.Visible;
                check = false;
            }
            if (Check_TenNhomQuyen(txtTenNhomQuyen))
            {
                Error1 = "Nhóm " + txtTenNhomQuyen + " đã tồn tại! Vui lòng nhập lại tên nhóm khác!";
                Visibility_1 = Visibility.Visible;
                check = false;
            }
            Tat_ToolTip_1();
            return check;
        }
        #endregion

        public int getNewID_NGUOIDUNG()
        {
            ObservableCollection<NGUOIDUNG> listNguoiDung = new ObservableCollection<NGUOIDUNG>(DataProvider.Ins.DB.NGUOIDUNGs);

            int max = 0;
            foreach (var item in listNguoiDung)
            {
                int id = int.Parse(item.MaNguoiDung);
                if (id > max)
                    max = id;
            }
            return max + 1;
        }

        public QuanLyNhanSu_ViewModel()
        {
            Tat_ToolTip();
            TenDanhSachNhom = "Danh sách người dùng";
            isEdit = true;
            LoadData();
            LoadDataPhanQuyen();
            VisibilityOfListPhanQuyen = Visibility.Hidden;
            VisibilityOfTenNhomQuyen = Visibility.Hidden;

            //DialogHost
            DialogOK = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                DialogOpen = false;
            });

            // show elements used for adding
            AddNguoiDungCommand = new RelayCommand<object>((p) =>
            {
                if (VisibilityOfListPhanQuyen == Visibility.Visible)
                    foreach (var item in ListPhanQuyen)
                        if (item.EnabledCheckBox == true)
                            return false;
                if (VisibilityOfEdit == Visibility.Visible)
                    return false;

                return true;
            },
                (p) =>
                {
                    if (VisibilityOfListPhanQuyen == Visibility.Hidden)
                    {
                        VisibilityOfAdd = Visibility.Visible;
                        ResetCbxTenNhom();
                        VisibilityOfEdit = Visibility.Hidden;
                        VisibilityOfTenNhomQuyen = Visibility.Hidden;
                        // reset value for textbox because these textbox still keep value if you are editing and then change to add
                        ResetTextbox();
                    }
                    else
                    {
                        VisibilityOfAdd = Visibility.Hidden;
                        VisibilityOfEdit = Visibility.Hidden;
                        VisibilityOfTenNhomQuyen = Visibility.Visible;
                        // Enable cho selectedPhanQuyen
                        if (SelectedPhanQuyen != null)
                        {
                            BangPhanQuyen PQ = SelectedPhanQuyen;
                            PQ.EnabledCheckBox = false;
                            foreach (var pq in ListPhanQuyen)
                                if (pq.TenNhomQuyen == PQ.TenNhomQuyen)
                                {
                                    ListPhanQuyen.Remove(pq);
                                    ListPhanQuyen.Add(PQ);
                                    SelectedPhanQuyen = PQ;
                                    break;
                                }
                        }
                    }
                }
            );

            // show elements used for editing
            EditNguoiDungCommand = new RelayCommand<object>((p) =>
            {
                if (VisibilityOfAdd == Visibility.Visible)
                    return false;
                if (VisibilityOfTenNhomQuyen == Visibility.Visible)
                    return false;
                return ((SelectedPhanQuyen != null || SelectedItemNguoiDung != null) && isEdit);
            },
                (p) =>
                {

                    if (VisibilityOfListNguoiDung == Visibility.Visible && SelectedItemNguoiDung != null) // Edit Nhóm người dùng
                    {
                        if (SelectedItemNguoiDung.TenNhom == "Ban quản lý  ")
                        {
                            System.Windows.MessageBox.Show("Không thể sửa thông tin được cho nhóm Ban quản lý");
                            return;
                        }    
                        VisibilityOfEdit = Visibility.Visible;
                        VisibilityOfAdd = Visibility.Hidden;
                        MatKhau = SelectedItemNguoiDung.MatKhau;
                        HoTen = SelectedItemNguoiDung.HoTen;
                        ResetCbxTenNhom();
                        SelectedTenNhom = SelectedItemNguoiDung.TenNhom;
                    }

                    if (VisibilityOfListPhanQuyen == Visibility.Visible && SelectedPhanQuyen != null) // Edit Bảng phân quyền
                    {

                        if (SelectedPhanQuyen.TenNhomQuyen == "Ban quản lý")
                        {
                            System.Windows.MessageBox.Show("Không thể phân quyền được cho nhóm Ban quản lý");
                            return;
                        }
                        VisibilityOfTenNhomQuyen = Visibility.Hidden;
                        BangPhanQuyen PQ = SelectedPhanQuyen;
                        PQ.EnabledCheckBox = true;
                        foreach (var pq in ListPhanQuyen)
                            if (pq.TenNhomQuyen == PQ.TenNhomQuyen)
                            {
                                ListPhanQuyen.Remove(pq);
                                ListPhanQuyen.Add(PQ);
                                SelectedPhanQuyen = PQ;
                                break;
                            }
                        isEdit = false;
                    }
                }
            );

            DeleteNguoiDungKCommand = new RelayCommand<object>((p) =>
            {
                if (VisibilityOfAdd == Visibility.Visible || VisibilityOfEdit == Visibility.Visible) return false;
                if (VisibilityOfTenNhomQuyen == Visibility.Visible)
                    return false;
                return ((SelectedItemNguoiDung != null || SelectedPhanQuyen != null) && isEdit);
            },
                (p) =>
                {
                    if (VisibilityOfListNguoiDung == Visibility.Visible)
                    {
                        VisibilityOfEdit = Visibility.Hidden;
                        VisibilityOfAdd = Visibility.Hidden;
                        DialogResult kq = System.Windows.Forms.MessageBox.Show("Bạn chắc xóa người dùng này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        var nguoiDung = DataProvider.Ins.DB.NGUOIDUNGs.Where(x => x.TenDangNhap == SelectedItemNguoiDung.TenDangNhap).SingleOrDefault();
                        DataProvider.Ins.DB.NGUOIDUNGs.Remove(nguoiDung);
                        DataProvider.Ins.DB.SaveChanges();
                        if (kq == DialogResult.Yes)
                        {
                            int length = ListNhanVien.Count();
                            for (int i = 0; i < length; i++)
                            {
                                if (ListNhanVien[i].TenDangNhap == SelectedItemNguoiDung.TenDangNhap)
                                {
                                    ListNhanVien.RemoveAt(i);
                                    break;
                                }
                            }
                            //System.Windows.Forms.MessageBox.Show("Xóa người dùng thành công");
                            DialogOpen = true;
                            ThongBao = "Xóa người dùng thành công";
                        }
                    }
                    else
                    {
                        VisibilityOfTenNhomQuyen = Visibility.Hidden;
                        DialogResult kq = System.Windows.Forms.MessageBox.Show("Bạn chắc xóa nhóm người dùng này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (kq == DialogResult.Yes)
                        {
                            string error = check_DeleteNhomNguoiDung(search_MaNhom(SelectedPhanQuyen.TenNhomQuyen));
                            if (error == "")
                            {
                                //System.Windows.Forms.MessageBox.Show("Đã xóa nhóm " + SelectedPhanQuyen.TenNhomQuyen + " thành công!");
                                DialogOpen = true;
                                ThongBao = "Đã xóa nhóm " + SelectedPhanQuyen.TenNhomQuyen + " thành công!";

                                int maNhom = search_MaNhom(SelectedPhanQuyen.TenNhomQuyen);
                                Delete_PhanQuyen(maNhom);
                                Delete_NhomNguoiDung(SelectedPhanQuyen.TenNhomQuyen);
                                ListPhanQuyen.Remove(SelectedPhanQuyen);

                            }
                            else
                                System.Windows.Forms.MessageBox.Show("Không thể xóa. Hãy xóa danh sách người dùng này để thực hiện: " + error);
                        }
                    }
                }
            );

            // Button: Confirm for adding NguoiDung
            ConfirmCommand = new RelayCommand<object>((p) =>
            {
                if (VisibilityOfAdd == Visibility.Visible)
                    return true;
                if (VisibilityOfTenNhomQuyen == Visibility.Visible)
                    return true;
                if (VisibilityOfEdit == Visibility.Visible)
                    return true;
                if (SelectedPhanQuyen != null)
                    if (SelectedPhanQuyen.EnabledCheckBox == true)
                        return true;
                    else return false;
                return false;
            }, (p) =>
            {
                try
                {
                    if (VisibilityOfAdd == Visibility.Visible) // Thêm nhân viên
                    {
                        if (Check_ThemNhanVien())
                        {
                            int Ma_Nhom = search_MaNhom(SelectedTenNhom);
                            var nguoiDung = new NGUOIDUNG()
                            {
                                MaNguoiDung = getNewID_NGUOIDUNG().ToString(),
                                TenDangNhap = TenDangNhap,
                                MatKhau = MatKhau,
                                HoTen = HoTen,
                                MaNhom = Ma_Nhom,
                                DiaChi = " ",
                                SDT = " ",
                                GioiTinh = " ",
                            };

                            DataProvider.Ins.DB.NGUOIDUNGs.Add(nguoiDung);
                            DataProvider.Ins.DB.SaveChanges();
                            DialogOpen = true;
                            ThongBao = "Đã thêm nhân viên thành công";
                            NhanVien nv = new NhanVien(TenDangNhap, MatKhau, HoTen, SelectedTenNhom);
                            ListNhanVien.Add(nv);
                            VisibilityOfAdd = Visibility.Hidden;
                            ResetTextbox();
                            VisibilityOfAdd = Visibility.Hidden;
                        }
                    }
                    else if (VisibilityOfEdit == Visibility.Visible)  // Sửa nhân viên
                    {
                        if (check_SuaNhanVien())
                        {
                            var temp = SelectedItemNguoiDung;
                            var nguoiDung = DataProvider.Ins.DB.NGUOIDUNGs.Where(x => x.TenDangNhap == SelectedItemNguoiDung.TenDangNhap).SingleOrDefault();
                            nguoiDung.MatKhau = MatKhau;
                            nguoiDung.MaNhom = search_MaNhom(SelectedTenNhom);
                            nguoiDung.HoTen = HoTen;
                            DataProvider.Ins.DB.SaveChanges();

                            //System.Windows.Forms.MessageBox.Show("Đã sửa thành công");
                            DialogOpen = true;
                            ThongBao = "Đã sửa thành công";
                            Tat_ToolTip();

                            NhanVien nv = new NhanVien(nguoiDung.TenDangNhap, nguoiDung.MatKhau, nguoiDung.HoTen, SelectedTenNhom);
                            int length = ListNhanVien.Count();
                            for (int i = 0; i < length; i++)
                            {
                                if (ListNhanVien[i].TenDangNhap == SelectedItemNguoiDung.TenDangNhap)
                                {
                                    ListNhanVien.RemoveAt(i);
                                    ListNhanVien.Insert(i, nv);
                                    break;
                                }
                            }

                            VisibilityOfEdit = Visibility.Hidden;
                            ////After confirming, selected item will die huhu, this line is used for making selected item reborn. 
                            ////You can continue change value without choosing item again if unnecessary
                            //SelectedItemLTK = temp;
                        }
                    }
                    else if (VisibilityOfTenNhomQuyen == Visibility.Visible) // Thêm nhóm quyền
                    {
                        if (check_ThemNhomQuyen())
                        {
                            BangPhanQuyen bpq = new BangPhanQuyen(txtTenNhomQuyen, false);
                            ListPhanQuyen.Add(bpq);
                            //Add Database nhóm người dùng mới
                            NHOMNGUOIDUNG nhom = new NHOMNGUOIDUNG();
                            nhom.MaNhom = CreateCodeNhomNguoiDung();
                            nhom.TenNhom = txtTenNhomQuyen;
                            DataProvider.Ins.DB.NHOMNGUOIDUNGs.Add(nhom);
                            DataProvider.Ins.DB.SaveChanges();
                            VisibilityOfTenNhomQuyen = Visibility.Hidden;
                            DialogOpen = true;
                            ThongBao = "Thêm nhóm quyên thành công";
                            Tat_ToolTip();
                        }
                    }
                    else if (SelectedPhanQuyen.EnabledCheckBox == true) // Sửa nhóm quyền
                    {
                        int maNhom = search_MaNhom(SelectedPhanQuyen.TenNhomQuyen);

                        Delete_PhanQuyen(maNhom);
                        if (SelectedPhanQuyen.chkQLNS) Add_PhanQuyen(maNhom, 1);
                        if (SelectedPhanQuyen.chkNhapHang) Add_PhanQuyen(maNhom, 2);
                        if (SelectedPhanQuyen.chkKiemDuyetNhapHang) Add_PhanQuyen(maNhom, 3);
                        if (SelectedPhanQuyen.chkBanHang) Add_PhanQuyen(maNhom, 4);
                        if (SelectedPhanQuyen.chkKiemDuyetXuatHang) Add_PhanQuyen(maNhom, 5);
                        if (SelectedPhanQuyen.chkTraCuu) Add_PhanQuyen(maNhom, 6);
                        if (SelectedPhanQuyen.chkBCDS) Add_PhanQuyen(maNhom, 7);
                        if (SelectedPhanQuyen.chkBCTK) Add_PhanQuyen(maNhom, 8);
                        //System.Windows.Forms.MessageBox.Show("Chỉnh sửa quyền thành công cho nhóm " + SelectedPhanQuyen.TenNhomQuyen);
                        DialogOpen = true;
                        ThongBao = "Chỉnh sửa quyền thành công cho nhóm " + SelectedPhanQuyen.TenNhomQuyen;
                        BangPhanQuyen PQ = SelectedPhanQuyen;
                        PQ.EnabledCheckBox = false;
                        foreach (var pq in ListPhanQuyen)
                            if (pq.TenNhomQuyen == PQ.TenNhomQuyen)
                            {
                                ListPhanQuyen.Remove(pq);
                                ListPhanQuyen.Add(PQ);
                                SelectedPhanQuyen = PQ;
                                break;
                            }
                        isEdit = true;
                    }

                }
                catch (Exception e) { };
            });

            CancelCommand = new RelayCommand<object>((p) =>
            {
                return (VisibilityOfTenNhomQuyen == Visibility.Visible || VisibilityOfAdd == Visibility.Visible || VisibilityOfEdit == Visibility.Visible);
            }, (p) =>
            {
                if (VisibilityOfAdd == Visibility.Visible)
                {
                    ResetTextbox();
                    VisibilityOfAdd = Visibility.Hidden;
                }
                else if (VisibilityOfEdit == Visibility.Visible)
                {
                    if (SelectedItemNguoiDung != null)
                    {
                        MatKhau = SelectedItemNguoiDung.MatKhau;
                        HoTen = SelectedItemNguoiDung.HoTen;
                        SelectedTenNhom = SelectedItemNguoiDung.TenNhom;
                    }
                    VisibilityOfEdit = Visibility.Hidden;
                }
                else if (VisibilityOfTenNhomQuyen == Visibility.Visible)
                {
                    VisibilityOfTenNhomQuyen = Visibility.Hidden;
                    txtTenNhomQuyen = "";
                }
                Tat_ToolTip();
            });

            CbbSelectionChangedCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                // selected index = 0: choosing list of NGUOIDUNG
                // selected index = 1: choosing list of PhanQuyen
                if (SelectedIndexCbb == 0)
                {
                    Tat_ToolTip();
                    Reset();
                    TenDanhSachNhom = "Danh sách người dùng";
                    VisibilityOfTenNhomQuyen = Visibility.Hidden;
                    VisibilityOfListNguoiDung = Visibility.Visible;
                    VisibilityOfListPhanQuyen = Visibility.Hidden;
                }
                else
                {
                    Tat_ToolTip();
                    Reset();
                    TenDanhSachNhom = "Danh sách phân quyền";
                    VisibilityOfListNguoiDung = Visibility.Hidden;
                    VisibilityOfListPhanQuyen = Visibility.Visible;
                    // co muon an may cai nay ko?
                    VisibilityOfAdd = VisibilityOfEdit = Visibility.Hidden;
                }

            });
        }
    }
}