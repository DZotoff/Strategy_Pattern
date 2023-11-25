using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace des_pat_strat
{
    internal class Bird
    {
       
        private MoveStrat moveStrat;

        public string Name { get; set; }
        public string Color { get; set; }

        public Bird(MoveStrat strategy)
        {
            this.moveStrat = strategy;
        }

        public void SetMovetStrat(MoveStrat strategy)
        {
            this.moveStrat = strategy;
        }

        public void Move()
        {
            Console.WriteLine($"Here is the {Name}'s movement behavior: *{moveStrat.Move()}*");
        }      
    }
}
