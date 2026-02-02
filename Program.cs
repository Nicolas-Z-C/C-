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
            */

            //static methods and classes

            //Console.WriteLine(Math.Min(1,8)); //El metodo min es un metodo estatico que puede ser llamado desde la clase Math, sin nececitar un objeto como intermediario

            //Inheritance 

            Chef chef1 = new Chef();
            ItalianChef chef = new ItalianChef();

            chef1.MakeRice();
            chef.MakeRice();

        }
    }
}
