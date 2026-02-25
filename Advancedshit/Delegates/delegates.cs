using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.Advancedshit.Delegates
{
    //ejemplo simple
    public class Delegates
    {
        public delegate int BinaryOp(int x, int y); //apuntara a todo lo que tome dos parametros de este tipo
    }
    public class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
    } 
    //ejemplo realista un carro que nos dice como esta su motor
}