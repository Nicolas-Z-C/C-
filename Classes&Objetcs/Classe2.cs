namespace C_course
{
    class Clase2
    {
        public string profesor;
        public int estudiantes;
        public string nombre;
        public int salon;
        public int temas;

        public Clase2(string aprofesor, int astudiantes, string amateria,int asalon, int atemas)
        {
          profesor = aprofesor;
          estudiantes = astudiantes;
          nombre = amateria;
          salon = asalon;
          temas = atemas; 
        }
        //Object methods
        /*En este caso vamos a crear un metodo accesible para los objetos que creemos
          en este caso crearemos uno que nos categorizara nuestra clase segun el tamaño de esta*/
        public string Size()
        {
            switch(estudiantes)
            {
                case int t when t >= 15:
                    return "Grande";
                    break;
                case int t when t < 15:
                    return "Pequeño";
                    break;
                default:
                    return "No definido";
                    break;
            }        
        } 
    }
}