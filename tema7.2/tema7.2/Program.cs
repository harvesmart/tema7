using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            int result;
            if (n > 123)
                result = Math.Abs(n - 123) * 3;
            else
                result = Math.Abs(n - 123);

            Console.WriteLine("Абсолютная разность: " + result);
        }
    }
}
