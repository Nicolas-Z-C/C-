using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.Advancedshit.Delegates
{
    public class GenericDelegates
    {
        public delegate void Mygen<T>(string param1); 

        public static void StrTarget(string a)
        {
            Console.WriteLine("{0} is the uppercase", a.ToUpper());
        }
    }
}