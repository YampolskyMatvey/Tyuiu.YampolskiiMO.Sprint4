using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YampolskiiMO.Sprint4.Task6.V3.Lib
{
    public class DataService : ISprint4Task6V3
    {
        public int Calculate(string[] values)
        {
            return Array.FindAll(values, value => value.Length < 6).Length;
        }
    }
}
