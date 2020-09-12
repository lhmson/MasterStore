using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterSaveDemo.Model;
using MasterSaveDemo.ViewModel;
using NUnit.Framework;

namespace MasterSaveDemo.UnitTest
{
    [TestFixture]
    public class TestTraCuu
    {
        private TraCuu_ViewModel _TraCuu;

        [SetUp]
        public void Setup()
        {
            _TraCuu = new TraCuu_ViewModel();
        }

        [TestCase("0", 0)]
        [TestCase("782", 782)]
        [TestCase("123,000", 123000)]
        [TestCase("5,120,000", 5120000)]

        public void Test_ChinhSoDu(string chuoi, decimal number)
        {
            Assert.AreEqual(chuoi, _TraCuu.ChinhSoDu(number));
        }

        [TestCase("STK0000001")]
        [TestCase("STK0000002")]
        [TestCase("STK0000003")]

        public void Test_GetSTK(string MaSTK)
        {
            SOTIETKIEM stk = _TraCuu.get_STK(MaSTK);
            if (stk == null)
                Assert.AreEqual(true, true);
            Assert.AreEqual(stk.MaSoTietKiem, MaSTK);
        }

        [TestCase("12000", "12000.150")]
        [TestCase("0", "0.122")]
        [TestCase("720", "720.450")]

        public void Test_Delete_ThapPhan(string res, string number)
        {
            Assert.AreEqual(res, _TraCuu.Delete_ThapPhan(number));
        }
    }
}