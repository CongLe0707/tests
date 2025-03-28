using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demo5
{
    [TestClass]
    public class TinhToanTests
    {
        private readonly tinhToan _tinhToan = new tinhToan();

        public static IEnumerable<object[]> GetTestData()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "data", "test.csv");
            using (var reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Bỏ qua dòng tiêu đề

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(','); // Tách dữ liệu theo dấu ","

                    int x = int.Parse(values[0]);
                    int y = int.Parse(values[1]);
                    int expected = int.Parse(values[2]);

                    yield return new object[] { x, y, expected };
                }
            }
        }

        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Tru_TraVeKetQuaDung(int x, int y, int expected)
        {
            int result = _tinhToan.Tru(x, y);

            NUnit.Framework.Assert.That(expected, Is.EqualTo(result));
        }
    }
}
