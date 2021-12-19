using GetResult;
using System;
using System.Collections.Generic;

namespace Day1
{
    public class Day1class : Calculate
    {
        static void Main(string[] args)
        {
        }

        public override int GetFirstAnswer(List<string> list)
        {
            var result = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (int.Parse(list[i]) > int.Parse(list[i - 1]))
                    result++;
            }
            return result;
        }

        public override int GetSecondAnswer(List<string> list)
        {
            var result = 0;
            for (int i = 0; i < list.Count - 3; i++)
            {
                if ((int.Parse(list[i]) + int.Parse(list[i + 1]) + int.Parse(list[i + 2])) < (int.Parse(list[i + 1]) + int.Parse(list[i + 2]) + int.Parse(list[i + 3])))
                    result++;
            }
            return result;
        }
    }

}
