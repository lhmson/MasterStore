using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using MasterSaveDemo.Model;
using MasterSaveDemo.Helper;
using System.Collections.ObjectModel;

namespace MasterSaveDemo.ViewModel
{
    public class RutTien_ViewModel : BaseViewModel
	{
		//Bien chua ket qua kiem tra hop le
		private bool Result_KiemTraHopLe;
		private bool Result_KiemTraNhapLai; //true = da nhap lai moi nhat, false = chua nhap lai moi nhat
		private string Result_Dialog;
		//Khai bao cac command
		public ICommand Click_MSTKCommand { get; set; }
		public ICommand MSTK_TextChangedCommand { get; set; }
		public ICommand KiemTraCommand { get; set; }
		public ICommand Click_GiaoDichCommand { get; set; }
		public ICommand STR_TextChangedCommand { get; set; }
		public ICommand TKH_TextChangedCommand { get; set; }
		public ICommand Click_CapNhatCommand { get; set; }
		public ICommand STKEnterKeyDown_Command { get; set; }
		public ICommand SoTienRutEnterKeyDown_Command { get; set; }
		public ICommand Click_CopySoDuSTRCommand { get; set; }
		public ICommand DialogOK { get; set; }
		public ICommand DialogCancel { get; set; }
        public ICommand Refresh { get; set; }

        #region Binding tu view
        //Ngay Rut, kieu string
        private string _NgayRut;
		public string NgayRut
		{
			get => _NgayRut;
			set { _NgayRut = value; OnPropertyChanged();}
		}
		//Ma so tiet kiem
		private string _MaSoTietKiem;

		public string MaSoTietKiem
		{
			get { return _MaSoTietKiem; }
			set { _MaSoTietKiem = value; OnPropertyChanged();}
		}
		//Ten Khach hang
		private string _TenKhachHang;

		public string TenKhachHang
		{
			get { return _TenKhachHang; }
			set { _TenKhachHang = value; OnPropertyChanged(); }
		}
		//So Tien Rut
		private string _SoTienRut;

		public string SoTienRut
		{
			get { return _SoTienRut; }
			set { _SoTienRut = value; OnPropertyChanged(); }
		}
		//Ten loai tiet kiem
		private string _TenLoaiTietKiem;

		public string TenLoaiTietKiem
		{
			get { return _TenLoaiTietKiem; }
			set { _TenLoaiTietKiem = value; OnPropertyChanged(); }
		}
		//So du tai khoan
		private string _SoDu;

		public string SoDu
		{
			get { return _SoDu; }
			set { _SoDu = value; OnPropertyChanged(); }
		}
		//CMND
		private string _CMND;

		public string CMND
		{
			get { return _CMND; }
			set { _CMND = value; OnPropertyChanged(); }
		}
		//Ngay dao han ke tiep
		private string _NgayDaoHan;

		public string NgayDaoHan
		{
			get { return _NgayDaoHan; }
			set { _NgayDaoHan = value; OnPropertyChanged(); }
		}

		private string _ThongBao;

		public string ThongBao
		{
			get { return _ThongBao; }
			set { _ThongBao = value; OnPropertyChanged(); }
		}
		//listView
		private ObservableCollection<ListLichSuPhieuRut> _ListLichSuGD;

		public ObservableCollection<ListLichSuPhieuRut> ListLichSuGD
		{
			get { return _ListLichSuGD; }
			set { _ListLichSuGD = value; OnPropertyChanged(); }
		}

		private string _MaPR;

		public string MaPR
		{
			get { return _MaPR; }
			set { _MaPR = value; OnPropertyChanged(); }
		}

		private string _NgayRutTien;

		public string NgayRutTien
		{
			get { return _NgayRutTien; }
			set { _NgayRutTien = value; OnPropertyChanged(); }
		}


		private string _TienRut;
		public string TienRut
		{
			get { return _TienRut; }
			set { _TienRut = value; OnPropertyChanged(); }
		}

