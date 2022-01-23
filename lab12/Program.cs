using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
using System;
					
public class Program
{
	public static void Main()
	{
		/*1.   Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
		метод, определяющий длину окружности по заданному радиусу;
		метод, определяющий площадь круга по заданному радиусу;
		метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.*/
		try
		{
			Console.Write("Введите радиус окружности: ");
			double Radius = Convert.ToDouble(Console.ReadLine());
			if (Radius <= 0)
			{
				Console.Write("Радиус должен быть задан действительным числом.");
				return;
			}
			Console.Write("Введите координату Х точки: ");
			double positionX = Math.Abs(Convert.ToDouble(Console.ReadLine()));
			Console.Write("Введите координату Y точки: ");
			double positionY = Math.Abs(Convert.ToDouble(Console.ReadLine()));
			Circle.GetСircumference(Radius);
			Circle.GetSquare(Radius);
			Circle.GetPosition(Radius, positionX, positionY);
		}
		catch (FormatException)
		{
			Console.WriteLine("Неверный формат ввода.");
			return;
		}
	}

	static class Circle
	{
		public static void GetСircumference(double Radius)
		{
			double Сircumference = Math.PI * 2 * Radius;
			Console.WriteLine("Длина окружности равна {0:f2}", Сircumference);
		}
		public static void GetSquare(double Radius)
		{
			double Square = Math.PI * Math.Pow(Radius, 2.0);
			Console.WriteLine("Площадь круга равна {0:f2}", Square);
		}
		public static void GetPosition(double Radius, double positionX, double positionY)
		{
			if (positionX <= Radius && positionY <= Radius)
			{
				Console.WriteLine("Точка с координатами ({0},{1}) принадлежит кругу с радиусом {2}", positionX, positionY, Radius);
			}
			else
			{
				Console.WriteLine("Точка с координатами ({0},{1}) не принадлежит кругу с радиусом {2}", positionX, positionY, Radius);
			}
		}
	}
}