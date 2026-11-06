using Tyuiu.YampolskiiMO.Sprint4.Task5.V21.Lib;

namespace Tyuiu.YampolskiiMO.Sprint4.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReplacesOnlyPositiveElements()
        {
            int[,] values =
            {
                { -8, 0, 2, -1, 1 },
                { 2, -2, -3, 0, -4 },
                { -5, 1, -6, -7, -8 },
                { 0, -1, 2, -2, 0 },
                { -3, -4, -5, -6, 2 }
            };

            int[] expected =
            {
                -8, 0, 1, -1, 1,
                1, -2, -3, 0, -4,
                -5, 1, -6, -7, -8,
                0, -1, 1, -2, 0,
                -3, -4, -5, -6, 1
            };

            CollectionAssert.AreEqual(expected, new DataService().Calculate(values).Cast<int>().ToArray());
        }
    }
}
