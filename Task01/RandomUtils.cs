using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class RandomUtils
    {
        static Random rand = new Random();
        public static string GetString(int minValue, int maxValue, int length = 3)
        {            
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < length; i++)
            {
                char n = (char)rand.Next(minValue, maxValue);
                sb.Append(n);
            }           
            return sb.ToString();
        }

        public static long GetLong(int minValue, int maxValue, int length = 5)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int n = rand.Next(minValue, maxValue);
                sb.Append(n);
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
            return long.Parse(sb.ToString());
        }

        public static long GetLong(int minValue, int maxValue)
        {
            return rand.Next(minValue, maxValue);
        }
    }
}
