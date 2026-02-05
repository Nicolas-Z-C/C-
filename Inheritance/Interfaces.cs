namespace C_course
{
    //Las interfaces actuan como un contrato entre las clases padres e hijas, una interfaz declara lo que una clase debe tener
    //Y usus herederos declaran como se usa

    interface IPrey
    {
        void flee();
    }
    interface IPredator
    {
        void searchForPrey();
    }
    class Rabbit : IPrey
    {
        public void flee()
        {
            Console.WriteLine("The rabbit is fleeing");
        }
        public static void run()
        {
            Console.WriteLine("A rabbit is running");
        }
    }
    class Hawk : IPredator
    {
        public void searchForPrey()
        {
            Console.WriteLine("The hawk is searching for prey");
        }
    }
    class Fish : IPredator, IPrey
    {
        public void searchForPrey()
        {
            Console.WriteLine("The fish is searching for any prey");
        }
        public void flee()
        {
            Console.WriteLine("The fish is swimming away");
        }
    }
}