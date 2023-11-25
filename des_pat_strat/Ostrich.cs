using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace des_pat_strat
{
    internal class Ostrich : NonFlyingBird
    {
        public Ostrich() : base(new NonFlyStrat()) { }

        public void HideHead()
        {
            Console.WriteLine("Hides head in the sand.");
        }
    }
}
