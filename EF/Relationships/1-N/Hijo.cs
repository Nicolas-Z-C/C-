using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.EF.Relationships.1-N
{
    public class Hijo
    {
        public int PadreId {get;set;}
        required public Padre Padre {get;set;}
    }
}