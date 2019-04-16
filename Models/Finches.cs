using System;

namespace diggersAndFlyers
{
    public class Finches : IFly
    {
        public string Name { get; set; }
        public string Color { get; set; }

          public void fly()
        {
            Console.WriteLine("I fly");
        }

        public override string ToString()
        {
            return "Finches";
        }
    }
}