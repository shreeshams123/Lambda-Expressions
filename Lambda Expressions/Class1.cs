using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lambda_Expressions
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Func<string, string> str = a => new string(a.Reverse().ToArray());
            Console.WriteLine(str("hello"));
        }
    }
}
