using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 2, 9, 1 };
            int[] array2 = { 8, 6, 3 };

            //сортировка по возрастанию
            Array.Sort(array1);
            Console.WriteLine("Массив по возрастанию: " + string.Join(", ", array1));

            //сортировка по убыванию
            Array.Sort(array1);
            Array.Reverse(array1);
            Console.WriteLine("Массив по убыванию: " + string.Join(", ", array1));

            //объединение 2-ух массивов
            int[] mergedArray = new int[array1.Length + array2.Length];
            array1.CopyTo(mergedArray, 0);
            array2.CopyTo(mergedArray, array1.Length);
            Console.WriteLine("Объединённый массив: " + string.Join(", ", mergedArray));
        }
    }
}
