using System;
using System.Collections.Generic;

namespace LastNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inital = new List<string>() { "Иванов", "Петров", "Сидоров" };
            LastNames lname = new LastNames(inital);
            Console.Write("Enter search query: ");
            Console.WriteLine(lname.ProcessLastName(Console.ReadLine()));
        }
    }
}