using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.Advancedshit
{
    public class Anontypes
    {
        static void anongen(int message)
        {
        //var anon = new {123, 1.5,"hello"}; //genera error pues solo podemos crear un anon por medio de miembros o accesos simples, nunca con datos directos

        var anon1 = new {message = "hello", id = 45};
        }
    }
}