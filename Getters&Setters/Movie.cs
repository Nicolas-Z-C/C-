using System.Linq.Expressions;

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
            //rating = arating; version no segura
            /*
            Con este cambio tenemos una version de nuestro objeto completamente seguray libre de posibles errores de usuario
            esto nos permite facilitar el mantenimiento y evitar posibles errores en el futuro con inputs no soportados
            */
            Rating = arating;
        }
        public string Rating
        {
            get { return rating; } //Nos permite acceder a rating a pesar de que sea privado
            set
            {
                string[] ratings = {"alto","medio","bajo"};
                if (Array.Exists(ratings, E => E == value))
                {
                    rating = value;
                }
                else
                {
                    rating = "bajo";
                }
            }
        }

    }
}