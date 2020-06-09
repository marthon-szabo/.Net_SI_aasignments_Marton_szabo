using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Transactions;

namespace _2nd_SI
{
    class LocomCollection : System.Collections.IEnumerable
    {
        Locomotive[] locoms = new Locomotive[] { new Locomotive("V43"), new Locomotive("V63") };

        public LocomCollection(Locomotive[] locoms)
        {
            this.locoms = locoms;
        }

        sbyte position = -1;

     

        public IEnumerator GetEnumerator()
        {
        }
    }

    internal class LocomEnum : IEnumerator
    {
        Locomotive[] locoms;
        sbyte position = -1;

        public LocomEnum(Locomotive[] locoms)
        {
            this.locoms = locoms;
        }

        public object Current
        {
            get
            {
                return Current;
            }
        }



        public bool MoveNext()
        {
            position++;
            return (position < locoms.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }

    internal class Locomotive
    {
        public string Name { get; }

        public Locomotive(string name)
        {
            Name = name;
        }
    }
}
