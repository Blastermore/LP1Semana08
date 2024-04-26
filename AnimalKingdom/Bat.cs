using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Bat : Animal , IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Screech";
        }
    }
}
