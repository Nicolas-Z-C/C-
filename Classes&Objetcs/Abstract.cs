namespace C_course
{
    /*
    El uso de la palabra reservada Abstract no permite que una clase tenga instancias, lo cual es util en casos como el siguiente

    Tenemos una clase general padre llamada vehicule, de la cual salen subclases como avion y carro de las cuales podemos tener
    instancias (pues son vehiculos) pero no queremos que se pueda crear un vehiculo vacio por medio de la clase vehicule, por eso
    usamos el prefijo abstract
    */
    abstract class Vehicule
    {
        public void go()
        {
            Console.WriteLine("The vehicule is moving");
        }
    }
    class Car : Vehicule
    {
        public int tyres = 4;
        
        public Car()
        {
            Console.WriteLine($"A car is on the road and it haves {tyres} wheels");
        }
    }
    class Plane : Vehicule
    {
        public int tyres = 18;
        public Plane()
        {
            Console.WriteLine($"A plane is flying and it haves {tyres} wheels");
        }
    }
}