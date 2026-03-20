using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.EF.Relationships.N-N
{
    public class padresito
    {
        public IEnumerable<hijito> hijitos {get;set;} = new List<hijito>();
    }
}