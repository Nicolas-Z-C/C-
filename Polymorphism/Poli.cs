namespace C_course
{
    class Vehicules
    {
        public virtual void go()
        {
            Console.WriteLine("The vehicule is moving");
        }
    }
    class Carrito : Vehicules
    {
        public override void go()
        {
            Console.WriteLine("The carrito is moving");
        }
    }
    class Motico : Vehicules
    {
        public override void go()
        {
            Console.WriteLine("The motico is moving");
        }
    }
    class Avioncito : Vehicules
    {
        public override void go()
        {
            Console.WriteLine("The avioncito is flying");
        }
    }
}