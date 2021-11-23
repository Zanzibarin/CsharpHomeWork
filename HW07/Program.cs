using System;
using System.Collections;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            char[] symbols = "АВСЕНКМОРТХ".ToCharArray();
            ArrayList number = new ArrayList();
            number.Add(symbols[RandSymb(symbols)]);
            number.Add(RandDig(digits));
            number.Add(RandDig(digits));
            number.Add(RandDig(digits));
            number.Add(symbols[RandSymb(symbols)]);
            number.Add(symbols[RandSymb(symbols)]);
            foreach (object s in number)
            {
                Console.Write(s);
            }

        }
        static int RandDig(int[] d)
        {
            Random rand = new Random();
            int index = rand.Next(0, d.Length);
            return d[index];
        }
        static int RandSymb(char[] s)
        {
            Random rand = new Random();
            int index = rand.Next(0, s.Length);
            return index;
        }
    }
}
