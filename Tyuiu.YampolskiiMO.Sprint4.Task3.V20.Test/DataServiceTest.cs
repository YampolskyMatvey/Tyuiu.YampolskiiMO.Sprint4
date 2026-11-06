using Tyuiu.YampolskiiMO.Sprint4.Task3.V20.Lib;

namespace Tyuiu.YampolskiiMO.Sprint4.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate_FindsMinimumInFirstColumn()
        {
            int[,] values =
            {
                { 8, 3, 7, 8, 5 },
                { 4, 3, 5, 3, 6 },
                { 5, 3, 8, 6, 3 },
                { 6, 3, 8, 5, 4 },
                { 7, 6, 8, 3, 4 }
            };

            Assert.AreEqual(4, new DataService().Calculate(values));
        }
    }
}
