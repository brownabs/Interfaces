using System;

namespace diggersAndFlyers
{
    public class Earthworm : IDig, ISlither
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public void dig()
        {
            Console.WriteLine("I dig");
        }
        public void slither()
        {
            Console.WriteLine("I slither");
        }

        public override string ToString()
        {
            return "Earthworm";
        }
    }
}