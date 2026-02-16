namespace C_course
{
    class Paramss
    {
        static double suma(params double[] numbers)
        {
            double total = 0;
            foreach(double n in numbers)
            {
                total = total + n;
            }
            return total;
        }
    }
}