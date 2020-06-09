using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace _2nd_SI
{
    class Practice
    {
        
        static async Task Main(string[] args)
        {
            Locomotive[] locs = new Locomotive[] { new Locomotive("V43"), new Locomotive("V63") };
            LocomCollection locomCollection = new LocomCollection(locs);

            foreach (Locomotive loc  in locomCollection)
            {
                Console.WriteLine(loc);
            }
        }

        

       
        
        
    }
}
