using System;

namespace PracticeThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[5]; //Объявление массива points со свойствам класса Point
            points[0] = GetPointFromUser("A");
            points[1] = GetPointFromUser("B");
            points[2] = GetPointFromUser("C");
            points[3] = GetPointFromUser("D");
            points[4] = GetPointFromUser("E");

            double AB = CalcLineLength(points[0], points[1]);
            double BE = CalcLineLength(points[1], points[4]);
            double AE = CalcLineLength(points[0], points[4]);
            double AC = CalcLineLength(points[0], points[2]);
            double BC = CalcLineLength(points[1], points[2]);
            double CD = CalcLineLength(points[2], points[3]);
            double AD = CalcLineLength(points[0], points[3]);

            double ABE = CalcTriangleArea(AB, BE, AE);
            double ABC = CalcTriangleArea(AB, BC, AC);
            double ACD = CalcTriangleArea(AC, CD, AD);

            double totalArea = ABE + ABC + ACD;
            Console.WriteLine($"Площадь пятиугольника: {totalArea}");
            Console.WriteLine($"Площадь треугольника ABE {ABE}");
            Console.WriteLine($"Площадь треугольника ABC {ABC}");
            Console.WriteLine($"Площадь треугольника ACD {ACD}");
        }

        static double CalcTriangleArea(double side1, double side2, double side3) 
        {
            double p = (side1 + side2 + side3) / 2; //Нахождение полупериметра для формулы Герона
            double s = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)); //Нахождение площади по формуле Герона
            return s; //Результат расчёта формулы

        }

        static double CalcLineLength(Point point1, Point point2) //Метод, отвечающий за расчёт длинн сторон треугольников от точки до точки
        {
            double section = Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow((point1.Y - point2.Y), 2));
            return section;
        }

        static Point GetPointFromUser(string pointName) //Метод, отвечающий за получение крайних точек сторон треугольников от пользователя
        {
            Console.WriteLine($"Укажите координаты точки {pointName}");
            Point point = new Point(); //Объявление объекта point со свойствам класса Point
            string[] inputs = Console.ReadLine().Split(',');
            point.X = double.Parse(inputs[0]);
            point.Y = double.Parse(inputs[1]);
            return point;
        }
    }

    public class Point // Класс Point с присущими ему свойствами
    {
        public double X; //Объявление поля X
        public double Y; //Объявление поля Y
    }
}
