using GetResult;
using System;
using System.Collections.Generic;

namespace Day2
{
    public class Day2class : Calculate
    {
        static void Main(string[] args)
        {
        }

        public override int GetFirstAnswer(List<string> list)
        {
            var horizontal = 0;
            var depth = 0;
            foreach (var s in list)
            {
                if (s.StartsWith("forward"))
                    horizontal += GetValue(s);
                if (s.StartsWith("down"))
                    depth += GetValue(s);
                if (s.StartsWith("up"))
                    depth -= GetValue(s);
            }
            return horizontal * depth;
        }

        public override int GetSecondAnswer(List<string> list)
        {
            var horizontal = 0;
            var depth = 0;
            var aim = 0;
            foreach (var s in list)
            {
                if (s.StartsWith("forward"))
                {
                    horizontal += GetValue(s);
                    depth += aim * GetValue(s);
                }
                if (s.StartsWith("down"))
                    aim += GetValue(s);
                if (s.StartsWith("up"))
                    aim -= GetValue(s);
            }
            return horizontal * depth;
        }
        private int GetValue(string s)
        {
            return s[s.IndexOf(" ") + 1] - '0';
        }
    }
}
