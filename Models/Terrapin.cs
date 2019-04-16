using System;

namespace diggersAndFlyers
{
    public class Terrapin : IDig
    {
        public string Name { get; set; }
        public string Color { get; set; }
          public void dig()
        {
            Console.WriteLine("I dig");
        }

        public override string ToString()
        {
            return "Terrapin";
        }
    }
}