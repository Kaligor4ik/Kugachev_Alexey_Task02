using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task01
{
    public class InputUtils
    {
        public static int EnterInteger()
        {
            ConsoleKeyInfo key;
            var rule = @"[0-9]";
            var value = new StringBuilder();

            while (true)
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                if (Regex.IsMatch(key.KeyChar.ToString(), rule))
                {
                    value.Append(key.KeyChar);
                    Console.Write(key.KeyChar);
                }
            }
            return Convert.ToInt32(value.ToString());
        }
    }
}
