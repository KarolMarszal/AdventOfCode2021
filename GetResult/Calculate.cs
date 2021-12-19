using System;
using System.Collections.Generic;

namespace GetResult
{
    public abstract class Calculate
    {
        static void Main(string[] args)
        {
        }
        public abstract int GetFirstAnswer(List<string> list);
        public abstract int GetSecondAnswer(List<string> list);

    }
}
