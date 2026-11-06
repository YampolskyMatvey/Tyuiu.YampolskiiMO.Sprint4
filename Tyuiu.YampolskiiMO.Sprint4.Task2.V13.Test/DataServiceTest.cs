using Tyuiu.YampolskiiMO.Sprint4.Task2.V13.Lib;

namespace Tyuiu.YampolskiiMO.Sprint4.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate_MultipliesEvenElements()
        {
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6 };
            var service = new DataService();

            Assert.AreEqual(18432, service.Calculate(values));
        }
    }
}
