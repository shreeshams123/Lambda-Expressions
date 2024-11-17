using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Lambda_Expressions
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 1, 4, 2, 7, 8, 4, 7, 3 };
            var listnew = l1.FindAll(x => x % 2 != 0);
            foreach (var item in listnew) {
                Console.WriteLine(item);
            }
            Func<List<int>, List<int>> listarr = (List<int> a) => a.FindAll(x => x % 2 != 0);
            var newlist = listarr(l1);
            foreach (var x in newlist)
            {
                Console.WriteLine(x);
            }
            var listsqr = l1.Select(x => x * x).ToList();
            foreach (var x in listsqr)
            {
                Console.WriteLine(x);
            }
            Func<List<int>, int> listadd = (List<int> a) =>
            {
                int total = 0;
                foreach (var item in a)
                {
                    total = total + item;
                }
                return total;
            };
            
            List<string> l2 = new List<string>() { "Alex", "Bob" };
                Func<List<string>, List<string>> liststr = (List<string> b) => b.Select(x => x.ToUpper()).ToList();

                List<string> newlist2 = liststr(l2);

                foreach (var x in newlist2)
                {
                    Console.WriteLine(x);
                }
            }} } 
    

