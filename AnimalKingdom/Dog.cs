﻿namespace AnimalKingdom
{
    public class Dog : Animal , IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
