using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChigurovMV.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            value = value.ToLower();
            char FirstLetter = value[0];
            return value.IndexOf(FirstLetter) != value.LastIndexOf(FirstLetter);
        }
    }
}
