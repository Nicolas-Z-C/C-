
namespace C_course
{
    //SuperClase
    class Chef
    {
        public static void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public static void MakeMeat()
        {
            Console.WriteLine("The chef makes meat");
        }
        public virtual void MakeRice()
        {
            Console.WriteLine("The chef makes rice");
        }
    }
}