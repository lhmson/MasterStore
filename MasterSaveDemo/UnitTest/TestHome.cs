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
    public class TestHome
    {
        private Home_PageViewModel _Home;

        [SetUp]
        public void Setup()
        {
            _Home = new Home_PageViewModel();
        }

        [Test]
        public void Test_TinhSoMo()
        {
            _Home.Tinh_SoMo();
            Assert.AreEqual(_Home.SL_SoMo != null, true);
        }

        [Test]
        public void Test_SoPhieuGui()
        {
            _Home.Tinh_SoPhieuGui_TongThu();
            Assert.AreEqual(_Home.SL_PhieuGui != null, true);
        }

        [Test]
        public void Test_TongThu()
        {
            _Home.Tinh_SoPhieuGui_TongThu();
            Assert.AreEqual(_Home.TongThu != null, true);
        }

        [Test]
        public void Test_TongChi()
        {
            _Home.Tinh_SoPhieuRut_TongChi();
            Assert.AreEqual(_Home.TongChi != null, true);
        }

        [Test]
        public void Test_SoPhieuRut()
        {
            _Home.Tinh_SoPhieuRut_TongChi();
            Assert.AreEqual(_Home.SL_PhieuRut != null, true);
        }
    }
}