		//in phieu
		private bool _CreatePR;
		public bool CreatePR
		{
			get { return _CreatePR; }
			set { _CreatePR = value; OnPropertyChanged(); }
		}

		//Cac nut dung cho thong bao
		private string _ThongBao_MaSo;
		public string ThongBao_MaSo
		{
			get { return _ThongBao_MaSo; }
			set { _ThongBao_MaSo = value; OnPropertyChanged(); }
		}

		private string _SoTietKiem_Check;
		public string SoTietKiem_Check
		{
			get { return _SoTietKiem_Check; }
			set { _SoTietKiem_Check = value; OnPropertyChanged(); }
		}

		private string _ThongBao_TienRut;
		public string ThongBao_TienRut
		{
			get { return _ThongBao_TienRut; }
			set { _ThongBao_TienRut = value; OnPropertyChanged(); }
		}

		private string _SoTienRut_Check;
		public string SoTienRut_Check
		{
			get { return _SoTienRut_Check; }
			set { _SoTienRut_Check = value; OnPropertyChanged(); }
		}

		private string _ThongBao_DaoHan;
		public string ThongBao_DaoHan
		{
			get { return _ThongBao_DaoHan; }
			set { _ThongBao_DaoHan = value; OnPropertyChanged(); }
		}

		private string _DaoHan_Check;

		public string DaoHan_Check
		{
			get { return _DaoHan_Check; }
			set { _DaoHan_Check = value; OnPropertyChanged(); }
		}

		private string _ThongBao_NgayRut;
		public string ThongBao_NgayRut
		{
			get { return _ThongBao_NgayRut; }
			set { _ThongBao_NgayRut = value; OnPropertyChanged(); }
		}

		private string _NgayRut_Check;
		public string NgayRut_Check
		{
			get { return _NgayRut_Check; }
			set { _NgayRut_Check = value; OnPropertyChanged(); }
		}
		//DialogHost
		private bool _DialogOpen;

		public bool DialogOpen
		{
			get { return _DialogOpen; }
			set { _DialogOpen = value; OnPropertyChanged(); }
		}

		private string _IsCancelVisible;
		public string IsCancelVisible
		{
			get { return _IsCancelVisible; }
			set { _IsCancelVisible = value; OnPropertyChanged(); }
		}

		//Quy Dinh
		private string _QuyDinhRutTien;

		public string QuyDinhRutTien
		{
			get { return _QuyDinhRutTien; }
			set { _QuyDinhRutTien = value; OnPropertyChanged(); }
		}


