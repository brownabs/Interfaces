using System;

namespace diggersAndFlyers
{
    public class Copperhead : ISlither
    {
        public string Name { get; set; }
        public string Color { get; set; }

          public void slither()
        {
            Console.WriteLine("I dig");
        }

        public override string ToString()
        {
            return "Copperhead";
        }
    }
}