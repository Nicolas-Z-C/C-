
namespace C_course
{
    //SubClase
    class ItalianChef : Chef // con : se denota la herencia, solo se puede heredar de una clase a la vez 
    {
        public override void MakeRice()
        {
            Console.WriteLine("The chef makes a sashimi style rice");
        }
    }
}