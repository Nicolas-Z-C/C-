using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.EF.Relationships.1-1
{
    public class ijo
    {
        public int papaID {get;set;}
        required public Papa papa {get;set;}
    }
}