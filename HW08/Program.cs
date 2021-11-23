using System;
using System.Collections;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "B", "B", "B", "B", "A", "A", "A", "A", "A", "A", "B" };
            ArrayList newStr = new ArrayList();
            
            int count = 0;
            
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1] && i < str.Length - 2) { count++; newStr.Add(str[i]); newStr.Add(count); count = 0; }
                else if (i == str.Length - 2)
                {
                    if (str[i - 1] == str[i]) { count++; newStr.Add(str[i]); newStr.Add(count); }
                    else { newStr.Add(str[i - 1]); newStr.Add(count); newStr.Add(str[i]); newStr.Add(1); }
                }
                else { count++; }
            }

            foreach (object obj in newStr) 
            { 
                Console.Write(obj); 
            }
        }
    }
}
