using System;
using System.Collections.Generic;

namespace diggersAndFlyers
{  
    public interface IDig {

    
     string Name { get; set; }
     string Color { get; set; }
     void dig ();

    }
}