using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterSaveDemo.ViewModel;
using NUnit.Framework;

namespace MasterSaveDemo.UnitTest
{
    [TestFixture]
    public class TestQuanLyNhanVien
    {
        private QuanLyNhanSu_ViewModel _QLNS;

        [SetUp]
        public void Setup()
        {
            _QLNS = new QuanLyNhanSu_ViewModel();
        }

        [TestCase(true, "Quản trị viên")]
        [TestCase(true, "Trưởng Phòng Nhân Sự")]
        [TestCase(false, "Kế toán")]

        public void KiemTraChuoiToanKhoangTrang(bool ok, string name)
        {
            Assert.AreEqual(ok, _QLNS.Check_TenNhomQuyen(name));
        }

        [Test]
        public void Test_TaoMaNhomNguoiDung_1()
        {
            Assert.AreEqual(6, _QLNS.CreateCodeNhomNguoiDung());
        }

        [TestCase(1, "Quản Trị Viên")]
        [TestCase(2, "Kiểm Toán Viên")]
        [TestCase(3, "Giao Dịch Viên")]

        public void Tim_MaNhom(int number, string name)
        {
            Assert.AreEqual(number, _QLNS.search_MaNhom(name));
        }

        [Test]
        public void Tim_MaNhom_2()
        {
            Assert.AreEqual(0, _QLNS.search_MaNhom("Kế toán"));
        }
    }

}