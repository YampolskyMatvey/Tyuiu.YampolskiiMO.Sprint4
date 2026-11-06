using Tyuiu.YampolskiiMO.Sprint4.Task1.V4.Lib;

namespace Tyuiu.YampolskiiMO.Sprint4.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate_MultipliesOddElements()
        {
            int[] values = { 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 };
            var service = new DataService();

            Assert.AreEqual(2835, service.Calculate(values));
        }
    }
}
