using System;
using System.Collections.Generic;
using System.Linq;

namespace IQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){ID=1,Name="Marcin",Gender="Male"},
                new Student(){ID=2,Name="Kuba",Gender="Male"},
                new Student(){ID=3,Name="Kasia",Gender="Female"},
                new Student(){ID=4,Name="Wojtek",Gender="Male"},
                new Student(){ID=5,Name="Natalia",Gender="Female"},
            };

            IQueryable<Student> MethodSyntax = studentList.AsQueryable().Where(std => std.Gender == "Male");

            foreach(var std in MethodSyntax)
            {
                Console.WriteLine($"ID: {std.ID} Name: {std.Name}");
            }

        }
    }
}
