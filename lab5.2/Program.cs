using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Массив из 15 случайных элементов из диапазона [0;50]. Определить сумму максимального и минимального элементов массива.
            #region Инициализация переменных
            int n = 15;
            Random random = new Random();
            double[] array = new double[n];
            double max = 0;
            double min = 50;
            double sum;
            #endregion
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
                if (array[i] > max) // Поиск максимального элемента массива
                    max = array[i];
                if (array[i] < min) // Поиск минимального элемента массива
                    min = array[i];
            }
            Console.WriteLine();
            sum = max + min;
            Console.WriteLine("Сумма максимального и минимального элементов = {0}", sum);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
