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
                if (Bird.Randomizer.Next(4)==0)
                {
                    eggs[i] = new BrokenEgg(0,"white");
                }
                else
                {
                    eggs[i] = new Egg((Randomizer.Next(1, 3) + Randomizer.NextDouble()), "white");
                }
            }
            return eggs;
        }
    }
}
