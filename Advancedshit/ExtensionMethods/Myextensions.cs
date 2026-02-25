using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.Advancedshit.ExtensionMethods
{
    public static class Myextensions
    {
    /*
    Tema bastante interesante, creamos un metodo que extiende las capacidades de la clase, osea
    puede ser usado por cualquier tipo, lo que logra que el mantenimiento sea muchisimo menor, NOTA: SIEMPRE USARLOS Y RECORDAR
    QUE LO QUE EXTIENDAD TODO LO QUE EXTIENDAN TIENE ACCESO A ELLOS.
    */

    public static int ReverseDigits(this int i)
        {
            char[] digits = i.ToString().ToCharArray();

            Array.Reverse(digits);

            string NewDigits = new string(digits);

            return int.Parse(NewDigits);
        }
    }
}