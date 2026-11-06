using Tyuiu.YampolskiiMO.Sprint4.Task4.V29.Lib;

namespace Tyuiu.YampolskiiMO.Sprint4.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate_SumsEvenElements()
        {
            int[,] values =
            {
                { 5, 6, 5, 6, 5 },
                { 5, 5, 5, 8, 4 },
                { 8, 5, 5, 8, 8 },
                { 6, 5, 4, 4, 8 },
                { 8, 5, 6, 8, 8 }
            };

            Assert.AreEqual(100, new DataService().Calculate(values));
        }
    }
}
