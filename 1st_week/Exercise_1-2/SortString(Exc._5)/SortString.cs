using System;
using System.Linq;

namespace SortString_Exc._5_
{
    internal class SortString
    {
        public static void Main(string[] args)
        {
            string str = "First try, but not last.";
            string[] words = str.Split(" ");
            Array.Sort(words);
            words.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            string s = string.Join(" ", words);
            Console.WriteLine(s);
        }
    }
}
