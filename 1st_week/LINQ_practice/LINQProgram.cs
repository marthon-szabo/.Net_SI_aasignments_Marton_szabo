using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_practice
{
    class LINQProgram
    {
        static void Main(string[] args)
        {
            var startingDeck = from k in Suits()
                               from z in Ranks()
                               select new { Kartya = k, Rang = z };

            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
        }
            static IEnumerable<string> Suits()
            {
                yield return "clubs";
                yield return "diamonds";
                yield return "hearts";
                yield return "spades";
            }

            static IEnumerable<string> Ranks()
            {
                yield return "two";
                yield return "three";
                yield return "four";
                yield return "five";
                yield return "six";
                yield return "seven";
                yield return "eight";
                yield return "nine";
                yield return "ten";
                yield return "jack";
                yield return "queen";
                yield return "king";
                yield return "ace";
            }
    }
}
