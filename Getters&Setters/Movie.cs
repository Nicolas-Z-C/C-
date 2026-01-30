namespace C_course
{
    class Movie 
    {
        public string director;
        public string title;
        private string rating; //requerimos que los ratings solo puedan ser High,Medium,Low para esto cortamos el acceso general a este atributo Public => Private
        public Movie(string atitle, string adirector, string arating)
        {
            title = atitle;
            director = adirector;
            rating = arating;   
        }    
    }
}