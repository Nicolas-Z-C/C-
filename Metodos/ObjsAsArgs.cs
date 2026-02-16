using System.Runtime.CompilerServices;

namespace C_course
{
    abstract class Vehicule2
    {
        public void go()
        {
            Console.WriteLine("The vehicule is moving");
        }
    }
    class Car2 : Vehicule
    {
        public string color = "none";
        public int tyres = 4;

        public Car2(string acolor = "none")
        {
            Console.WriteLine($"A car is on the road and it haves {tyres} wheels");
        }

        //Aca pasamos un objeto como un argumento para nuestro metodo
        public static void changecolor(Car2 car, string color)
        {
            Console.WriteLine($"The car is now {color}");
        }

        //Usando para resultar un objeto
        public static Car2 copy(Car2 car)
        {
            return new Car2(car.color);
        }
    }
}