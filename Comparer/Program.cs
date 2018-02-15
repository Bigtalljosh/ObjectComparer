using System;
using System.Collections.Generic;
using System.Linq;

namespace Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Person
            {
                age = 10,
                name = "bob",
                lessons = new List<Lesson>
            {
                new Lesson
                {
                    name = "compsci",
                    maxCapacity = 15
                },
                new Lesson
                {
                    name = "english",
                    maxCapacity = 30
                }
            }
            };


            var y = new Person
            {
                age = 30,
                name = "jane",
                lessons = new List<Lesson>
            {
                new Lesson
                {
                    name = "physics",
                    maxCapacity = 20
                },
                new Lesson
                {
                    name = "english",
                    maxCapacity = 30
                }
            }
            };

            var result = x.GetDiffs(y);
            var properties = result.Aggregate(string.Empty, (z, next) => $"{ z }\r\n\t{ next.Property }: { next.ValueA } | { next.ValueB }");
            Console.WriteLine($"There were { result.Count } differenes on these properties: { properties }");
            Console.ReadKey();
        }

    }
}
