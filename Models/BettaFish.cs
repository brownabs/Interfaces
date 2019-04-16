using System;

namespace diggersAndFlyers
{
    public class BettaFish : ISwim
    {
        public string Name { get; set; }
        public string Color { get; set; }

          public void swim()
        {
            Console.WriteLine("I swim");
        }

        public override string ToString()
        {
            return "BettaFish";
        }
    }
}