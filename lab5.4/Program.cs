using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Массив из 20 случайных чисел из диапазона [-50;50]. Определить количество нечетных положительных элементов, стоящих на четных местах.
            #region Инициализация переменных
            int n = 20;
            int count = 0;            
            Random random = new Random();
            int[] array = new int[n];
            #endregion
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
                if (array[i] > 0 && (array[i] % 2) > 0 && i % 2 == 0)
                {
                    count++;
                }                                 
            }            
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных чисел, стоящих на четных местах = {0}", count);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
