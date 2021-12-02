using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    //1.Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
    //- метод, определяющий длину окружности по заданному радиусу;
    //- метод, определяющий площадь круга по заданному радиусу;
    //- метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа находит длину окружности и ее площадь по заданному радиусу. Определяет принадлежность точки с введенными координатами кругу.");
            Console.WriteLine("Введите радиус окружности:");
            Circle.Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности равна: L = {0:f2}", Circle.CircleLength());
            Console.WriteLine("Площадь круга равна: S = {0:f2}", Circle.Area());
            Console.WriteLine("Введите поочередно координаты (x0; y0) центра окружности:");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введенные координаты центра окружности: ({0} ; {1})", x0, y0);
            Console.WriteLine("Введите поочередно координаты (x1; y1) точки:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введенные координаты точки: ({0} ; {1})", x1, y1);
            Circle.PointBelongingCircle(x0, y0, x1, y1);
            Console.WriteLine("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }

    public static class Circle
    {
        static double radius;
        public static double Radius
        {
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("Значение радуса должно быть больше нуля.");
                }
            }
            get
            {
                return radius;
            }
        }
        public static double CircleLength()
        {
            double circleLength = 2 * Math.PI * Radius;
            return circleLength;
        }
        public static double Area()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
        public static void PointBelongingCircle(double x0, double y0, double x, double y)
        {
            double distanceBetweenCoordinates = Math.Sqrt(Math.Pow((x0 - x), 2) + Math.Pow((y0 - y), 2));
            if (distanceBetweenCoordinates <= Radius)
            {
                Console.WriteLine("Точка с введенными координатами принадлежит кругу.");
            }
            else
            {
                Console.WriteLine("Точка с введенными координатами не принадлежит кругу.");
            }
        }

    }
}
