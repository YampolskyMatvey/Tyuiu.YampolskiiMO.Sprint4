using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YampolskiiMO.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] values)
        {
            int min = values[0, 0];
            for (int row = 1; row < values.GetLength(0); row++)
            {
                min = Math.Min(min, values[row, 0]);
            }

            return min;
        }
    }
}
