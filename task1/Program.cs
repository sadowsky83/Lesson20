using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Делегаты. Расчет окружности п орадиусу
        delegate double Circle(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"При радиусе окружности R={radius}:");
            Circle circle = new Circle(Length);
            circle += Area;
            circle += Volume;
            circle?.Invoke(radius);
            Console.ReadKey();
        }
        static double Length(double radius)
        {
            double length = 2 * Math.PI * radius;
            Console.WriteLine($"\nДлина окружности L={String.Format("{0:f}", length)};");
            return length;
        }
        static double Area(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"\nПлощадь круга S={String.Format("{0:f}", area)};");
            return area;
        }
        static double Volume(double radius)
        {
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"\nОбъём шара V={String.Format("{0:f}", volume)}.");
            return volume;
        }
    }
}
