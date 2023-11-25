using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace des_pat_strat
{
    internal class Eagle : FlyingBird
    {
        public Eagle() : base(new FlyStrat()) { }

        public void SearchForPrey()
        {
            Console.WriteLine("Searching for prey.");
        }
    }
}
