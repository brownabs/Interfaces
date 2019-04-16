using System;

namespace diggersAndFlyers
{
    public class RattleSnake : ISlither, IPoisonous
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public bool isPoisonous {get;} = true;

        public void slither()
        {
            Console.WriteLine("I slither");
        }
        public override string ToString()
        {
            return "RattleSnake";
        }
    }
}