using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace des_pat_strat
{
    internal class Canary : NonFlyingBird
    {
        public Canary() : base(new SwimStrat()) { }

        public void FloatInWater()
        {
            Console.WriteLine("Floats in water.");
        }
    }
}