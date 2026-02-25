using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.Advancedshit.Events
{
    public class Boton
{
    public event EventHandler Click;  // Declara el evento
    
    public void SimularClick()
    {
        Click?.Invoke(this, EventArgs.Empty);  // Levanta el evento
    }
}

}