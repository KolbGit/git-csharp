using SimpleCSharpConsoleApp;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PeopleModel p = new PeopleModel()
            {
                FirstName = "Timon",
                LastName = "Berkovec",
                Age = 18
            };

            Console.WriteLine($"{p.FirstName} {p.LastName} it't his name and his {p.Age} years");
        }
    }
}