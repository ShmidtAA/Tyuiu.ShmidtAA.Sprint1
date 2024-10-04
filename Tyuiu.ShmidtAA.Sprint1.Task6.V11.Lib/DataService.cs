using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShmidtAA.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            if (value[0] == value[1])
            {
                return true;
            }
            return false;
        }
    }
}
