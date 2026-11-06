using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YampolskiiMO.Sprint4.Task0.V15.Lib
{
    public class DataService : ISprint4Task0V15
    {
        public int GetMultOddArrEl(int[] values)
        {
            int product = 1;
            foreach (int value in values)
            {
                if (value % 2 != 0)
                {
                    product *= value;
                }
            }

            return product;
        }
    }
}
