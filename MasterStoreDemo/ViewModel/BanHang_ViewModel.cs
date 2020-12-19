using MasterStoreDemo.Helper;
using MasterStoreDemo.Model;
using MasterStoreDemo.View;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace MasterStoreDemo.ViewModel
{
    public class BanHang_ViewModel : BaseViewModel
	{
        #region Old code
        //      //Bien chua ket qua kiem tra hop le
        //      private bool Result_KiemTraHopLe;
        //private bool Result_KiemTraNhapLai; //true = da nhap lai moi nhat, false = chua nhap lai moi nhat
        //private string Result_Dialog;
        ////Khai bao cac command
        //public ICommand Click_MSTKCommand { get; set; }
        //public ICommand MSTK_TextChangedCommand { get; set; }
        //public ICommand KiemTraCommand { get; set; }
        //public ICommand Click_GiaoDichCommand { get; set; }
        //public ICommand STR_TextChangedCommand { get; set; }
        //public ICommand TKH_TextChangedCommand { get; set; }
        //public ICommand Click_CapNhatCommand { get; set; }
        //public ICommand STKEnterKeyDown_Command { get; set; }
        //public ICommand SoTienRutEnterKeyDown_Command { get; set; }
        //public ICommand Click_CopySoDuSTRCommand { get; set; }
        //public ICommand DialogOK { get; set; }
        //public ICommand DialogCancel { get; set; }
        //      public ICommand Refresh { get; set; }

        //      #region Binding tu view
        //      //Ngay Rut, kieu string
        //      private string _NgayRut;
        //public string NgayRut
        //{
        //	get => _NgayRut;
        //	set { _NgayRut = value; OnPropertyChanged();}
        //}
        ////Ma so tiet kiem
        //private string _MaSoTietKiem;

        //public string MaSoTietKiem
        //{
        //	get { return _MaSoTietKiem; }
        //	set { _MaSoTietKiem = value; OnPropertyChanged();}
        //}
        ////Ten Khach hang
        //private string _TenKhachHang;

        //public string TenKhachHang
        //{
        //	get { return _TenKhachHang; }
        //	set { _TenKhachHang = value; OnPropertyChanged(); }
        //}
        ////So Tien Rut
        //private string _SoTienRut;

        //public string SoTienRut
        //{
        //	get { return _SoTienRut; }
        //	set { _SoTienRut = value; OnPropertyChanged(); }
        //}
        ////Ten loai tiet kiem
        //private string _TenLoaiTietKiem;

        //public string TenLoaiTietKiem
        //{
        //	get { return _TenLoaiTietKiem; }
        //	set { _TenLoaiTietKiem = value; OnPropertyChanged(); }
        //}
        ////So du tai khoan
        //private string _SoDu;

        //public string SoDu
        //{
        //	get { return _SoDu; }
        //	set { _SoDu = value; OnPropertyChanged(); }
        //}
        ////CMND
        //private string _CMND;

        //public string CMND
        //{
        //	get { return _CMND; }
        //	set { _CMND = value; OnPropertyChanged(); }
        //}
        ////Ngay dao han ke tiep
        //private string _NgayDaoHan;

        //public string NgayDaoHan
        //{
        //	get { return _NgayDaoHan; }
        //	set { _NgayDaoHan = value; OnPropertyChanged(); }
        //}

        //private string _ThongBao;

        //public string ThongBao
        //{
        //	get { return _ThongBao; }
        //	set { _ThongBao = value; OnPropertyChanged(); }
        //}
        ////listView
        //private ObservableCollection<ListLichSuPhieuRut> _ListLichSuGD;

        //public ObservableCollection<ListLichSuPhieuRut> ListLichSuGD
        //{
        //	get { return _ListLichSuGD; }
        //	set { _ListLichSuGD = value; OnPropertyChanged(); }
        //}

        //private string _MaPR;

        //public string MaPR
        //{
        //	get { return _MaPR; }
        //	set { _MaPR = value; OnPropertyChanged(); }
        //}

        //private string _NgayRutTien;

        //public string NgayRutTien
        //{
        //	get { return _NgayRutTien; }
        //	set { _NgayRutTien = value; OnPropertyChanged(); }
        //}


        //private string _TienRut;
        //public string TienRut
        //{
        //	get { return _TienRut; }
        //	set { _TienRut = value; OnPropertyChanged(); }
        //}

        ////in phieu
        //private bool _CreatePR;
        //public bool CreatePR
        //{
        //	get { return _CreatePR; }
        //	set { _CreatePR = value; OnPropertyChanged(); }
        //}

        ////Cac nut dung cho thong bao
        //private string _ThongBao_MaSo;
        //public string ThongBao_MaSo
        //{
        //	get { return _ThongBao_MaSo; }
        //	set { _ThongBao_MaSo = value; OnPropertyChanged(); }
        //}

        //private string _SoTietKiem_Check;
        //public string SoTietKiem_Check
        //{
        //	get { return _SoTietKiem_Check; }
        //	set { _SoTietKiem_Check = value; OnPropertyChanged(); }
        //}

        //private string _ThongBao_TienRut;
        //public string ThongBao_TienRut
        //{
        //	get { return _ThongBao_TienRut; }
        //	set { _ThongBao_TienRut = value; OnPropertyChanged(); }
        //}

        //private string _SoTienRut_Check;
        //public string SoTienRut_Check
        //{
        //	get { return _SoTienRut_Check; }
        //	set { _SoTienRut_Check = value; OnPropertyChanged(); }
        //}

        //private string _ThongBao_DaoHan;
        //public string ThongBao_DaoHan
        //{
        //	get { return _ThongBao_DaoHan; }
        //	set { _ThongBao_DaoHan = value; OnPropertyChanged(); }
        //}

        //private string _DaoHan_Check;

        //public string DaoHan_Check
        //{
        //	get { return _DaoHan_Check; }
        //	set { _DaoHan_Check = value; OnPropertyChanged(); }
        //}

        //private string _ThongBao_NgayRut;
        //public string ThongBao_NgayRut
        //{
        //	get { return _ThongBao_NgayRut; }
        //	set { _ThongBao_NgayRut = value; OnPropertyChanged(); }
        //}

        //private string _NgayRut_Check;
        //public string NgayRut_Check
        //{
        //	get { return _NgayRut_Check; }
        //	set { _NgayRut_Check = value; OnPropertyChanged(); }
        //}
        ////DialogHost
        //private bool _DialogOpen;

        //public bool DialogOpen
        //{
        //	get { return _DialogOpen; }
        //	set { _DialogOpen = value; OnPropertyChanged(); }
        //}

        //private string _IsCancelVisible;
        //public string IsCancelVisible
        //{
        //	get { return _IsCancelVisible; }
        //	set { _IsCancelVisible = value; OnPropertyChanged(); }
        //}

        ////Quy Dinh
        //private string _QuyDinhRutTien;

        //public string QuyDinhRutTien
        //{
        //	get { return _QuyDinhRutTien; }
        //	set { _QuyDinhRutTien = value; OnPropertyChanged(); }
        //}


        //#endregion
        //#region Khoi tao
        ////Khoi tao viewmodel
        //public BanHang_ViewModel()
        //{
        //	CapNhatQuyDinh();
        //	Reset_Check();
        //	CreatePR = true;
        //	Result_KiemTraNhapLai = true;
        //	//Dat ngay rut theo ngay hom nay
        //	NgayRut = DateTime.Today.ToString("dd/MM/yyyy");
        //	//Khi click vao nut ben canh MSTK
        //	Click_MSTKCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
        //	{
        //		if (!CapNhatThongTin())
        //		{
        //			Result_KiemTraNhapLai = true;
        //			Result_KiemTraHopLe = false;
        //			ThongBao = "Lấy thông tin thất bại";
        //		}
        //		else
        //		{
        //			Result_KiemTraHopLe = false;
        //		}
        //	});
        //	//khi nhan enter o mo so
        //	STKEnterKeyDown_Command = new RelayCommand<Object>((p) => { return true; }, (p) =>
        //	 {
        //		 if (!CapNhatThongTin())
        //		 {
        //			 Result_KiemTraNhapLai = true;
        //			 Result_KiemTraHopLe = false;
        //			 ThongBao = "Lấy thông tin thất bại";
        //		 }
        //		 else
        //		 {
        //			 Result_KiemTraHopLe = false;
        //		 }
        //	 });
        //	//khi thay doi textbox MSTK
        //	MSTK_TextChangedCommand = new RelayCommand<TextBox>((p) => { return true; }, (p) =>
        //	{
        //		try
        //		{
        //			TenKhachHang = "";
        //			SoDu = "";
        //			CMND = "";
        //			TenLoaiTietKiem = "";
        //			NgayDaoHan = "";
        //			ThongBao = "";
        //			Result_KiemTraHopLe = false;
        //			Result_KiemTraNhapLai = true;
        //			ListLichSuGD = new ObservableCollection<ListLichSuPhieuRut>();
        //		}
        //		catch (Exception e)
        //		{

        //		}
        //	});
        //	//Lenh kiem tra tinh hop le
        //	KiemTraCommand = new RelayCommand<Button>((p) => { return true; }, (p) =>
        //	{
        //		if (!KiemTraHopLe())
        //		{
        //			Result_KiemTraHopLe = false;
        //			Result_KiemTraNhapLai = true;
        //			ThongBao = "Kiểm tra thất bại.";
        //		}
        //		else
        //		{
        //			if (Result_KiemTraHopLe == true)
        //			{
        //				DialogOpen = true;
        //				IsCancelVisible = "Collapsed";
        //				ThongBao = "Thông tin phiếu rút hợp lệ";
        //			}
        //		}
        //	});
        //	SoTienRutEnterKeyDown_Command = new RelayCommand<Object>((p) => { return true; }, (p) =>
        //	{
        //		if (!KiemTraHopLe())
        //		{
        //			Result_KiemTraHopLe = false;
        //			Result_KiemTraNhapLai = true;
        //			ThongBao = "Kiểm tra thất bại.";
        //		}
        //		else
        //		{
        //			if (Result_KiemTraHopLe == true)
        //			{
        //				DialogOpen = true;
        //				IsCancelVisible = "Collapsed";
        //				ThongBao = "Thông tin phiếu rút hợp lệ";
        //			}
        //		}
        //	});
        //	//Lenh thuc hien giao dich
        //	Click_GiaoDichCommand = new RelayCommand<Button>((p) => { return Result_KiemTraHopLe; }, (p) =>
        //	{
        //		if (!ThucHienGiaoDich())
        //		{
        //			ThongBao += "Không thể thưc hiện giao dịch do lỗi không xác định.";
        //		}
        //		else
        //		{
        //			Result_KiemTraHopLe = false;
        //			DialogOpen = true;
        //			IsCancelVisible = "Collapsed";
        //			ThongBao += "Đã tạo phiếu rút thành công.";
        //		}
        //	});
        //	STR_TextChangedCommand = new RelayCommand<TextBox>((p) => { return true; }, (p) =>
        //	{
        //		try
        //		{
        //			Result_KiemTraHopLe = false;
        //		}
        //		catch (Exception e)
        //		{

        //		}
        //	});
        //	TKH_TextChangedCommand = new RelayCommand<TextBox>((p) => { return true; }, (p) =>
        //	{
        //		try
        //		{
        //			Result_KiemTraHopLe = false;
        //		}
        //		catch (Exception e)
        //		{

        //		}
        //	});
        //	Click_CapNhatCommand = new RelayCommand<Button>((p) => { return !Result_KiemTraNhapLai; }, (p) =>
        //	{
        //		MessageBoxResult re = MessageBox.Show("Bạn có chắc muốn nhập lãi vào vốn? Tiến trình này không thể hoàn tác.", "Thông báo", MessageBoxButton.OKCancel);
        //		if (re == MessageBoxResult.OK)
        //		{
        //			if (!NhapLaiVaoVon.Ins.StartThis(MaSoTietKiem, true))
        //			{
        //				ThongBao = "Có lỗi xảy ra hoặc sổ tiết kiệm này đã được nhập lãi rồi!";
        //				DaoHan_Check = "Error";
        //				ThongBao_DaoHan = "Có lỗi xảy ra hoặc sổ tiết kiệm này đã được nhập lãi rồi!";
        //			}
        //			else
        //			{
        //				Result_KiemTraHopLe = false;
        //				//DaoHan_Check = "Check";
        //				//ThongBao_DaoHan = "Đã cập nhật lãi vào số dư";
        //				DialogOpen = true;
        //				IsCancelVisible = "Collapsed";
        //				ThongBao = "Đã cập nhật lãi vào số dư";
        //				if (!CapNhatThongTin())
        //				{
        //					SoTietKiem_Check = "Error";
        //					ThongBao_MaSo = "Lấy thông tin thất bại";
        //					ThongBao = "Lấy thông tin thất bại";
        //				}
        //				else
        //				{
        //					Result_KiemTraHopLe = false;
        //				}
        //			}
        //		}
        //	});
        //	Click_CopySoDuSTRCommand = new RelayCommand<Button>((p) => { return true; }, (p) =>
        //	{
        //		if(!Copy_SD_STR())
        //		{
        //			ThongBao = "Sao chép không thành công!";
        //		}
        //		else
        //		{

        //		}
        //	});
        //	DialogOK = new RelayCommand<Button>((p) => { return true; }, (p) =>
        //	{
        //		Result_Dialog = "OK";
        //		DialogOpen = false;
        //	});
        //	DialogCancel = new RelayCommand<Button>((p) => { return IsCancelVisible == "Visible"; }, (p) =>
        //	{
        //		Result_Dialog = "Cancel";
        //		DialogOpen = false;
        //	});

        //          Refresh = new RelayCommand<object>((p) => { return true; }, (p) =>
        //          {
        //              Reset_Check();
        //              MaSoTietKiem = "";
        //              SoTienRut = "";
        //              TenKhachHang = "";
        //          });
        //      }
        //public void Reset_Check()
        //{
        //	SoTietKiem_Check = "None";
        //	SoTienRut_Check = "None";
        //	DaoHan_Check = "None";
        //	NgayRut_Check = "None";
        //	ThongBao_DaoHan = "";
        //	ThongBao_MaSo = "";
        //	ThongBao_TienRut = "";
        //	ThongBao_NgayRut = "";
        //}
        //public bool BindingLichSu(string mastk)
        //{
        //	try
        //	{
        //		ListLichSuGD = new ObservableCollection<ListLichSuPhieuRut>();

        //		ObservableCollection<PHIEURUT> List_PR = new ObservableCollection<PHIEURUT>(DataProvider.Ins.DB.PHIEURUTs);
        //		var lichsu = from list in List_PR
        //					 where list.MaSoTietKiem == mastk
        //					 orderby list.MaPhieuRut descending
        //					 select new ListLichSuPhieuRut(list.MaPhieuRut, list.NgayRut.ToString("dd/MM/yyyy"), list.SoTienRut.ToString("0,000"));
        //		foreach (var ls in lichsu)
        //		{
        //			ListLichSuGD.Add(ls);
        //		}
        //		return true;
        //	}
        //	catch(Exception e)
        //	{
        //		return false;
        //	}
        //}
        //private bool CapNhatThongTin()
        //{
        //	try
        //	{
        //		Reset_Check();
        //		SOTIETKIEM temp = Tim_MSTK(MaSoTietKiem);
        //		if (temp != null)
        //		{
        //			if (temp.NgayDongSo == null)
        //			{
        //				TenLoaiTietKiem = Tim_MaLoaiTietKiem(temp.MaLoaiTietKiem).TenLoaiTietKiem;
        //				TenKhachHang = temp.TenKhachHang;
        //				if (temp.SoDu < 1000)
        //				{
        //					SoDu = temp.SoDu.ToString();
        //				}
        //				else
        //				{
        //					SoDu = temp.SoDu.ToString("0,000");
        //				}
        //				CMND = temp.SoCMND;
        //				if (Tim_MaLoaiTietKiem(temp.MaLoaiTietKiem).KyHan == 0)
        //				{
        //					NgayDaoHan = "Không xác định";
        //				}
        //				else
        //				{
        //					NgayDaoHan = temp.NgayDaoHanKeTiep.ToString("dd/MM/yyyy");
        //				}
        //				BindingLichSu(temp.MaSoTietKiem);
        //				KiemTraNhapLai();
        //				//SoTietKiem_Check = "Check";
        //				//ThongBao_MaSo = "Đã cập nhật thông tin sổ tiết kiệm.";
        //				//ThongBao = "Đã cập nhật thông tin sổ tiết kiệm.";
        //			}
        //			else
        //			{
        //				BindingLichSu(temp.MaSoTietKiem);
        //				//Thong bao da dong so o day
        //				SoTietKiem_Check = "Error";
        //				ThongBao_MaSo = "Sổ tiết kiệm này đã đóng!";
        //				ThongBao = "Sổ tiết kiệm này đã đóng!";
        //			}
        //		}
        //		else
        //		{
        //			if (!String.IsNullOrWhiteSpace(MaSoTietKiem))
        //			{
        //				SoTietKiem_Check = "Error";
        //				ThongBao_MaSo = "Mã STK không đúng hoặc không tồn tại, kiểm tra xem đã đúng định dạng hay chưa";
        //				ThongBao = "Không tìm thấy sổ tiết kiệm phù hợp!";
        //			}
        //			else
        //			{
        //				SoTietKiem_Check = "Error";
        //				ThongBao_MaSo = "Hãy nhập mã sổ tiết kiệm trước khi bấm kiểm tra!";
        //				ThongBao = "Hãy nhập mã sổ tiết kiệm trước khi bấm kiểm tra!";
        //			}
        //		}
        //		return true;
        //	}
        //	catch (Exception e)
        //	{
        //		return false;
        //	}
        //}
        //private bool KiemTraHopLe()
        //{
        //	Reset_Check();
        //	ThongBao = "";
        //	Result_KiemTraHopLe = true;
        //	try
        //	{
        //		if (decimal.Parse(SoTienRut) < 1000)
        //		{
        //		}
        //		else
        //		{
        //			SoTienRut = decimal.Parse(SoTienRut).ToString("0,000");
        //			Result_KiemTraHopLe = true;
        //		}
        //	}
        //	catch (Exception e)
        //	{

        //	}

        //	try
        //	{
        //		CapNhatThongTin();
        //		if(SoTietKiem_Check == "Error")
        //		{
        //			Result_KiemTraHopLe = false;
        //			Result_KiemTraNhapLai = true;
        //			return true;
        //		}
        //		SOTIETKIEM info_stk = Tim_MSTK(MaSoTietKiem);
        //		LOAITIETKIEM info_loaitietkiem = Tim_MaLoaiTietKiem(info_stk.MaLoaiTietKiem);
        //		if(info_stk.NgayMoSo.AddDays(info_loaitietkiem.ThoiGianGuiToiThieu) > DateTime.Today )
        //		{
        //			NgayRut_Check = "Error";
        //                  ThongBao_NgayRut = "Ngày mở sổ là: " + info_stk.NgayMoSo.ToString("dd/MM/yyyy") + ". Chưa đủ số ngày gửi tối thiểu (" + info_loaitietkiem.ThoiGianGuiToiThieu.ToString() + " ngày)"; ;
        //			//ThongBao += "Chưa đủ số ngày gửi tối thiểu.\n";
        //			Result_KiemTraHopLe = false;
        //		}
        //		else
        //		{
        //			//NgayRut_Check = "Check";
        //			//ThongBao_NgayRut = "Đã đủ số ngày gửi tối thiểu";
        //			if (!KiemTraNhapLai())
        //			{
        //				DaoHan_Check = "Error";
        //				ThongBao_DaoHan = "Lỗi, không xác định được thông tin đáo hạn.";
        //				ThongBao += "Lỗi, không xác định được thông tin đáo hạn.\n";
        //				Result_KiemTraHopLe = false;
        //			}
        //			else
        //			{
        //				if(Result_KiemTraNhapLai == false)
        //				{
        //					DaoHan_Check = "Error";
        //					ThongBao_DaoHan = "Cần nhập lãi trước khi rút.";
        //					ThongBao += "Cần nhập lãi trước khi rút.\n";
        //					Result_KiemTraHopLe = false;
        //				}
        //				else
        //				{
        //					//DaoHan_Check = "Check";
        //					//ThongBao_DaoHan = "Đã nhập lãi vào sổ này rồi";
        //				}
        //			}
        //		}
        //		if (String.IsNullOrWhiteSpace(SoTienRut))
        //		{
        //			SoTienRut_Check = "Error";
        //			ThongBao_TienRut = "Vui lòng nhập số tiền rút.";
        //			ThongBao += "Vui lòng nhập số tiền rút.\n";
        //			Result_KiemTraHopLe = false;
        //		}
        //		else
        //		{
        //			if (check_hasaWhiteSpace(SoTienRut))
        //			{
        //				SoTienRut_Check = "Error";
        //				ThongBao_TienRut += "Số tiền không thể chứa khoảng trắng";
        //				Result_KiemTraHopLe = false;
        //			}
        //			else
        //			{
        //				if (decimal.Parse(SoTienRut) < 1000)
        //				{
        //					SoTienRut_Check = "Error";
        //					ThongBao_TienRut += "Không thể rút số tiền ít hơn 1000 đồng.";
        //					Result_KiemTraHopLe = false;
        //				}
        //				else
        //				{
        //					if (info_loaitietkiem.QuyDinhSoTienRut == "Rút hết" && decimal.Parse(SoTienRut) < decimal.Parse(SoDu))
        //					{
        //						SoTienRut_Check = "Error";
        //						ThongBao_TienRut += "Loại tiết kiệm có kì hạn phải rút toàn bộ.\n";
        //						ThongBao += "Loại tiết kiệm có kì hạn phải rút toàn bộ.\n";
        //						Result_KiemTraHopLe = false;
        //					}
        //					else
        //					{
        //						if (decimal.Parse(SoTienRut) > decimal.Parse(SoDu))
        //						{
        //							SoTienRut_Check = "Error";
        //							ThongBao_TienRut += "Không thể rút nhiều hơn số dư tài khoản.\n";
        //							ThongBao += "Không thể rút nhiều hơn số dư tài khoản.\n";
        //							Result_KiemTraHopLe = false;
        //						}
        //						else
        //						{
        //							//SoTienRut_Check = "Check";
        //							//ThongBao_TienRut = "Có thể rút số tiền này.";
        //						}
        //					}
        //				}
        //			}
        //		}
        //		return true; 
        //	}
        //	catch (Exception e)
        //	{
        //		Result_KiemTraHopLe = false;
        //		return false; 
        //	}
        //}
        //private bool KiemTraNhapLai()
        //{
        //	try
        //	{
        //		Result_KiemTraNhapLai = true;
        //		SOTIETKIEM info_stk = Tim_MSTK(MaSoTietKiem);
        //		LOAITIETKIEM info_loaitietkiem = Tim_MaLoaiTietKiem(info_stk.MaLoaiTietKiem);
        //		if (info_stk.NgayMoSo.AddDays(info_loaitietkiem.ThoiGianGuiToiThieu) > DateTime.Today)
        //		{
        //			//khong the tinh lai do chua du so ngay gui toi thieu (xem quy dinh)
        //		}
        //		else
        //		{
        //			if (info_loaitietkiem.KyHan != 0)
        //			{
        //				if (info_stk.NgayDaoHanKeTiep < DateTime.Today.AddDays(info_loaitietkiem.KyHan))
        //				{
        //					Result_KiemTraHopLe = false;
        //					Result_KiemTraNhapLai = false;
        //				}
        //			}
        //			else
        //			{
        //				if (info_stk.NgayDaoHanKeTiep != DateTime.Today.AddDays(1))
        //				{
        //					Result_KiemTraHopLe = false;
        //					Result_KiemTraNhapLai = false;
        //				}
        //			}
        //		}
        //		return true;
        //	}
        //	catch(Exception e)
        //	{
        //		Result_KiemTraNhapLai = true;
        //		return false;
        //	}
        //}
        //private bool ThucHienGiaoDich()
        //{
        //	try
        //	{
        //		ThongBao = "";
        //		PHIEURUT info_PhieuRut = new PHIEURUT();
        //		if (DataProvider.Ins.DB.PHIEURUTs.Count() == 0)
        //		{
        //			info_PhieuRut.MaPhieuRut = "PR0000001";
        //		}
        //		else
        //		{
        //			info_PhieuRut.MaPhieuRut = "PR0000000";
        //			decimal temp_dem = DataProvider.Ins.DB.PHIEURUTs.Count();
        //			string temp = (temp_dem+1).ToString();
        //			info_PhieuRut.MaPhieuRut = info_PhieuRut.MaPhieuRut.Remove(9 - temp.Length, temp.Length) + temp;
        //		}
        //		info_PhieuRut.MaSoTietKiem = this.MaSoTietKiem;
        //		info_PhieuRut.NgayRut = DateTime.Today;
        //		info_PhieuRut.SoTienRut = decimal.Parse(this.SoTienRut);
        //		DataProvider.Ins.DB.PHIEURUTs.Add(info_PhieuRut);
        //		DataProvider.Ins.DB.SaveChanges();

        //		SOTIETKIEM stk = DataProvider.Ins.DB.SOTIETKIEMs.Where(x => x.MaSoTietKiem == this.MaSoTietKiem).Single();
        //		stk.SoDu -= decimal.Parse(this.SoTienRut);
        //		if(stk.SoDu<1)
        //		{
        //			stk.SoDu = 0;
        //		}
        //		DataProvider.Ins.DB.SaveChanges();

        //		if (CreatePR == true)
        //		{
        //			BanHang_PrintPreview_ViewModel PhieuRutVM = new BanHang_PrintPreview_ViewModel(info_PhieuRut.MaPhieuRut, TenKhachHang, info_PhieuRut.NgayRut.ToString("dd/MM/yyyy"), info_PhieuRut.SoTienRut.ToString());
        //			BanHang_PrintPreview PhieuRut = new BanHang_PrintPreview(PhieuRutVM);
        //			PhieuRut.ShowDialog();
        //		}

        //		if (stk.SoDu < 1)
        //		{
        //			DongSoTuDong(info_PhieuRut.MaSoTietKiem);
        //		}
        //		CapNhatThongTin();
        //		TenKhachHang = "";
        //		SoDu = "";
        //		CMND = "";
        //		TenLoaiTietKiem = "";
        //		NgayDaoHan = "";
        //		Result_KiemTraHopLe = false;
        //		Result_KiemTraNhapLai = true;
        //		SoTienRut = "";

        //		return true;
        //	}
        //	catch(Exception e)
        //	{
        //		return false;
        //	}
        //}
        //private bool DongSoTuDong(string mstk)
        //{
        //	try
        //	{
        //		if(GetThamSo("Đóng sổ tự động") == 1)
        //		{
        //			SOTIETKIEM temp = DataProvider.Ins.DB.SOTIETKIEMs.Where(x => x.MaSoTietKiem == mstk).Single();
        //			temp.NgayDongSo = DateTime.Today;
        //			DataProvider.Ins.DB.SaveChanges();
        //			ThongBao = "Đã đóng sổ tiết kiệm.\n";
        //		}
        //		else
        //		{
        //			ThongBao = "Đã rút tiền thành công.\n";
        //		}
        //		return true;
        //	}
        //	catch (Exception e)
        //	{
        //		return false;
        //	}
        //}
        //private bool Copy_SD_STR()
        //{
        //	try
        //	{
        //		SoTienRut = SoDu.Replace(",", "");
        //		return true;
        //	}
        //	catch(Exception e)
        //	{
        //		return false;
        //	}
        //}
        //private void CapNhatQuyDinh()
        //{
        //	QuyDinhRutTien = "Loại tiết kiệm có kỳ hạn chỉ được rút khi quá kỳ hạn và phải rút hết toàn bộ, khi này tiền lãi được tính với mức lãi suất của loại không kỳ hạn.\n"
        //					+ "Loại tiết kiệm không kỳ hạn được rút khi gửi trên số ngày tối thiểu theo quy định và có thể rút số tiền nhỏ hơn hoặc bằng số dư hiện có.\n";
        //	if (GetThamSo("Đóng sổ tự động") == 1)
        //	{
        //		QuyDinhRutTien += "Sổ sau khi rút hết tiền sẽ tự động đóng.";
        //	}
        //	else
        //	{
        //	}
        //}
        ////Ham ben duoi duoc lay tu MoSo
        //private bool check_hasaWhiteSpace(string chuoi)
        //{
        //	if (chuoi == null) return false;
        //	foreach (var item in chuoi)
        //		if (item == ' ')
        //			return true;
        //	return false;
        //}
        //#endregion
        //#region Cac ham xu li database
        ////lay ra so tiet kiem khi biet Ma so tiet kiem 
        //private SOTIETKIEM Tim_MSTK(string mstk)
        //{
        //	List<SOTIETKIEM> List_SoTietKiem = DataProvider.Ins.DB.SOTIETKIEMs.ToList();
        //	foreach (SOTIETKIEM stk in List_SoTietKiem)
        //	{
        //		if (stk.MaSoTietKiem == mstk)
        //			return stk;
        //	}
        //	return null;
        //}
        ////lay ra loai tiet kiem tu ma loai tiet kiem
        //private LOAITIETKIEM Tim_MaLoaiTietKiem(string mltk)
        //{
        //	List<LOAITIETKIEM> List_LoaiTietKiem = DataProvider.Ins.DB.LOAITIETKIEMs.ToList();
        //	foreach (LOAITIETKIEM ltk in List_LoaiTietKiem)
        //	{
        //		if (ltk.MaLoaiTietKiem == mltk)
        //			return ltk;
        //	}
        //	return null;
        //}
        ////lay ra tham so can tim
        //private decimal GetThamSo(string tenthamso)
        //{
        //	List<THAMSO> List_ThamSo = DataProvider.Ins.DB.THAMSOes.ToList();
        //	foreach(THAMSO ts in List_ThamSo)
        //	{
        //		if (ts.TenThamSo == tenthamso)
        //			return ts.GiaTri;
        //	}
        //	return -1;
        //}
        //      #endregion
        #endregion

        // new code from this hihi
        //Chua Connect NhanVien
        #region Init Funtions
        public void save_HoaDon()
        {
            HOADON hd = new HOADON()
            {
                MaHoaDon = MaHD,
                NgayLap = DateTime.Now,
                ThoiGian = new TimeSpan(),
                MaQuay = LoginViewModel.Quay.MaQuay,
                TongTien = decimal.Parse(TongTien),
                MaNguoiLap = "1"
            };

            DataProvider.Ins.DB.HOADONs.Add(hd);
            DataProvider.Ins.DB.SaveChanges();

            #region
            foreach (var mh in ListMatHang)
            {
                CT_HOADON ct = new CT_HOADON()
                {
                    MaChiTietHoaDon = create_MaCTHD(),
                    MaMH = mh.MaMH,
                    MaHoaDon = MaHD,
                    SoLuong = int.Parse(mh.SoLuong),
                    DonGiaBan = decimal.Parse(mh.DonGia),
                    GhiChu = "",
                };
                DataProvider.Ins.DB.CT_HOADON.Add(ct);
                DataProvider.Ins.DB.SaveChanges();
            }
            #endregion
        }

        public bool check_CreateBill()
        {
            if (String.IsNullOrEmpty(MaHD))
            {
                DialogOpen = true;
                ThongBao = "Bạn chưa tạo mã hóa đơn! Vui lòng kiểm tra lại";
                return false;
            }

            if (TongTien == "" || TongTien == "0" || TongTien == null)
            {
                DialogOpen = true;
                ThongBao = "Không thể tạo một hóa đơn rỗng!";
                return false;
            }

            return true;
        }
        public void Init()
        {
            NgayLapHD = get_DateNow();
            TenNhanVien = get_NameofStaff();
            ListMatHang = new ObservableCollection<ListMatHangMua>();

            NgayThangNam = "Ngày " + NgayLapHD[0] + NgayLapHD[1] + ", Tháng " + NgayLapHD[3] + NgayLapHD[4] + ", Năm " + NgayLapHD.Substring(6);
        }

        public string get_DateNow()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        public string get_NameofStaff()
        {
            if (LoginViewModel.TaiKhoanSuDung == null)
                return "";
            string staff = LoginViewModel.TaiKhoanSuDung.HoTen;
            return staff;
        }

        public int trans_number_HD(string maHD)
        {
            string res = "";
            for (int i = 2; i < maHD.Length; i++)
                res += maHD[i];

            return int.Parse(res);
        }

        public string trans_string_HD(int maHD)
        {
            string res = maHD + "";
            int n = 8 - res.Length;
            for (int i = 0; i < n; i++)
                res = "0" + res;
            return res;
        }

        public string create_MaHD()
        {
            string ma = "HD";

            ObservableCollection<HOADON> listHD = new ObservableCollection<HOADON>(DataProvider.Ins.DB.HOADONs);

            int max = 0;
            foreach (var hd in listHD)
            {
                int value = trans_number_HD(hd.MaHoaDon);
                if (max < value) max = value;
            }

            max++;
            ma += trans_string_HD(max);
            return ma;

        }

        public string create_MaCTHD()
        {
            string ma = "CTHD";

            ObservableCollection<CT_HOADON> listCTHD = new ObservableCollection<CT_HOADON>(DataProvider.Ins.DB.CT_HOADON);

            int max = 0;
            foreach (var hd in listCTHD)
            {
                int value = int.Parse(hd.MaChiTietHoaDon.Substring(4));
                if (max < value) max = value;
            }

            max++;
            for (int i = 0; i < 6 - max.ToString().Length; i++) ma += "0";
            return ma += max.ToString();

        }

        public void add_MatHang(string ma, int sl)
        {
            ObservableCollection<MATHANG> listMatHang = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);

            foreach (var mh in listMatHang)
                if (mh.MaMH == ma)
                {
                    //System.Windows.Forms.MessageBox.Show("Hello");
                    int stt = ListMatHang.Count + 1;
                    decimal tt = mh.GiaBan * sl;
                    ListMatHangMua mh_them = new ListMatHangMua(stt + "",mh.MaMH, mh.TenMH, mh.DonViTinh,mh.GiaBan + "", sl + "",tt+"");
                    ListMatHang.Add(mh_them);
                    break;
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

        public string Calculate_SumOfPurchaseMoney()
        {
            return "0";
        }

        public void xoa_MatHang()
        {
            int stt = int.Parse(SelectedMatHang.STT);

            ObservableCollection<ListMatHangMua> temp = new ObservableCollection<ListMatHangMua>();

            int index = 1;
            for (int i=0; i<ListMatHang.Count; i++)
                if (i!=stt-1)
                {
                    ListMatHang[i].STT = index + "";
                    index++;
                    temp.Add(ListMatHang[i]);
                }

            ListMatHang = temp;
            Cal_TongTien();
        }

        public void huy_HoaDon()
        {
            ListMatHang.Clear();
            TongTien = "";
            MaHD = "";

            temp_MH_Mua = ListMatHang;
        }

        public void truHang()
        {
            ObservableCollection<MATHANG> list = new ObservableCollection<MATHANG>(DataProvider.Ins.DB.MATHANGs);

            foreach (var mh_mua in ListMatHang)
            {
                foreach (var mh_gian in list)
                    if (mh_gian.MaMH == mh_mua.MaMH)
                    {
                        mh_gian.SoLuongTonGian -= int.Parse(mh_mua.SoLuong);
                        DataProvider.Ins.DB.SaveChanges();
                    }
            }
        }

        #endregion

        #region Declare Command Variables

        public ICommand GetMaHDCommand { get; set; }
        public ICommand MaKHTextChangedCommand { get; set; }
        public ICommand XacNhanCommand { get; set; }
        public ICommand HuyCommand { get; set; }
        public ICommand ThemHangCommand { get; set; }
        public ICommand XoaHangCommand { get; set; }
        public ICommand LapPhieuDNXHCommand { get; set; }
        public ICommand DialogOK { get; set; }
        public ICommand CloseWindowCommand { get; set; }
        #endregion

        #region Declare Binding Variables

        private string _NgayThangNam;
        public string NgayThangNam
        {
            get { return _NgayThangNam; }
            set { _NgayThangNam = value; OnPropertyChanged(); }
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

        private bool _DialogOpen;
        public bool DialogOpen
        {
            get { return _DialogOpen; }
            set { _DialogOpen = value; OnPropertyChanged(); }
        }

        private string _TenNhanVien;
        public string TenNhanVien
        {
            get { return _TenNhanVien; }
            set { _TenNhanVien = value; OnPropertyChanged(); }
        }

        private string _TenQuay;
        public string TenQuay
        {
            get { return _TenQuay; }
            set { _TenQuay = value; OnPropertyChanged(); }
        }

        private string _MaHD;
        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; OnPropertyChanged(); }
        }

        private string _NgayLapHD;
        public string NgayLapHD
        {
            get { return _NgayLapHD; }
            set { _NgayLapHD = value; OnPropertyChanged(); }
        }

        private string _MaKH;
        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; OnPropertyChanged(); }
        }

        private string _TenKH;
        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; OnPropertyChanged(); }
        }

        private string _TongTien;
        public string TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; OnPropertyChanged(); }
        }

        private ListMatHangMua _SelectedMatHang;
        public ListMatHangMua SelectedMatHang
        {
            get { return _SelectedMatHang; }
            set { _SelectedMatHang = value; OnPropertyChanged(); }
        }

        private ObservableCollection<ListMatHangMua> _ListMatHang;
        public ObservableCollection<ListMatHangMua> ListMatHang
        {
            get { return _ListMatHang; }
            set { _ListMatHang = value; OnPropertyChanged(); }
        }

        #endregion

        #region Static
        public static ObservableCollection<ListMatHangMua> temp_MH_Mua = new ObservableCollection<ListMatHangMua>();
        #endregion

        public BanHang_ViewModel()
        {
            Init();
            CreateReport = false;

            GetMaHDCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                MaHD = create_MaHD();
                TenQuay = LoginViewModel.Quay.TenQuay;
            });

            ThemHangCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                ThemHang_ViewModel.okAdd = false;
                Window themHANG = new ThemHang_Window();
                themHANG.DataContext = new ThemHang_ViewModel();
                themHANG.ShowDialog();
                if (ThemHang_ViewModel.okAdd)
                {
                    add_MatHang(ThemHang_ViewModel.maMH, ThemHang_ViewModel.soLuong);
                }
                temp_MH_Mua = ListMatHang;
            });

            XoaHangCommand = new RelayCommand<Object>((p) => { if (SelectedMatHang!=null) return true; return false; }, (p) =>
            {
                xoa_MatHang();
                temp_MH_Mua = ListMatHang;
            });

            HuyCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                DialogResult kq = System.Windows.Forms.MessageBox.Show("Bạn có chắc hủy hóa đơn này không", "Hủy hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (kq == DialogResult.No) return;
                huy_HoaDon();

            });

            XacNhanCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                if (check_CreateBill() == false) return;
                ThongBao = "Lập hóa đơn thành công!";
                save_HoaDon();
                truHang();
                DialogOpen = true;
            });

            DialogOK = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                DialogOpen = false;
                if (ThongBao == "Lập hóa đơn thành công!")
                {
                    if (CreateReport)
                    {
                        TenNhanVien = LoginViewModel.TaiKhoanSuDung.HoTen;

                        ObservableCollection<ListMatHangMua> temp = new ObservableCollection<ListMatHangMua>();
                        foreach (var mh in ListMatHang)
                            temp.Add(mh);

                        BanHang_PrintPreview_ViewModel x = new BanHang_PrintPreview_ViewModel(MaHD, TenNhanVien, TongTien, temp);
                        BanHang_PrintPreview bill = new BanHang_PrintPreview(x);
                        bill.Show();
                    }

                    MaHD = "";
                    TongTien = "";
                    ListMatHang.Clear();
                }
          
            });

            CloseWindowCommand = new RelayCommand<Window>((p) => { return p == null ? false : true; }, (p) => {
                p.Close();
            });

            LapPhieuDNXHCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                PhieuDNXH_Window win = new PhieuDNXH_Window();
                win.ShowDialog();
            });
        }
    }
}

