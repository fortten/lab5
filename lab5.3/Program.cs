using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Массив из 10 случайных чисел из диапазона [-50;50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 - по убыванию.
            #region Инициализация переменных
            int n = 10;
            Random random = new Random();
            double[] array = new double[n];            
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            #endregion
            Console.WriteLine();
            #region Сортировка первых 5 элементов по возрастанию
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        double t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            #endregion
            #region Сортировка вторых 5 элементов по убыванию
            for (int i = 5; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        double t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            #endregion
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
