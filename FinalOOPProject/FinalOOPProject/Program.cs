using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOPProject
{
    class Program
    {
        static void Main(string[] args)
        {
            class Movie
        {
            string category;
            string title;
            string rating;
        }
        List<Movies> myMovieList = new List<Movies>();

        Movie horror1 = new Movie;
        horror1.category = "Horror";
        horror1.title = "Ghosts of War";
        horror1.rating = "R";
        myMovieList.add(horror1);


        

        }

        
    }
}
