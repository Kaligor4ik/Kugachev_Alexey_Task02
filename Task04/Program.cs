using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr2D= new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int[] arr = _2DArrayUtils.GetElementsByEvenPosition(arr2D);
            Print1DArr.PrintArr(arr);
            Console.WriteLine("Сумма элементов двумерного массива на четных позициях равна: {0}", arr.Sum());
            Console.ReadKey();
        }
    }
}
