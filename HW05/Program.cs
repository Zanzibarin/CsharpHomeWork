using System;
using System.Collections;

namespace MagicDates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Jan = new int[31];
            int[] Feb1 = new int[28];
            int Feb2 = 29;
            int[] Mar = new int[31];
            int[] Apr = new int[30];
            int[] May = new int[31];
            int[] Jun = new int[30];
            int[] Jul = new int[31];
            int[] Aug = new int[31];
            int[] Sep = new int[30];
            int[] Oct = new int[31];
            int[] Nov = new int[30];
            int[] Dec = new int[31];

            Jan = Month(Jan);
            Feb1 = Month(Feb1);
            Mar = Month(Mar);
            Apr = Month(Apr);
            May = Month(May);
            Jun = Month(Jun);
            Jul = Month(Jul);
            Aug = Month(Aug);
            Sep = Month(Sep);
            Oct = Month(Oct);
            Nov = Month(Nov);
            Dec = Month(Dec);

            Year(Jan, 1);
            Year(Feb1, 2);
            Year(Mar, 3);
            Year(Apr, 4);
            Year(May, 5);
            Year(Jun, 6);
            Year(Jul, 7);
            Year(Aug, 8);
            Year(Sep, 9);
            Year(Oct, 10);
            Year(Nov, 11);
            Year(Dec, 12);
            LeapYear(Feb2);

        }


        static int[] Month(int[] mon)
        {
            for (int i = 1; i < mon.Length + 1; i++)
                mon[i - 1] = i;
            return mon;
        }


        static void Year(int[] mon, int MonNumb)
        {
            for (int i = 0; i < 100; i++)
                foreach (int month in mon)
                    if ((month * MonNumb) == i)
                    {
                        Console.Write(String.Format(month.ToString("D2")));
                        Console.Write("."); Console.Write(String.Format(MonNumb.ToString("D2")));
                        Console.Write(".2"); Console.Write(String.Format(i.ToString("D3"))); Console.Write("\n");
                    }
        }


        static void LeapYear(int month)
        {
            for (int i = 0; i < 100; i = i + 4)
                if ((month * 2) == i)
                {
                    Console.Write(String.Format(month.ToString("D2")));
                    Console.Write(".02.2");
                    Console.Write(String.Format(i.ToString("D3"))); Console.Write("\n");
                }
        }
    }
}
