using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YampolskiiMO.Sprint4.Task5.V21.Lib
{
    public class DataService : ISprint4Task5V21
    {
        public int[,] Calculate(int[,] values)
        {
            for (int row = 0; row < values.GetLength(0); row++)
            {
                for (int column = 0; column < values.GetLength(1); column++)
                {
                    if (values[row, column] > 0)
                    {
                        values[row, column] = 1;
                    }
                }
            }

            return values;
        }
    }
}
