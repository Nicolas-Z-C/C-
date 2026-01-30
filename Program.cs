namespace C_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classes
            //Se crea una instancia de la clase que ya creamos anteriormente
            /* 
            Se genera un error por el constructor, pues este toma parametros que no son opcinales y no se los estoy pasando
            Classe1 clase1 = new Classe1();

            Manipulando los objetos

            clase1.titulo = "Clase de biologia";
            clase1.estudiantes = 45;
            clase1.nombre = "Clase01";
            Asi tenemos un sistema de claves:valor parecido a un diccionario
            */
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
              evitan errores y asi mismo fallas de seguridad*/
            Movie pelicula1 = new Movie("Avengers","Jhon","High");
            Movie pelicula2 = new Movie("Cenicienta","Kafka","Low");
            
        }
    }
}
