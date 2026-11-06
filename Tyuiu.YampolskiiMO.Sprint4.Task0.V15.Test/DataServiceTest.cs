using Tyuiu.YampolskiiMO.Sprint4.Task0.V15.Lib;

namespace Tyuiu.YampolskiiMO.Sprint4.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate_MultipliesOddElements()
        {
            int[] values = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            var service = new DataService();

            Assert.AreEqual(138915, service.Calculate(values));
        }
    }
}
