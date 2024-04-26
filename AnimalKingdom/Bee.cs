using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
   public class Bee : Animal , ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "BZZZZZZ";
        }
        public int NumberOfWings{get;} = 2;

    }
}
