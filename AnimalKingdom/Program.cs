using System;

namespace AnimalKingdom
{
//FAZER UML !!!!!!!!!!!!!!!
    public class Program
    {
        private static void Main()
        {
            const int n = 10;
            Animal[] animals = new Animal[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                switch (rnd.Next(4))
                {
                    case 0:
                        animals[i] = new Bat();
                        break;
                    case 1:
                        animals[i] = new Bee();
                        break;
                    case 2:
                        animals[i] = new Cat();
                        break;
                    case 3:
                        animals[i] = new Dog();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Unknown animal!");
                }
            }

            foreach (Animal a in animals)
            {
                Console.Write($"{a.GetType().Name} says ");
                Console.Write(a.Sound());
                if (a is IMammal)
                    Console.Write(
                        $", No.Nipples = {(a as IMammal).NumberOfNipples}");
                if (a is ICanFly)
                    Console.Write(
                        $", No.Wings = {(a as ICanFly).NumberOfWings}");
                Console.WriteLine();
            }

        }
    }
}
