using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YampolskiiMO.Sprint4.Task2.V13.Lib
{
    public class DataService : ISprint4Task2V13
    {
        public int Calculate(int[] values)
        {
            int product = 1;
            foreach (int value in values)
            {
                if (value % 2 == 0)
                {
                    product *= value;
                }
            }

            return product;
        }
    }
}
