using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YampolskiiMO.Sprint4.Task7.V4.Lib
{
    public class DataService : ISprint4Task7V4
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < m; column++)
                {
                    matrix[row, column] = value[row * m + column] - '0';
                }
            }

            int sum = 0;
            foreach (int digit in matrix)
            {
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }
    }
}
