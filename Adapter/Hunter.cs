using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Hunter
    {
        public void Hunt(ILion lion)
        {
            lion.Roar();
        }
    }
}
