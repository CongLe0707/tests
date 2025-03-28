using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo5
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test()
        {
            tinhToan tinhToan = new tinhToan();
            int temp = tinhToan.Tru(3, 6);
            int res = -3;
            Assert.That(temp, Is.EqualTo(res));
        }

    }
}
