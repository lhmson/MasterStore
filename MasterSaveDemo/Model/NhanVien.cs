using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSaveDemo.Model
{
    public class NhanVien
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string TenNhom { get; set; }

        public NhanVien(string tk, string mk, string ten, string chucvu)
        {
            TenDangNhap = tk;
            MatKhau = mk;
            HoTen = ten;
            TenNhom = chucvu;
        }
    }
}
