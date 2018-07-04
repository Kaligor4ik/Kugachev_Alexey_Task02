using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class _2DArrayUtils
    {
        public static int[] GetElementsByEvenPosition(int[,] arr)
        {
            List<int> list = new List<int>(); 
            for(int i = 0; i < arr.GetLength(0); i++)
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    if ((i + k) % 2 == 0)
                    {
                        list.Add(arr[i, k]);
                    }
                }
            return list.ToArray();
        }
    }
}
