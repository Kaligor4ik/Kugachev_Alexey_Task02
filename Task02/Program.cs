using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            long[,,] array3Da = new long[3, 3, 3]
            {
                {
                    { -1, 2, 3 }, { 4, -5, 6 }, { 4, -5, 6 }
                },
                {
                    { 7, -8, -9 }, { 10, -11, 12 }, { 4, -5, 6 }
                },
                {
                    { 7, -8, -9 }, { 10, -11, 12 }, { 4, -5, 6 }
                }
            };
            Console.WriteLine("Масси до преобразования");
            Print1DArr.Print3DArr(array3Da);
            long[,,] newArray3Da = ArrReWriter.ReplaceAllFromRange(array3Da, 0, long.MaxValue, 0);
            Console.WriteLine("Масси после преобразования");
            Print1DArr.Print3DArr(newArray3Da);
            Console.ReadKey();
        }
    }
}