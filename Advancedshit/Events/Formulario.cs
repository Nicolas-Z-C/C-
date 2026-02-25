using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.Advancedshit.Events
{
    public class Formulario
    {
        public Formulario()
        {
            Boton btn = new Boton();
            btn.Click += Btn_Click;  // Suscribir método
        }
        
        private void Btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("¡Botón clickeado!");
        }
    }

}