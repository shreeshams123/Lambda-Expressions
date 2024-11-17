using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;

namespace Lambda_Expressions
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() { new Student(1, "Alex", 10), new Student(2, "Madam", 20), new Student(3, "Mary", 20) };
            var stud = students.OrderByDescending(s => s.Age);
            foreach(var student in stud)
            {
                Console.WriteLine(student.Name);
            }
            var stud2 = students.FindAll(a => a.Name.StartsWith('A'));
            foreach (var student in stud2)
            {
                Console.WriteLine(student.Name);
            }
            var stud3 = students.GroupBy(a => a.Age).Select(group => new { Age = group.Key, Count = group.Count() });
            foreach (var group in stud3)
            {
                
                    Console.WriteLine(group.Age+" "+group.Count);
                
            }
            var stud4 = students.FindAll(s =>s.Name.Equals(new string(s.Name.Reverse().ToArray()),StringComparison.OrdinalIgnoreCase));
            foreach (var student in stud4)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}