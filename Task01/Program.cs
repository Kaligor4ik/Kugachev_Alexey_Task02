using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArrayUtils ru = new RandomArrayUtils();

            Console.WriteLine("Укажите тип элементов массива: \n1) Строковый(по умолчанию)\n2) Числовой");
            int choise = InputUtils.EnterInteger();

            Console.WriteLine("Укажите размерность массива: ");
            int size = InputUtils.EnterInteger();

            switch (choise)
            {
                case (2):
                    long[] arrInt = ru.BuildLongArray(size);
                    Print1DArr.PrettyPrintArr(arrInt);
                    break;
                default:
                    string[] arrStr = ru.BuildStringArray(size);
                    Print1DArr.PrettyPrintArr(arrStr);
                    break;
            }
            Console.ReadKey();
        }

     
    }
}
