using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Массив из 7 элементов заполнить числами, вводимыми с клавиатуры. Определить их среднее арифметическое значение.
            int n = 7;
            double sum = 0;
            Console.WriteLine("Введите {0} чисел", n);
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
                sum += array[i];
            }
            double arithMean = Math.Round((sum / n), 2);
            Console.WriteLine("Среднее арифметическое введенных чисел = {0}", arithMean);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