		#endregion
		#region Khoi tao
		//Khoi tao viewmodel
		public RutTien_ViewModel()
		{
			CapNhatQuyDinh();
			Reset_Check();
			CreatePR = true;
			Result_KiemTraNhapLai = true;
			//Dat ngay rut theo ngay hom nay
			NgayRut = DateTime.Today.ToString("dd/MM/yyyy");
			//Khi click vao nut ben canh MSTK
			Click_MSTKCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
			{
				if (!CapNhatThongTin())
				{
					Result_KiemTraNhapLai = true;
					Result_KiemTraHopLe = false;
					ThongBao = "Lấy thông tin thất bại";
				}
				else
				{
					Result_KiemTraHopLe = false;
				}
			});
			//khi nhan enter o mo so
			STKEnterKeyDown_Command = new RelayCommand<Object>((p) => { return true; }, (p) =>
			 {
				 if (!CapNhatThongTin())
				 {
					 Result_KiemTraNhapLai = true;
					 Result_KiemTraHopLe = false;
					 ThongBao = "Lấy thông tin thất bại";
				 }
				 else
				 {
					 Result_KiemTraHopLe = false;
				 }
			 });
			//khi thay doi textbox MSTK
			MSTK_TextChangedCommand = new RelayCommand<TextBox>((p) => { return true; }, (p) =>
			{
				try
				{
					TenKhachHang = "";
					SoDu = "";
					CMND = "";
					TenLoaiTietKiem = "";
					NgayDaoHan = "";
					ThongBao = "";
					Result_KiemTraHopLe = false;
					Result_KiemTraNhapLai = true;
					ListLichSuGD = new ObservableCollection<ListLichSuPhieuRut>();
				}
				catch (Exception e)
				{

				}
			});
			//Lenh kiem tra tinh hop le
			KiemTraCommand = new RelayCommand<Button>((p) => { return true; }, (p) =>
			{
				if (!KiemTraHopLe())
				{
					Result_KiemTraHopLe = false;
					Result_KiemTraNhapLai = true;
					ThongBao = "Kiểm tra thất bại.";
				}
				else
				{
					if (Result_KiemTraHopLe == true)
					{
						DialogOpen = true;
						IsCancelVisible = "Collapsed";
						ThongBao = "Thông tin phiếu rút hợp lệ";
					}
				}
			});
			SoTienRutEnterKeyDown_Command = new RelayCommand<Object>((p) => { return true; }, (p) =>
			{
				if (!KiemTraHopLe())
				{
					Result_KiemTraHopLe = false;
					Result_KiemTraNhapLai = true;
					ThongBao = "Kiểm tra thất bại.";
				}
				else
				{
					if (Result_KiemTraHopLe == true)
					{
						DialogOpen = true;
						IsCancelVisible = "Collapsed";
						ThongBao = "Thông tin phiếu rút hợp lệ";
					}
				}
			});
			//Lenh thuc hien giao dich
			Click_GiaoDichCommand = new RelayCommand<Button>((p) => { return Result_KiemTraHopLe; }, (p) =>
			{
				if (!ThucHienGiaoDich())
				{
					ThongBao += "Không thể thưc hiện giao dịch do lỗi không xác định.";
				}
				else
				{
					Result_KiemTraHopLe = false;
					DialogOpen = true;
					IsCancelVisible = "Collapsed";
					ThongBao += "Đã tạo phiếu rút thành công.";
				}
			});
			STR_TextChangedCommand = new RelayCommand<TextBox>((p) => { return true; }, (p) =>
			{
				try
				{
					Result_KiemTraHopLe = false;
				}
				catch (Exception e)
				{

				}
			});
			TKH_TextChangedCommand = new RelayCommand<TextBox>((p) => { return true; }, (p) =>
			{
				try
				{
					Result_KiemTraHopLe = false;
				}
				catch (Exception e)
				{

				}
			});
			Click_CapNhatCommand = new RelayCommand<Button>((p) => { return !Result_KiemTraNhapLai; }, (p) =>
			{
				MessageBoxResult re = MessageBox.Show("Bạn có chắc muốn nhập lãi vào vốn? Tiến trình này không thể hoàn tác.", "Thông báo", MessageBoxButton.OKCancel);
				if (re == MessageBoxResult.OK)
				{
					if (!NhapLaiVaoVon.Ins.StartThis(MaSoTietKiem, true))
					{
						ThongBao = "Có lỗi xảy ra hoặc sổ tiết kiệm này đã được nhập lãi rồi!";
						DaoHan_Check = "Error";
						ThongBao_DaoHan = "Có lỗi xảy ra hoặc sổ tiết kiệm này đã được nhập lãi rồi!";
					}
					else
					{
						Result_KiemTraHopLe = false;
						//DaoHan_Check = "Check";
						//ThongBao_DaoHan = "Đã cập nhật lãi vào số dư";
						DialogOpen = true;
						IsCancelVisible = "Collapsed";
						ThongBao = "Đã cập nhật lãi vào số dư";
						if (!CapNhatThongTin())
						{
							SoTietKiem_Check = "Error";
							ThongBao_MaSo = "Lấy thông tin thất bại";
							ThongBao = "Lấy thông tin thất bại";
						}
						else
						{
							Result_KiemTraHopLe = false;
						}
					}
				}
			});
			Click_CopySoDuSTRCommand = new RelayCommand<Button>((p) => { return true; }, (p) =>
			{
				if(!Copy_SD_STR())
				{
					ThongBao = "Sao chép không thành công!";
				}
				else
				{

				}
			});
			DialogOK = new RelayCommand<Button>((p) => { return true; }, (p) =>
			{
				Result_Dialog = "OK";
				DialogOpen = false;
			});
			DialogCancel = new RelayCommand<Button>((p) => { return IsCancelVisible == "Visible"; }, (p) =>
			{
				Result_Dialog = "Cancel";
				DialogOpen = false;
			});

