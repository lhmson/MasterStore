using MasterSaveDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MasterSaveDemo.Helper;

namespace MasterSaveDemo.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        static public NGUOIDUNG TaiKhoanSuDung; // tao bien static nguoi dung

        public ICommand CloseWindowCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }

        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

        public LoginViewModel()
        {
            //DatabaseCheck.Ins.Check();
            UserName = "";
            Password = "";

            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                if (UserName == null || Password == null)
                    MessageBox.Show("Mời nhập tài khoản!");

                ObservableCollection<NGUOIDUNG> Account = new ObservableCollection<NGUOIDUNG>(DataProvider.Ins.DB.NGUOIDUNGs);

                foreach (var item in Account)
                {
                    if (item.TenDangNhap == UserName && item.MatKhau == Password)
                    {
                        //Gan static TaiKhoanSuDung
                        TaiKhoanSuDung = item;
                        //MessageBox.Show("Đăng nhập thành công");
                        p.Close();
                        return;
                    }

                }
                MessageBox.Show("Tài khoản không hợp lệ!");
              
                //CheckLogin(p);
            });

            CloseWindowCommand = new RelayCommand<Window>((p) => { return p == null ? false : true; }, (p) => {
                p.Close();
                System.Environment.Exit(1);
            });

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) =>
            {
                Password = p.Password;
            });
        }
    }
}
