using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOPProject
{
    class Movie
    {
        public string category;
        public string title;
        public string rating;
    }
    class Program
    {
        static List<Movie> myMovieList = new List<Movie>();
        static void Main(string[] args)
        {
        Movie horror1 = new Movie();
        horror1.category = "Horror";
        horror1.title = "Ghosts of War";
        horror1.rating = "R";
        myMovieList.Add(horror1);

        Movie horror2 = new Movie();
        horror2.category = "Horror";
        horror2.title = "1922";
        horror2.rating = "R";
        myMovieList.Add(horror2);

        Movie horror3 = new Movie();
        horror3.category = "Horror";
        horror3.title = "Knock Knock";
        horror3.rating = "R";
        myMovieList.Add(horror3);

        Movie horror4 = new Movie();
        horror4.category = "Horror";
        horror4.title = "Devil's Gate";
        horror4.rating = "R";
        myMovieList.Add(horror4);

        Movie horror5 = new Movie();
        horror5.category = "Horror";
        horror5.title = "The Platform";
        horror5.rating = "R";
        myMovieList.Add(horror5);

        Movie comedy1 = new Movie();
        comedy1.category = "Comedy";
        comedy1.title = "Guest House";
        comedy1.rating = "R";
        myMovieList.Add(comedy1);

        Movie comedy2 = new Movie();
        comedy2.category = "Comedy";
        comedy2.title = "The Wrong Missy";
        comedy2.rating = "R";
        myMovieList.Add(comedy2);

        Movie comedy3 = new Movie();
        comedy3.category = "Comedy";
        comedy3.title = "Father of the Year";
        comedy3.rating = "R";
        myMovieList.Add(comedy3);

        Movie comedy4 = new Movie();
        comedy4.category = "Comedy";
        comedy4.title = "Ridiculous 6";
        comedy4.rating = "TV-14";
        myMovieList.Add(comedy4);

        Movie comedy5 = new Movie();
        comedy5.category = "Comedy";
        comedy5.title = "Hubie Halloween";
        comedy5.rating = "PG-13";
        myMovieList.Add(comedy5);

        Movie action1 = new Movie();
        action1.category = "Action";
        action1.title = "Extraction";
        action1.rating = "R";
        myMovieList.Add(action1);

        Movie action2 = new Movie();
        action2.category = "Action";
        action2.title = "The Outpost";
        action2.rating = "R";
        myMovieList.Add(action2);

        Movie action3 = new Movie();
        action3.category = "Action";
        action3.title = "The Old Guard";
        action3.rating = "R";
        myMovieList.Add(action3);

        Movie action4 = new Movie();
        action4.category = "Action";
        action4.title = "Olympus Has Fallen";
        action4.rating = "R";
        myMovieList.Add(action4);

        Movie action5 = new Movie();
        action5.category = "Action";
        action5.title = "Django Unchained";
        action5.rating = "R";
        myMovieList.Add(action5);

        Movie mystery1 = new Movie();
        mystery1.category = "Mystery";
        mystery1.title = "It Comes At Night";
        mystery1.rating = "R";
        myMovieList.Add(mystery1);

        Movie mystery2 = new Movie();
        mystery2.category = "Mystery";
        mystery2.title = "Freaks";
        mystery2.rating = "R";
        myMovieList.Add(mystery2);

        Movie mystery3 = new Movie();
        mystery3.category = "Mystery";
        mystery3.title = "The Ritual";
        mystery3.rating = "R";
        myMovieList.Add(mystery3);

        Movie mystery4 = new Movie();
        mystery4.category = "Mystery";
        mystery4.title = "Cam";
        mystery4.rating = "R";
        myMovieList.Add(mystery4);

        Movie mystery5 = new Movie();
        mystery5.category = "Mystery";
        mystery5.title = "The Discovery";
        mystery5.rating = "R";
        myMovieList.Add(mystery5);
            //User Menu: Pick any random movie, Pick a genre and then a random movie, save movies to a 
            //text file, add and save movies to a list
            Boolean showMenu = true;
            while (showMenu)
            {
                Console.WriteLine("Random Movie Picker");
                Console.WriteLine("1. Pick a random movie");
                Console.WriteLine("2. Pick a genre and then a random movie");
                Console.WriteLine("3. Save the movies");
                Console.WriteLine("4. Add a movie to the list");
                Console.WriteLine("Press any other key to exit program");
                string userinput = Console.ReadLine();
                int userinputnumber = 0;
                try
                {
                userinputnumber = int.Parse(userinput);
                } catch (Exception ex)
                {
                    userinputnumber = 0;
                }
               
                if (userinputnumber > 0)
                {
                    switch (userinputnumber)
                    {
                        case 1:
                            Console.WriteLine("Random movie selected");
                            Random R = new Random();
                            int randommovienumber = R.Next(myMovieList.Count);
                            Movie randommoviepicked = myMovieList[randommovienumber];
                            Console.WriteLine("Random movie picked");
                            Console.WriteLine(randommoviepicked.title);
                            break;
                        case 2: Console.WriteLine("Genre and random movie selected");
                            break;
                        case 3:
                            Console.WriteLine("Save to disk selected");
                            savetodisk();
                            break;
                        case 4:
                            Console.WriteLine("Adding a movie selected");
                            break;
                        default:
                            Console.WriteLine("Exiting Program");
                            showMenu = false;
                            break;

                    }
                } else
                {
                    showMenu = false;
                }

            }
        }
        public static void savetodisk()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filename = "Movies.txt";
            String fullFilePath = System.IO.Path.Combine(currentDirectory, filename);
            System.IO.StreamWriter outputFile;
            if (File.Exists(fullFilePath))
            {
                File.Delete(fullFilePath);
            }
            using (outputFile = new StreamWriter(fullFilePath, true))
            {
             foreach (Movie aMovie in myMovieList)
            {
                outputFile.WriteLine(aMovie.title);
                Console.WriteLine(aMovie.title);
                outputFile.WriteLine(aMovie.category);
                outputFile.WriteLine(aMovie.rating);
            }
            }
          
          
            Console.WriteLine("File saved to" + fullFilePath);

        }

    }
}
