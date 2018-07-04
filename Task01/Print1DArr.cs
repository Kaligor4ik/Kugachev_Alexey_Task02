using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Print1DArr
    {
        public static void PrettyPrintArr<T>(T[] o)
        {
            Console.WriteLine("Массив до сортировки");
            PrintArr(o);
            Console.WriteLine("Массив после сортировки");
            Array.Sort(o);
            PrintArr(o);
        }

        public static void PrintArr<T>(T[] o)
        {
            foreach (T obj in o)
            {
                Console.WriteLine(obj);
            }
        }

        public static void Print3DArr<T>(T[,,] arr)
        {

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(String.Format("{0,3}", arr[i, j, k]));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
