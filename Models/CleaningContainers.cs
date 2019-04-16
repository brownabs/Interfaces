using System;
using System.Collections.Generic;

namespace diggersAndFlyers
{    public class CleaningContainers
    {


        public string ContainerName {get; set;}   
        //create different types of cleaning containers
        public List<IDig> MakeRodentContainer () {
            
            List<IDig> RodentContainer = new List <IDig>() {

            new Gerbil (),
            new Mice (),

            };

            return RodentContainer;
        }

           public List<ISlither> MakeSnakeContainer () {
            
            List<ISlither> SnakeContainer = new List <ISlither>() {

            new RattleSnake (),
            new Copperhead (),

            };

            return SnakeContainer;
        }





    }
}