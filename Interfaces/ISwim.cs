using System;
using System.Collections.Generic;

namespace diggersAndFlyers
{  
    public interface ISwim {

     string Name { get; set; }
     string Color { get; set; }    
     void swim ();

    }
}