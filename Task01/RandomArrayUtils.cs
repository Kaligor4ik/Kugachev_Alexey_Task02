using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class RandomArrayUtils
    {
        public string[] BuildStringArray(int length, int minValue = 'A', int maxValue = 'Z')
        {
            string[] arrStr = new string[length];
            for(int i = 0; i < arrStr.Length; i++)
            {
                arrStr[i] = RandomUtils.GetString(minValue, maxValue);
            }
            return arrStr;
        }

        public long[] BuildLongArray(int length, int minValue = 0, int maxValue = 10)
        {
            long[] arrLng = new long[length];
            for (int i = 0; i < arrLng.Length; i++)
            {
                arrLng[i] = RandomUtils.GetLong(minValue, maxValue);
            }
            return arrLng;
        }
    }
}
