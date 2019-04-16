using System;
using System.Collections.Generic;

namespace diggersAndFlyers
{
    public interface IFly
    {

        string Name { get; set; }
        string Color { get; set; }
        void fly();

    }
}