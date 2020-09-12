using MasterSaveDemo.Model;
using MasterSaveDemo.ViewModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MasterSaveDemo.UnitTest
{
    [TestFixture]
    class TestThayDoiQuyDinh
    {
        ThayDoiQuyDinh_ViewModel viewModel;

        [SetUp]
        public void Init()
        {
            viewModel = new ThayDoiQuyDinh_ViewModel();
        }

        [Test]
        public void TestHiddenPopupBox()
        {
            viewModel.HiddenPopupBox();

            Assert.IsTrue(viewModel.VisibilityPopup1 == Visibility.Hidden);
            Assert.IsTrue(viewModel.VisibilityPopup2 == Visibility.Hidden);
            Assert.IsTrue(viewModel.VisibilityPopup3 == Visibility.Hidden);
            Assert.IsTrue(viewModel.VisibilityPopup4 == Visibility.Hidden);
            Assert.IsTrue(viewModel.VisibilityPopup5 == Visibility.Hidden);
            Assert.IsTrue(viewModel.VisibilityPopup6 == Visibility.Hidden);
        }

        [TestCase("3 thang", "90", "5.5", "90", "Rut het", true, true)]

        [TestCase("", "90", "5.5", "90", "Rut het", true, false)]
        [TestCase("   ", "90", "5.5", "90", "Rut het", true, false)]

        [TestCase("3 thang", "", "5.5", "90", "Rut het", true, false)]
        [TestCase("3 thang", "   ", "5.5", "90", "Rut het", true, false)]

        [TestCase("3 thang", "90", "", "90", "Rut het", true, false)]
        [TestCase("3 thang", "90", "   ", "90", "Rut het", true, false)]

        [TestCase("3 thang", "90", "5.5", "", "Rut het", true, false)]
        [TestCase("3 thang", "90", "5.5", "   ", "Rut het", true, false)]

        [TestCase("3 thang", "90", "5.5", "90", null, true, false)]
        public void TestCheckValidData_Add(string tenLoai, string kyHan, string laiSuat, string thoiGian, string quyDinh, bool flag, bool expectedRes)
        {
            viewModel.TenLoaiTietKiem = tenLoai;
            viewModel.KyHan = kyHan;
            viewModel.LaiSuat = laiSuat;
            viewModel.ThoiGianGuiToiThieu = thoiGian;
            viewModel.SelectedQuyDinh = quyDinh;

            viewModel.CheckValidData_Add(ref flag);

            Assert.AreEqual(expectedRes, flag);
        }

        [TestCase("LTK188", "5 tháng", true, true)]
        [TestCase("LTK188", "fgh", true, true)]
        [TestCase("LTK188", "3 tháng", true, false)]
        [TestCase("LTK001", "2 tháng", true, false)]
        [TestCase("LTK001", "fgh", true, false)]
        public void TestCheckDuplicatedData_Add(string maLoai, string tenLoai, bool flag, bool expectedRes)
        {
            viewModel.MaLoaiTietKiem = maLoai;
            viewModel.TenLoaiTietKiem = tenLoai;
            viewModel.CheckDuplicatedData_Add(ref flag);

            Assert.AreEqual(expectedRes, flag);
        }

        [TestCase("", "180", true, false)]
        [TestCase("   ", "10", true, false)]
        [TestCase("6.6", "", true, false)]
        [TestCase("2.7", "   ", true, false)]

        [TestCase("5", "180", true, true)]
        [TestCase("5.5", "210", true, true)]

        public void TestCheckValidData_EditLTK(string laiSuat, string thoiGian, bool flag, bool expectedRes)
        {
            viewModel.LaiSuat = laiSuat;
            viewModel.ThoiGianGuiToiThieu = thoiGian;
            viewModel.CheckValidData_EditLTK(ref flag);

            Assert.AreEqual(expectedRes, flag);
        }

        [TestCase("5.5", 5.5, "180", 180, true, false)]
        [TestCase("5.5", 5, "180", 180, true, true)]
        [TestCase("5.5", 5.5, "180", 210, true, true)]

        public void TestCheckDuplicatedData_EditLTK(string laiSuat, double selectedLaiSuat, string thoiGian,
            int selectedThoiGian, bool flag, bool expectedRes)
        {
            LOAITIETKIEM selected = new LOAITIETKIEM();
            selected.LaiSuat = selectedLaiSuat;
            selected.ThoiGianGuiToiThieu = selectedThoiGian;
            viewModel.SelectedItemLTK = selected;

            viewModel.LaiSuat = laiSuat;
            viewModel.ThoiGianGuiToiThieu = thoiGian;
            viewModel.CheckDuplicatedData_EditLTK(ref flag);

            Assert.AreEqual(expectedRes, flag);
        }

        [TestCase("", true, false)]
        [TestCase("   ", true, false)]
        [TestCase("100000", true, true)]

        public void TestCheckValidData_EditThamSo(string giaTri, bool flag, bool expectedRes)
        {
            viewModel.GiaTri = giaTri;
            viewModel.CheckValidData_EditThamSo(ref flag);

            Assert.AreEqual(expectedRes, flag);
        }

        [TestCase("số tiền", "số tiền", "100000", 100000, true, true, false)]
        [TestCase("số tiền", "số tiền", "100000", 300000, true, true, true)]
        [TestCase("số tiền", "thời gian", "100000", 100000, true, true, true)]
        [TestCase("Đóng sổ tự động", "Đóng sổ tự động", "Bật", 1, true, true, false)]
        [TestCase("Đóng sổ tự động", "Đóng sổ tự động", "Tắt", 0, false, true, false)]
        [TestCase("Đóng sổ tự động", "Đóng sổ tự động", "Bật", 1, false, true, true)]
        [TestCase("Đóng sổ tự động", "Đóng sổ tự động", "Tắt", 0, true, true, true)]
        public void TestCheckDuplicatedData_EditThamSo(string tenTS, string selectedTenTS, string giaTri,
            decimal selectedGiaTri, bool isChecked, bool flag, bool expectedRes)
        {
            viewModel.TenThamSo = tenTS;
            viewModel.GiaTri = giaTri;
            viewModel.IsCheckedToggle = isChecked;

            THAMSO selected = new THAMSO();
            selected.TenThamSo = selectedTenTS;
            selected.GiaTri = selectedGiaTri;
            viewModel.SelectedItemThamSo = selected;

            viewModel.CheckDuplicatedData_EditThamSo(ref flag);

            Assert.AreEqual(expectedRes, flag);
        }

        [Test]
        public void TestResetTextbox()
        {
            viewModel.ResetTextbox();

            Assert.AreEqual("", viewModel.MaLoaiTietKiem);
            Assert.AreEqual("", viewModel.TenLoaiTietKiem);
            Assert.AreEqual("", viewModel.KyHan);
            Assert.AreEqual("", viewModel.LaiSuat);
            Assert.AreEqual("", viewModel.ThoiGianGuiToiThieu);
            Assert.AreEqual(null, viewModel.SelectedQuyDinh);
        }

        [TestCase(5, "LTK005")]
        [TestCase(18, "LTK018")]
        [TestCase(222, "LTK222")]
        public void TestCreate_MaLTK(int stt, string result)
        {
            Assert.AreEqual(result, viewModel.Create_MaLTK(stt));
        }

        [TestCase(Visibility.Hidden, Visibility.Visible, false, 13)]
        [TestCase(Visibility.Visible, Visibility.Hidden, false, 23)]
        [TestCase(Visibility.Visible, Visibility.Hidden, true, 12)]
        [TestCase(Visibility.Hidden, Visibility.Hidden, false, 0)]

        public void TestDisableButton(Visibility add, Visibility edit, bool delete, int expected)
        {
            int actual = viewModel.DisableButton(add, edit, delete);
            Assert.AreEqual(expected, actual);
        }
    }
}