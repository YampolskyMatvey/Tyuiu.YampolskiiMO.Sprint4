using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YampolskiiMO.Sprint4.Task4.V29.Lib
{
    public class DataService : ISprint4Task4V29
    {
        public int Calculate(int[,] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                if (value % 2 == 0)
                {
                    sum += value;
                }
            }

            return sum;
        }
    }
}
