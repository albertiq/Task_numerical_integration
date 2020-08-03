using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_numerical_integration
{
    public class Numerical_methods
    {
        public delegate double Func(double x);
        static double Df(double x)
        {
            return Math.Cos(x);
        }
        static double F(double x)
        {
            return Math.Sin(x);
        }
        /// <param name="a">Начало интервала аргумента (X)</param>
        /// <param name="b">Конец интервала аргумента (X)</param>
        /// <param name="n">Число узлов сетки</param>
        /// <param name="f">Делегат функции</param>
        /// <returns>Вычисленное значение</returns>
        public static double Rectangle_method(double a, double b, uint n, Func <double, double> f)
        {
            double sum = 0.0;
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                sum += h * f(a + i * h);
            }
            return sum;
        }
        /// <param name="a">Начало интервала аргумента (X)</param>
        /// <param name="b">Конец интервала аргумента (X)</param>
        /// <param name="n">Число узлов сетки</param>
        /// <param name="f">Делегат функции</param>
        /// <returns>Вычисленное значение</returns>
        public static double Trapezoid_method(double a, double b, uint n, Func<double, double> f)
        {
            double sum = 0.0;
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                sum += 0.5 * h * (f(a + i * h) + f(a + (i + 1) * h));
            }
            return sum;
        }
        /// <param name="a">Начало интервала аргумента (X)</param>
        /// <param name="b">Конец интервала аргумента (X)</param>
        /// <param name="n">Число узлов сетки</param>
        /// <param name="f">Делегат функции</param>
        /// <returns>Вычисленное значение</returns>
        public static double Parabola_method(double a, double b, uint n, Func<double, double> f)
        {
            double sum = 0.0;
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                sum += h * (f(a + h * i) + 4 * f(a + h * (i + 0.5)) + f(a + h * (i + 1))) / 6;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            uint n;
            double a;
            double b;
            double result;
            Console.Write("Начало интервала а = ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Начало интервала b = ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Число узлов сетки n = ");
            n = uint.Parse(Console.ReadLine());

            result = Rectangle_method(a, b, n, Df);
            Console.WriteLine("Результат метода прямоугольников = " + result.ToString());

            result = Trapezoid_method(a, b, n, Df);
            Console.WriteLine("Результат метода трапеций = " + result.ToString());

            result = Parabola_method(a, b, n, Df);
            Console.WriteLine("Результат метода парабол = " + result.ToString());

            result = F(b) - F(a);
            Console.WriteLine("Аналитическое решение = " + result.ToString());

            Console.ReadKey();
        }
    }
}
