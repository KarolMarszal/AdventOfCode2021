using System;
using Utilities;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var data = GetDataFromFile.ReadLinesFromFile("Day1");
            foreach (var s in data)
            {
                Console.WriteLine(s);
            }
        }
    }
}
