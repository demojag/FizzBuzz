using System;
using System.Linq;
using FizzBuzzCore;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = Enumerable.Range(1, 100);
            foreach (var i in v)
            {
                Console.WriteLine(FizzBuzz.CheckFizzBuzz(i));
            }

            Console.Read();
        }
    }
}
