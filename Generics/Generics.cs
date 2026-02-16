namespace C_course
{
    class Generics{
        //Tenemos un metodo que sirve para todos los tipos de datos
        public static void displayElements<Nigga>(Nigga[] Array)
        {
            foreach (Nigga item in Array)
            {
                Console.WriteLine(item);
            }
        }
    }
}