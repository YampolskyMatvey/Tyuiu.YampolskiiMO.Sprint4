using Tyuiu.YampolskiiMO.Sprint4.Task6.V3.Lib;

namespace Tyuiu.YampolskiiMO.Sprint4.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate_CountsOnlyStringsShorterThanSix()
        {
            string[] values = { "Май", "Июнь", "Январь", "Февраль", "Март" };

            Assert.AreEqual(3, new DataService().Calculate(values));
        }
    }
}
