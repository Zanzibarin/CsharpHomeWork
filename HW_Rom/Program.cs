using System;
using System.Collections.Generic;

namespace Romanian
{
    class Converter
    {
        private Dictionary<char, int> digits;

        public Converter()
        {
            digits = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };
        }
        public int Convert(string r)
        {
            string rom = r.ToUpper();
            int retVal = 0;
            char[] romarr = rom.ToCharArray(0, rom.Length);
            try
            {
                for (int i = 0; i < romarr.Length; ++i)
                {
                    if (i == romarr.Length - 1)
                        retVal += digits[romarr[i]];
                    else if (digits[romarr[i + 1]] > digits[romarr[i]])
                        retVal -= digits[romarr[i]];
                    else
                        retVal += digits[romarr[i]];
                }
            }
            catch (System.Collections.Generic.KeyNotFoundException exc)
            {
                Console.WriteLine("Неверный ввод");
            }
            return retVal;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter c = new Converter();
            Console.Write("Enter romanian number: ");
            Console.WriteLine(c.Convert(Console.ReadLine()));
            Console.ReadKey();

        }
    }
}
