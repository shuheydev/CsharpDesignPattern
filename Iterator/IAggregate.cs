using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IAggregate
    {
        IIterator Iterator();
    }
}
