using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.Advancedshit.Anonmethods
{
    public class Anonmeth
    {
        public static bool MuertoChef  {get; set;} = false;

        public Anonmeth(bool muerto = false)
        {
            MuertoChef = muerto;
        }
        public delegate void Chef(string a);
        public static event Chef ? Chefmuerto; 

        public void Chefcocinando(int veces)
        {
            if (MuertoChef)
            {
                Chefmuerto?.Invoke("El chef esta muerto no puede cocinar");
            }
            else
            {
                if (veces > 10)
                {
                    MuertoChef = true;
                    Chefmuerto?.Invoke("El chef trabajo mucho y se murio"); 
                }
                else
                {
                    Console.WriteLine("El chef esta cocicnando {0} veces", veces);
                }
            }
        }
    }
}