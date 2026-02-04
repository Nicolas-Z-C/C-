namespace C_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Classes
            //Se crea una instancia de la clase que ya creamos anteriormente
             
            Se genera un error por el constructor, pues este toma parametros que no son opcinales y no se los estoy pasando
            Classe1 clase1 = new Classe1();

            Manipulando los objetos

            clase1.titulo = "Clase de biologia";
            clase1.estudiantes = 45;
            clase1.nombre = "Clase01";
            Asi tenemos un sistema de claves:valor parecido a un diccionario
            
            Classe1 clase2 = new Classe1("Clase de biologia");
            clase2.titulo = "Titulo2";
            //Constructor overload
            Classe1 clase3 = new Classe1("Biologia","Biologia1",45);

            //Object methods

            Clase2 clase1 = new Clase2("Johlver",15,"Biologia",2,5);

            //Uso del metodo

            string tamaño = clase1.Size();
            
            Console.WriteLine($"Nombre clase: {clase1.nombre}\nEstudiantes: {clase1.estudiantes}\nProfesor: {clase1.profesor}\nTemas: {clase1.temas}\nSalon: {clase1.salon}");
            Console.WriteLine($"El tamaño de esta clase es {tamaño}");
            

            //Getters & Setters
            /*Son escencialmente medidas de seguridad para nuestras clases
              evitan errores y asi mismo fallas de seguridad
            Movie pelicula1 = new Movie("Avengers","Jhon","FF"); //Se auto convertira a bajo
            Movie pelicula2 = new Movie("Cenicienta","Kafka","alto");

            Console.WriteLine(pelicula1.Rating);
            Console.WriteLine(pelicula2.Rating);
           

            //static class atributes

            Song song1 = new Song("Title","Me",15);
            Console.WriteLine(Song.songcount);
            Song song2 = new Song("Title2", "Me2", 10);
            Console.WriteLine(Song.songcount);
            song2.getsSongCount();
            

            //static methods and classes

            //Console.WriteLine(Math.Min(1,8)); //El metodo min es un metodo estatico que puede ser llamado desde la clase Math, sin nececitar un objeto como intermediario

            //Inheritance 

            Chef chef1 = new Chef();
            ItalianChef chef = new ItalianChef();

            chef1.MakeRice();
            chef.MakeRice();
            

            //Abstract keyword

            Plane plan1 = new Plane();
            Car car1 = new Car();
            //error pues se tiene abstract
            //Vehicule vehicule1 = new Vehicule();
            

            //Arrays of objects

            //Se crea el array de objetos, este solo puede contener objetos de la clase designada
            Kart[] garage = new Kart[5];

            Kart kart1 = new Kart("Red");
            Kart kart2 = new Kart("Blue");
            Kart kart3 = new Kart("Grey");

            foreach(Kart kart in garage)
            {
                Console.WriteLine(kart.color);
            }

            //Creacion con objetos anonimos

            Kart [] karts = { new Kart("Red"), new Kart("Blue"), new Kart("Grey"),};
            


            //Objects as arguments

            Car2 Carrito = new Car2();

            Console.WriteLine(Carrito.color);

            Car2.changecolor(Carrito, "Red");

            Console.WriteLine(Carrito.color);

            Car2 car2 = Car2.copy(Carrito);

            

            //ToString

            //Nos sirve para poder mostrar algo diferente a la hora de usar el metodo por medio de el sebreescribir su codio original.

            Tostring papaya = new Tostring("Chevy","2007",2005,"Red");
            Console.WriteLine(papaya.ToString());
            Console.WriteLine(papaya);
            */

            //Polymorphism
            //Tener muchas formas y tipos de datos 

            Carrito carrito1 = new Carrito();
            Motico motico = new Motico();
            Avioncito avioncito = new Avioncito(); 

            //Si quisieramos crear un array con nuestros objetos tendriamos que usar la clase padre o la que tengan en comun nuestros objetos
            //En este caso seria Vehicules 

            Carrito [] garaje = new Carrito[10];

            //garaje[1] = motico; //Nos da un error pues no se puede insertar un tipo en otro

            Vehicules [] garage = {motico, carrito1,avioncito}; //Gracias al poly se puede lograr esto

            foreach(Vehicules vehicules in garage)
            {
                //Solo funciona si nuestra clase padre tiene el metodo que se esta llamando, pero al poder ser sobreescrito actuara segun lo que este en su sub clase
                vehicules.go();
            }

            //Asi mismo podemos crear objetos de carro y tratarlos como vehiculos

            Vehicules carrito2 = new Carrito(); //Valido gracias a la herencia y poli
        }
    }
}
