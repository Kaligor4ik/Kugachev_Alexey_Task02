
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class ArrReWriter
    {
        public static T[] Replace<T>(T[] arr, T replaceFrom, T replaceTo)
        {
            T[] newArr = arr;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(replaceFrom))
                {
                    newArr[i] = replaceTo;
                }
            }
            return newArr;
        }

        public static long ReplaceIfFromRange(long el, long minValue, long maxValue, long replaceTo)
        {
            if (el < maxValue & el > minValue)
            {
                return replaceTo;
            }
            else
            {
                return el;
            }            
        }

        public static long[,,] ReplaceAllFromRange(long[,,] arr, long minValue, long maxValue, long replaceTo)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    {
                    for(int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = ReplaceIfFromRange(arr[i, j, k], minValue, maxValue, replaceTo);
                    }
                }
            return arr;
        }
    }
}