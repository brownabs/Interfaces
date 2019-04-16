using System;
using System.Collections.Generic;

namespace diggersAndFlyers
{  
    public interface ISlither {

     string Name { get; set; }
     string Color { get; set; }
     void slither ();

    }
}