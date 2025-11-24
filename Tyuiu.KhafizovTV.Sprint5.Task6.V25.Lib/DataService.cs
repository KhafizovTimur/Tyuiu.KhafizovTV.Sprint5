using System.Globalization;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhafizovTV.Sprint5.Task6.V25.Lib
{
    public class DataService : ISprint5Task6V25
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            int count = 0;

            foreach (char c in content)
            {
                if (c == '!')
                {
                    count++;
                }
            }

            return count;
        }
    }
}