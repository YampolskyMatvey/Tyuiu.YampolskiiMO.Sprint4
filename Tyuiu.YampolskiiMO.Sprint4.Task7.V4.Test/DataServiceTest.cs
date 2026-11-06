using Tyuiu.YampolskiiMO.Sprint4.Task7.V4.Lib;

namespace Tyuiu.YampolskiiMO.Sprint4.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        [DataRow(3, 4, "382976421897", 36)]
        [DataRow(2, 3, "024680", 0)]
        public void Calculate_SumsOddDigits(int rows, int columns, string digits, int expected)
        {
            Assert.AreEqual(expected, new DataService().Calculate(rows, columns, digits));
        }
    }
}
