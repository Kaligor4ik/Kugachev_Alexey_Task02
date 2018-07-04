using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01;


namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArrayUtils ru = new RandomArrayUtils();

            Console.WriteLine("Укажите размерность массива: ");
            int size = InputUtils.EnterInteger();

            long[] arrLng = ru.BuildLongArray(size, -10);
            Print1DArr.PrettyPrintArr(arrLng);

            Console.WriteLine("Массив из положительных элементов: ");
            long[] positiveArr = bl.GetPositiveArrayElements(arrLng);
            Print1DArr.PrintArr(positiveArr);

            Console.WriteLine("Сумма положительных элементов массива: ");
            Console.WriteLine(bl.GetSumArrayElements(positiveArr));

            Console.ReadKey();
        }
    }
}
