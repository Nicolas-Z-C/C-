using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.EF.Relationships.N-N
{
    public class hijito
    {
        public IEnumerable<padresito> padresitos {get;set;} = new List<padresito>();
    }
}