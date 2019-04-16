using System;

namespace diggersAndFlyers
{
    public class Parakeet : IFly
    {
        public string Name { get; set; }
        public string Color { get; set; }


        public void fly()
        {
            Console.WriteLine("I fly");
        }
        public override string ToString()
        {
            return "Parakeet";
        }
    }
}