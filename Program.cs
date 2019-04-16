using System;

namespace diggersAndFlyers
{
    class Program
    {
        static void Main(string[] args)
        {
                       //created the flower shop
            CleaningContainers RodentContainer = new CleaningContainers();

             CleaningContainers SnakeContainer = new CleaningContainers();

            //flower is a lambda
            RodentContainer.MakeRodentContainer()
            .ForEach(rodent => Console.WriteLine(rodent));

             SnakeContainer.MakeSnakeContainer()
            .ForEach(snake => Console.WriteLine(snake));
        }
    }
}
