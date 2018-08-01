using EF6DatafirstGenricRepositoryPattern.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6DatafirstGenricRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var ctx = new SchoolContextModel())
            {
                foreach(var studient in ctx.Studient)
                {
                    Console.WriteLine($"Studient name: {studient.StudientName}");
                }
            }

            Console.ReadKey();
        }
    }
}
