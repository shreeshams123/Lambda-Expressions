using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expressions
{
    public delegate List<int> listdelegate(List<int> a);
    internal class Program
    {
        List<int> num = new List<int>() { 8, 10, 15, 9, 6, 20 };
        static void Main(string[] args)
        {
            Program p=new Program();
            Func<List<int>,List<int>> listsol=(List<int> number)=>number.FindAll(a => a == 8);
            List<int>result=listsol(p.num);
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
            listdelegate l = delegate (List<int> num)
            {
                return num.FindAll(a => a>10);
            };
            List<int> p1 = l(p.num);
            foreach (int i in p1)
            {
                Console.WriteLine(i.ToString());
            }


            var obj = p.num.Average(num => num);
            Console.WriteLine(obj);
            var obj2 = p.num.First(n => n % 2 == 0 && n > 10);
            Console.WriteLine(obj2);


        }
    }
}
