using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterStoreDemo.ViewModel;
using NUnit.Framework;

namespace MasterStoreDemo.UnitTest
{
    [TestFixture]
    public class TestThemHang
    {
        private ThemHang_ViewModel _ThemHang;

        [SetUp]
        public void Setup()
        {
            _ThemHang = new ThemHang_ViewModel();
        }

        [TestCase("083994", true)]
        [TestCase("123ff", false)]
        [TestCase("@jxjx2244", false)]
        [TestCase("33388493", true)]
        [TestCase("đjj2234", false)]
        [TestCase("  ", false)]
        [TestCase(null, false)]
        [TestCase("10  1", false)]
        [TestCase("  1a1", false)]
        [TestCase(null, false)]
        [TestCase("â", false)]
        [TestCase("1.", false)]
        [TestCase(null, false)]
        [TestCase("1.22", false)]
        public void TestCheckNumber(string a, bool b)
        {
            Assert.IsTrue(_ThemHang.check_AllNumber(a) == b);
        }


    }
}
