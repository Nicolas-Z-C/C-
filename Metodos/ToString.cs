namespace C_course
{
    class Tostring
    {
        string make;
        string model;
        int year;
        string color;

        public Tostring(string amake, string amodel, int ayear, string acolor)
        {
            make = amake;
            model = amodel;
            year = ayear;
            color = acolor;
        }

        public override string ToString()
        {
            return "This is a"+make+ " " + model;
        }
    }
}