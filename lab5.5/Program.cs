using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Запросить N. Сформировать двумерный массив NxN вида: 1 0 1 0 1
                         *                                                      0 1 0 1 0
                         *                                                      1 0 1 0 1
                         *                                                      0 1 0 1 0
                         *                                                      1 0 1 0 1
                         */
            Console.WriteLine("Введите целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int m = n;
            int[,] t = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = (i + j) % 2 == 1 ? 0 : 1;
                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
