using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanagawa.Data
{
    /// <summary>
    /// A class that can equate to another, using randomly generated IDs.
    /// </summary>
    public abstract class Equatable : IEquatable<Equatable>
    {
        static Random rand = new Random(Environment.TickCount);
        public int ID { get; private set; }

        //Constructor to initialize ID.
        public Equatable()
        {
            ID = rand.Next();
        }

        public bool Equals(Equatable other)
        {
            return other.ID == ID;
        }
    }
}
