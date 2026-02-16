namespace C_course
{
    //Declaracion de la clase en su propio archivo aparte
    class Classe1
    {
        /*Declaracion de los atributos de clase, estos actuan como las caracteristicas de lo que queremos 
          representar con nuestra clase|objeto*/
        public string nombre;
        public int estudiantes;
        public string titulo;

        //Constructores

        public Classe1(string tit, int estudiantes = 0)
        {
            titulo = tit;
            Console.WriteLine("Esto es un constructor");
        }
        //constructor overload

        public Classe1(string anombre,string atitulo, int astudiantes = 0)
        {
            nombre = anombre;
            titulo = atitulo;
            if (astudiantes == 0)
            {
                Console.WriteLine($"Esta clase es {nombre} y no tiene estudiantes");
            }
            estudiantes = astudiantes;

            Console.WriteLine($"Nombre de la clase: {nombre}\n Estudiantes:{estudiantes}");
        }
    }
}
