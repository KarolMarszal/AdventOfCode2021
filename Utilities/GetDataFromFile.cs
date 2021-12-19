using System;
using System.Collections.Generic;
using System.IO;

namespace Utilities
{
    public class GetDataFromFile
    {
        public static List<string> ReadLinesFromFile (string day)
        {
            var path = "";
            var content = new List<string>();
            if (day.StartsWith("Day"))
                path = @"C:\Users\Karol\source\repos\AdventOfCode2021\" + day + ".txt";
            if (path != "")
                content = new List<string>(File.ReadAllLines(path));
            return content;
        }
    }
}
