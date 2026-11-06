namespace Tyuiu.YampolskiiMO.Sprint4.Task0.V15.Lib
{
    public class DataService
    {
        public int Calculate(int[] values)
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
