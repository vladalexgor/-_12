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
    //- метод, проверяющий принадлежность точки с координатами (x, y) кругу с радиусом r и координатами центра x0, y0.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа находит длину окружности и ее площадь по заданному радиусу. Определяет принадлежность точки с введенными координатами кругу.");
            Console.WriteLine("Введите радиус окружности:");
            try
            {
                double r = Convert.ToDouble(Console.ReadLine());
                if (r > 0)
                {
                    Console.WriteLine("Длина окружности равна: L = {0:f2}", Circle.CircleLength(r));
                    Console.WriteLine("Площадь круга равна: S = {0:f2}", Circle.Area(r));
                    Console.WriteLine("Введите поочередно координаты (x0; y0) центра окружности:");
                    double x0 = Convert.ToDouble(Console.ReadLine());
                    double y0 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введенные координаты центра окружности: ({0} ; {1})", x0, y0);
                    Console.WriteLine("Введите поочередно координаты (x1; y1) точки:");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    double y1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введенные координаты точки: ({0} ; {1})", x1, y1);
                    Circle.PointBelongingCircle(x0, y0, x1, y1, r);
                    Console.WriteLine("Для завершения программы нажмите любую клавишу.");
                }
                else
                {
                    Console.WriteLine("Радиус должен быть задан значением больше нуля.");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }

    public static class Circle
    {
       public static double CircleLength(double radius)
        {
            double circleLength = 2 * Math.PI * radius;
            return circleLength;
        }
        public static double Area(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        public static void PointBelongingCircle(double x0, double y0, double x, double y, double radius)
        {
            double distanceBetweenCoordinates = Math.Sqrt(Math.Pow((x0 - x), 2) + Math.Pow((y0 - y), 2));
            if (distanceBetweenCoordinates <= radius)
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
