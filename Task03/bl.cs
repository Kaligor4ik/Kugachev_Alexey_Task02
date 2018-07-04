using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class bl
    {
        public static long GetSumArrayElements(long[] arr)
        {
            return arr.Sum(); ;
        }

        public static long[] GetPositiveArrayElements(long[] arr)
        {
            List<long> list = new List<long>();
            foreach (long i in arr)
            {
                if (i > 0)
                {
                    list.Add(i);
                }                
            }
            return list.ToArray();
        }
    }
}
