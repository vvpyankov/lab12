using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Для вычисления характеристик круга укажите его радиус: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                if (radius <= 0)
                {
                    Console.Write("Радиус не может быть меньше 0 (включительно).");
                    return;
                }
                Console.Write("Для определения принадлежности точки окружности укажите значение Х: ");
                double coorX = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                Console.Write("А теперь значение Y для точки: ");
                double coorY = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                Circle.circLenght(radius);
                Circle.circSquare(radius);
                Circle.GetPosition(radius, coorX, coorY);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода.");
                return;
            }
            Console.ReadKey();
        }

        static class Circle
        {
            public static void circLenght(double radius)
            {
                double Lenght = Math.PI * 2 * radius;
                Console.WriteLine("Длина окружности равна {0:f2}", Lenght);
            }
            public static void circSquare(double radius)
            {
                double Square = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine("Площадь круга равна {0:f2}", Square);
            }
            public static void GetPosition(double radius, double coorX, double coorY)
            {
                if (coorX <= radius && coorY <= radius)
                {
                    Console.WriteLine("Поздравляю! Точка ({0},{1}) скорее всего принадлежит кругу с радиусом {2}", coorX, coorY, radius);
                }
                else
                {
                    Console.WriteLine("Мимо! Точка ({0},{1}) не принадлежит кругу с радиусом {2}", coorX, coorY, radius);
                }
            }
        }
    }
}


