using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.EF.Relationships.1-N
{
    public class Padre
    {
        public int ID {get;set;}
        //Se hace referencia a la relacion 1-N
        public IEnumerable<Hijo> hijos {get;set;} = new List<Hijo>();
    }
}