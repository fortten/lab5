using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Запросить N. Сформировать двумерный массив NxN. Заполнить числами с клавиатуры.
               Проверить, является ли матрица магическим квадратом - сумма чисел в каждых строке, столбце и диагонали должна быть одинакова.
            */
            Console.WriteLine("Введите размер квадратного массива");
            #region Инициализация переменных
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int sumLine, sumColumn, sumDiag1, sumDiag2;
            sumLine = sumColumn = sumDiag1 = sumDiag2 = 0;
            int sum = Convert.ToInt32(n * (Math.Pow(n, 2) + 1) / 2); // Константа магического квадрата
            int[,] t = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Введите [{0},{1}] число:", i, j);
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            #endregion
            Console.WriteLine();
            #region Вывод массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }
            #endregion
            #region Вычисления
            for (int i = 0, j = 0; (i < n); i++, j++)
            {
                sumLine += t[i, j];
                sumColumn += t[j, i];
                sumDiag1 += t[i, i];
                sumDiag2 += t[i, n - i - 1];
            }
            #endregion
            Console.WriteLine();
            if (sumLine != sum || sumColumn != sum || sumDiag1 != sum || sumDiag2 != sum) // Проверка условий
            {
                Console.WriteLine("Это не магический квадрат");
            }
            else
            {
                Console.WriteLine("Это магический квадрат");
            }
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
