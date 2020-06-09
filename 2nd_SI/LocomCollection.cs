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
        Locomotive[] locoms;

        public LocomCollection(Locomotive[] locoms)
        {
            this.locoms = locoms;
        }

        sbyte position = -1;

     

        public LocomEnum GetEnumerator()
        {
            return new LocomEnum(locoms);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
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

       

        public Locomotive Current
        {
            get
            {
                try
                {
                    return locoms[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
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

        public override string ToString()
        {
            return Name;
        }
    }
}
