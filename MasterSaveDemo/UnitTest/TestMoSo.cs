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
    public class TestMoSo
    {
        private MoSo_ViewModel _MoSo;

        [SetUp]
        public void Setup()
        {
            _MoSo = new MoSo_ViewModel();
        }

        [Test]
        public void KiemTraChuoiToanKhoangTrang_1()
        {
            Assert.AreEqual(true, _MoSo.check_hasallWhiteSpace("     "));
        }

        [Test]
        public void KiemTraChuoiToanKhoangTrang_2()
        {
            Assert.AreEqual(false, _MoSo.check_hasallWhiteSpace("a   b"));
        }

        [Test]
        public void KiemTraChuoiChuaKhoangTrang_1()
        {
            Assert.AreEqual(true, _MoSo.check_hasaWhiteSpace("aaaa    "));
        }

        [Test]
        public void KiemTraChuoiChuaKhoangTrang_2()
        {
            Assert.AreEqual(false, _MoSo.check_hasaWhiteSpace("sanhcute"));
        }

        [Test]
        public void ChuoiToanSo_1()
        {
            Assert.AreEqual(true, _MoSo.CheckAllNumber("12345"));
        }

        [Test]
        public void ChuoiToanSo_2()
        {
            Assert.AreEqual(false, _MoSo.CheckAllNumber("12ac34"));
        }

        [Test]
        public void Format_DateTime_1()
        {
            Assert.AreEqual("01/12/2020", _MoSo.FormatDateTime("01/12/2020 12:04:54"));
        }

        [Test]
        public void Format_DateTime_2()
        {
            Assert.AreEqual("12/06/2020", _MoSo.FormatDateTime("12/06/2020       9:20:13"));
        }

        [Test]
        public void Analys_MaSTK_1()
        {
            Assert.AreEqual(12, _MoSo.analysis_CodeSTK("STK00012"));
        }

        [Test]
        public void Analys_MaSTK_2()
        {
            Assert.AreEqual(1002, _MoSo.analysis_CodeSTK("STK1002"));
        }

        [Test]
        public void Create_MaSTK_1()
        {
            Assert.AreEqual("STK0000001", _MoSo.create_CodeSTK(1));
            Assert.AreEqual("STK0000002", _MoSo.create_CodeSTK(2));
            Assert.AreEqual("STK0000003", _MoSo.create_CodeSTK(3));
        }

        [Test]
        public void Create_MaSTK_2()
        {
            Assert.AreEqual("STK0000134", _MoSo.create_CodeSTK(134));
            Assert.AreEqual("STK1234567", _MoSo.create_CodeSTK(1234567));
            Assert.AreEqual("STK0000000", _MoSo.create_CodeSTK(0));
        }

        [Test]
        public void Tim_KyHan_1()
        {
            Assert.AreEqual(90, _MoSo.search_KyHan("3 tháng"));
            Assert.AreEqual(180, _MoSo.search_KyHan("6 tháng"));
        }

        [Test]
        public void Tim_KyHan_2()
        {
            Assert.AreEqual(0, _MoSo.search_KyHan("Không kì hạn"));
        }

        [Test]
        public void Tim_MaLTK_1()
        {
            Assert.AreEqual("LTK001", _MoSo.search_MaLTK("Không kì hạn"));
            Assert.AreEqual("LTK002", _MoSo.search_MaLTK("3 tháng"));
        }

        [Test]
        public void Tim_MaLTK_2()
        {
            Assert.AreEqual("0", _MoSo.search_MaLTK("9 tháng"));
        }

        [Test]
        public void Tim_LaiSuat_1()
        {
            Assert.AreEqual(0.5, _MoSo.search_LaiSuat("LTK001"));
            Assert.AreEqual(5, _MoSo.search_LaiSuat("LTK002"));
            Assert.AreEqual(5.5, _MoSo.search_LaiSuat("LTK003"));
        }

        [Test]
        public void Tim_LaiSuat_2()
        {
            Assert.AreEqual(0, _MoSo.search_LaiSuat("LTK004"));
            Assert.AreEqual(0, _MoSo.search_LaiSuat("    "));
        }

        [Test]
        public void Tim_Value_ThamSo()
        {
            Assert.AreEqual(1000000, _MoSo.GetThamSo("Số tiền gửi tối thiểu"));
            Assert.AreEqual(100000, _MoSo.GetThamSo("Tiền gửi thêm tối thiểu"));
            Assert.AreEqual(1, _MoSo.GetThamSo("Đóng sổ tự động"));
        }
    }
}