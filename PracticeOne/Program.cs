using System;

namespace PracticeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (isSimple(i))
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
        
        private static bool isSimple(int N) //метод, определяющий, простое число, или нет
        {            
            for (int i = 2; i <= (int)(N / 2); i++) //чтобы убедится, простое число, или нет, достаточно проверить, не делитсья ли число на числа до его половины
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
    }

}