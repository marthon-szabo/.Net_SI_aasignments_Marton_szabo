using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            var locomotives = from name in Names()
                              from loc in Locs()
                              where loc.Equals("V63")
                              select new { Name = "Gigant" };

            foreach (var e in locomotives)
            {
                Console.WriteLine(e);
            }
        }

        static IEnumerable<string> Locs()
        {
            yield return "V63";
            yield return "V43";
            yield return "M62";
        }

        static IEnumerable<string> Names()
        {
            yield return "Gigant";
            yield return "Szili";
            yield return "Csorgo";
        }
    }
}
