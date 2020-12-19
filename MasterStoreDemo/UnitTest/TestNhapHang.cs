using MasterStoreDemo.Model;
using MasterStoreDemo.ViewModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MasterStoreDemo.UnitTest
{
    [TestFixture]
    class TestNhapHang
    {
        [TestFixture]
        public class UnitTestBanHang
        {
            private ThemHang_ViewModel _ThemHang;

            [SetUp]
            public void Setup()
            {
                _ThemHang = new ThemHang_ViewModel();
            }

            [TestCase("03994993", true)]
            [TestCase("0399ssaaa3", false)]
            [TestCase("12345la", false)]
            [TestCase("0", true)]
            [TestCase("@123", false)]
            [TestCase("dhjd892", false)]
            [TestCase("019ndn", false)]
            [TestCase("aanb", false)]
            [TestCase("idmkdm12", false)]

            public void TestCheckNumber(string input, bool output)
            {
                Assert.AreEqual(_ThemHang.check_AllNumber(input), output);
            }

          
        }
    }
}
