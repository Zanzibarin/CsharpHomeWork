using System;
using System.Collections.Generic;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double[]> points = GetPointsFromUser();

            double SumX, SumY, SumXDoble, SumXY;

            SumX = 0;
            SumY = 0;
            SumXDoble = 0;
            SumXY = 0;

            foreach (double[] point in points)
            {
                SumX += point[0];
                SumY += point[1];
                SumXY += point[0] * point[1];
                SumXDoble += point[0] * point[0];
            }

            double n = points.Count;
            double m = (SumXY - SumX * SumY / n) / (SumXDoble - SumX * SumX / n);
            double xAverage = SumX / n;
            double yAverage = SumY / n;
            double b = yAverage - m * xAverage;

            Console.WriteLine($"y = {m} x + {b}");
        }
        

        static List<double[]> GetPointsFromUser()    
        {
            Console.WriteLine("Введите координаты точек 'х' 'у'. Введите 'q' для выхода."); //запрос на ввод значений
            var points = new List<double[]>(); //объявление динамического двумерного массива List

            while (true)
            {
                String input = Console.ReadLine(); //строка для ввода
                if (input == "q") break; //если в строке введено "q", выполнение программы прирывается
                double[] xAndy = new double[2];
                string[] inputsDivided = input.Split('.'); //указание на разделитель ввиде запятой
                xAndy[0] = double.Parse(inputsDivided[0]); //ячейка массива для x
                xAndy[1] = double.Parse(inputsDivided[1]); //ячейка массива для y
                points.Add(xAndy);
            }
            return points;
        }
    }
}