            Refresh = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                Reset_Check();
                MaSoTietKiem = "";
                SoTienRut = "";
                TenKhachHang = "";
            });
        }
		public void Reset_Check()
		{
			SoTietKiem_Check = "None";
			SoTienRut_Check = "None";
			DaoHan_Check = "None";
			NgayRut_Check = "None";
			ThongBao_DaoHan = "";
			ThongBao_MaSo = "";
			ThongBao_TienRut = "";
			ThongBao_NgayRut = "";
		}
		public bool BindingLichSu(string mastk)
		{
			try
			{
				ListLichSuGD = new ObservableCollection<ListLichSuPhieuRut>();

				ObservableCollection<PHIEURUT> List_PR = new ObservableCollection<PHIEURUT>(DataProvider.Ins.DB.PHIEURUTs);
				var lichsu = from list in List_PR
							 where list.MaSoTietKiem == mastk
							 orderby list.MaPhieuRut descending
							 select new ListLichSuPhieuRut(list.MaPhieuRut, list.NgayRut.ToString("dd/MM/yyyy"), list.SoTienRut.ToString("0,000"));
				foreach (var ls in lichsu)
				{
					ListLichSuGD.Add(ls);
				}
				return true;
			}
			catch(Exception e)
			{
				return false;
			}
		}
		private bool CapNhatThongTin()
		{
			try
			{
				Reset_Check();
				SOTIETKIEM temp = Tim_MSTK(MaSoTietKiem);
				if (temp != null)
				{
					if (temp.NgayDongSo == null)
					{
						TenLoaiTietKiem = Tim_MaLoaiTietKiem(temp.MaLoaiTietKiem).TenLoaiTietKiem;
						TenKhachHang = temp.TenKhachHang;
						if (temp.SoDu < 1000)
						{
							SoDu = temp.SoDu.ToString();
						}
						else
						{
							SoDu = temp.SoDu.ToString("0,000");
						}
						CMND = temp.SoCMND;
						if (Tim_MaLoaiTietKiem(temp.MaLoaiTietKiem).KyHan == 0)
						{
							NgayDaoHan = "Không xác định";
						}
						else
						{
							NgayDaoHan = temp.NgayDaoHanKeTiep.ToString("dd/MM/yyyy");
						}
						BindingLichSu(temp.MaSoTietKiem);
						KiemTraNhapLai();
						//SoTietKiem_Check = "Check";
						//ThongBao_MaSo = "Đã cập nhật thông tin sổ tiết kiệm.";
						//ThongBao = "Đã cập nhật thông tin sổ tiết kiệm.";
					}
					else
					{
						BindingLichSu(temp.MaSoTietKiem);
						//Thong bao da dong so o day
						SoTietKiem_Check = "Error";
						ThongBao_MaSo = "Sổ tiết kiệm này đã đóng!";
						ThongBao = "Sổ tiết kiệm này đã đóng!";
					}
				}
				else
				{
					if (!String.IsNullOrWhiteSpace(MaSoTietKiem))
					{
						SoTietKiem_Check = "Error";
						ThongBao_MaSo = "Mã STK không đúng hoặc không tồn tại, kiểm tra xem đã đúng định dạng hay chưa";
						ThongBao = "Không tìm thấy sổ tiết kiệm phù hợp!";
					}
					else
					{
						SoTietKiem_Check = "Error";
						ThongBao_MaSo = "Hãy nhập mã sổ tiết kiệm trước khi bấm kiểm tra!";
						ThongBao = "Hãy nhập mã sổ tiết kiệm trước khi bấm kiểm tra!";
					}
				}
				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}
		private bool KiemTraHopLe()
		{
			Reset_Check();
			ThongBao = "";
			Result_KiemTraHopLe = true;
			try
			{
				if (decimal.Parse(SoTienRut) < 1000)
				{
				}
				else
				{
					SoTienRut = decimal.Parse(SoTienRut).ToString("0,000");
					Result_KiemTraHopLe = true;
				}
			}
			catch (Exception e)
			{

			}

			try
			{
				CapNhatThongTin();
				if(SoTietKiem_Check == "Error")
				{
					Result_KiemTraHopLe = false;
					Result_KiemTraNhapLai = true;
					return true;
				}
				SOTIETKIEM info_stk = Tim_MSTK(MaSoTietKiem);
				LOAITIETKIEM info_loaitietkiem = Tim_MaLoaiTietKiem(info_stk.MaLoaiTietKiem);
				if(info_stk.NgayMoSo.AddDays(info_loaitietkiem.ThoiGianGuiToiThieu) > DateTime.Today )
				{
					NgayRut_Check = "Error";
                    ThongBao_NgayRut = "Ngày mở sổ là: " + info_stk.NgayMoSo.ToString("dd/MM/yyyy") + ". Chưa đủ số ngày gửi tối thiểu (" + info_loaitietkiem.ThoiGianGuiToiThieu.ToString() + " ngày)"; ;
					//ThongBao += "Chưa đủ số ngày gửi tối thiểu.\n";
					Result_KiemTraHopLe = false;
				}
				else
				{
					//NgayRut_Check = "Check";
					//ThongBao_NgayRut = "Đã đủ số ngày gửi tối thiểu";
					if (!KiemTraNhapLai())
					{
						DaoHan_Check = "Error";
						ThongBao_DaoHan = "Lỗi, không xác định được thông tin đáo hạn.";
						ThongBao += "Lỗi, không xác định được thông tin đáo hạn.\n";
						Result_KiemTraHopLe = false;
					}
					else
					{
						if(Result_KiemTraNhapLai == false)
						{
							DaoHan_Check = "Error";
							ThongBao_DaoHan = "Cần nhập lãi trước khi rút.";
							ThongBao += "Cần nhập lãi trước khi rút.\n";
							Result_KiemTraHopLe = false;
						}
						else
						{
							//DaoHan_Check = "Check";
							//ThongBao_DaoHan = "Đã nhập lãi vào sổ này rồi";
						}
					}
				}
				if (String.IsNullOrWhiteSpace(SoTienRut))
				{
					SoTienRut_Check = "Error";
					ThongBao_TienRut = "Vui lòng nhập số tiền rút.";
					ThongBao += "Vui lòng nhập số tiền rút.\n";
					Result_KiemTraHopLe = false;
				}
				else
				{
					if (check_hasaWhiteSpace(SoTienRut))
					{
						SoTienRut_Check = "Error";
						ThongBao_TienRut += "Số tiền không thể chứa khoảng trắng";
						Result_KiemTraHopLe = false;
					}
					else
					{
						if (decimal.Parse(SoTienRut) < 1000)
						{
							SoTienRut_Check = "Error";
							ThongBao_TienRut += "Không thể rút số tiền ít hơn 1000 đồng.";
							Result_KiemTraHopLe = false;
						}
						else
						{
							if (info_loaitietkiem.QuyDinhSoTienRut == "Rút hết" && decimal.Parse(SoTienRut) < decimal.Parse(SoDu))
							{
								SoTienRut_Check = "Error";
								ThongBao_TienRut += "Loại tiết kiệm có kì hạn phải rút toàn bộ.\n";
								ThongBao += "Loại tiết kiệm có kì hạn phải rút toàn bộ.\n";
								Result_KiemTraHopLe = false;
							}
							else
							{
								if (decimal.Parse(SoTienRut) > decimal.Parse(SoDu))
								{
									SoTienRut_Check = "Error";
									ThongBao_TienRut += "Không thể rút nhiều hơn số dư tài khoản.\n";
									ThongBao += "Không thể rút nhiều hơn số dư tài khoản.\n";
									Result_KiemTraHopLe = false;
								}
								else
								{
									//SoTienRut_Check = "Check";
									//ThongBao_TienRut = "Có thể rút số tiền này.";
								}
							}
						}
					}
				}
				return true; 
			}
			catch (Exception e)
			{
				Result_KiemTraHopLe = false;
				return false; 
			}
		}
		private bool KiemTraNhapLai()
		{
			try
			{
				Result_KiemTraNhapLai = true;
				SOTIETKIEM info_stk = Tim_MSTK(MaSoTietKiem);
				LOAITIETKIEM info_loaitietkiem = Tim_MaLoaiTietKiem(info_stk.MaLoaiTietKiem);
				if (info_stk.NgayMoSo.AddDays(info_loaitietkiem.ThoiGianGuiToiThieu) > DateTime.Today)
				{
					//khong the tinh lai do chua du so ngay gui toi thieu (xem quy dinh)
				}
				else
				{
					if (info_loaitietkiem.KyHan != 0)
					{
						if (info_stk.NgayDaoHanKeTiep < DateTime.Today.AddDays(info_loaitietkiem.KyHan))
						{
							Result_KiemTraHopLe = false;
							Result_KiemTraNhapLai = false;
						}
					}
					else
					{
						if (info_stk.NgayDaoHanKeTiep != DateTime.Today.AddDays(1))
						{
							Result_KiemTraHopLe = false;
							Result_KiemTraNhapLai = false;
						}
					}
				}
				return true;
			}
			catch(Exception e)
			{
				Result_KiemTraNhapLai = true;
				return false;
			}
		}
		private bool ThucHienGiaoDich()
		{
			try
			{
				ThongBao = "";
				PHIEURUT info_PhieuRut = new PHIEURUT();
				if (DataProvider.Ins.DB.PHIEURUTs.Count() == 0)
				{
					info_PhieuRut.MaPhieuRut = "PR0000001";
				}
				else
				{
					info_PhieuRut.MaPhieuRut = "PR0000000";
					decimal temp_dem = DataProvider.Ins.DB.PHIEURUTs.Count();
					string temp = (temp_dem+1).ToString();
					info_PhieuRut.MaPhieuRut = info_PhieuRut.MaPhieuRut.Remove(9 - temp.Length, temp.Length) + temp;
				}
				info_PhieuRut.MaSoTietKiem = this.MaSoTietKiem;
				info_PhieuRut.NgayRut = DateTime.Today;
				info_PhieuRut.SoTienRut = decimal.Parse(this.SoTienRut);
				DataProvider.Ins.DB.PHIEURUTs.Add(info_PhieuRut);
				DataProvider.Ins.DB.SaveChanges();

				SOTIETKIEM stk = DataProvider.Ins.DB.SOTIETKIEMs.Where(x => x.MaSoTietKiem == this.MaSoTietKiem).Single();
				stk.SoDu -= decimal.Parse(this.SoTienRut);
				if(stk.SoDu<1)
				{
					stk.SoDu = 0;
				}
				DataProvider.Ins.DB.SaveChanges();

				if (CreatePR == true)
				{
					PhieuRut_PrintPreview_ViewModel PhieuRutVM = new PhieuRut_PrintPreview_ViewModel(info_PhieuRut.MaPhieuRut, TenKhachHang, info_PhieuRut.NgayRut.ToString("dd/MM/yyyy"), info_PhieuRut.SoTienRut.ToString());
					PhieuRut_PrintPreview PhieuRut = new PhieuRut_PrintPreview(PhieuRutVM);
					PhieuRut.ShowDialog();
				}

				if (stk.SoDu < 1)
				{
					DongSoTuDong(info_PhieuRut.MaSoTietKiem);
				}
				CapNhatThongTin();
				TenKhachHang = "";
				SoDu = "";
				CMND = "";
				TenLoaiTietKiem = "";
				NgayDaoHan = "";
				Result_KiemTraHopLe = false;
				Result_KiemTraNhapLai = true;
				SoTienRut = "";

				return true;
			}
			catch(Exception e)
			{
				return false;
			}
		}
		private bool DongSoTuDong(string mstk)
		{
			try
			{
				if(GetThamSo("Đóng sổ tự động") == 1)
				{
					SOTIETKIEM temp = DataProvider.Ins.DB.SOTIETKIEMs.Where(x => x.MaSoTietKiem == mstk).Single();
					temp.NgayDongSo = DateTime.Today;
					DataProvider.Ins.DB.SaveChanges();
					ThongBao = "Đã đóng sổ tiết kiệm.\n";
				}
				else
				{
					ThongBao = "Đã rút tiền thành công.\n";
				}
				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}
		private bool Copy_SD_STR()
		{
			try
			{
				SoTienRut = SoDu.Replace(",", "");
				return true;
			}
			catch(Exception e)
			{
				return false;
			}
		}
		private void CapNhatQuyDinh()
		{
			QuyDinhRutTien = "Loại tiết kiệm có kỳ hạn chỉ được rút khi quá kỳ hạn và phải rút hết toàn bộ, khi này tiền lãi được tính với mức lãi suất của loại không kỳ hạn.\n"
							+ "Loại tiết kiệm không kỳ hạn được rút khi gửi trên số ngày tối thiểu theo quy định và có thể rút số tiền nhỏ hơn hoặc bằng số dư hiện có.\n";
			if (GetThamSo("Đóng sổ tự động") == 1)
			{
				QuyDinhRutTien += "Sổ sau khi rút hết tiền sẽ tự động đóng.";
			}
			else
			{
			}
		}
		//Ham ben duoi duoc lay tu MoSo
		private bool check_hasaWhiteSpace(string chuoi)
		{
			if (chuoi == null) return false;
			foreach (var item in chuoi)
				if (item == ' ')
					return true;
			return false;
		}
		#endregion
		#region Cac ham xu li database
		//lay ra so tiet kiem khi biet Ma so tiet kiem 
		private SOTIETKIEM Tim_MSTK(string mstk)
		{
			List<SOTIETKIEM> List_SoTietKiem = DataProvider.Ins.DB.SOTIETKIEMs.ToList();
			foreach (SOTIETKIEM stk in List_SoTietKiem)
			{
				if (stk.MaSoTietKiem == mstk)
					return stk;
			}
			return null;
		}
		//lay ra loai tiet kiem tu ma loai tiet kiem
		private LOAITIETKIEM Tim_MaLoaiTietKiem(string mltk)
		{
			List<LOAITIETKIEM> List_LoaiTietKiem = DataProvider.Ins.DB.LOAITIETKIEMs.ToList();
			foreach (LOAITIETKIEM ltk in List_LoaiTietKiem)
			{
				if (ltk.MaLoaiTietKiem == mltk)
					return ltk;
			}
			return null;
		}
		//lay ra tham so can tim
		private decimal GetThamSo(string tenthamso)
		{
			List<THAMSO> List_ThamSo = DataProvider.Ins.DB.THAMSOes.ToList();
			foreach(THAMSO ts in List_ThamSo)
			{
				if (ts.TenThamSo == tenthamso)
					return ts.GiaTri;
			}
			return -1;
		}
        #endregion
    }
}
