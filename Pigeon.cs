using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];

            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg((Randomizer.Next(1, 3) + Randomizer.NextDouble()), "white");
            }
            return eggs;
        }
    }
}
