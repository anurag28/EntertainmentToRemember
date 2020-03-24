using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EntertainmentToRemember
{
    public class FileReader
    {
        string rootFolderMovies = @"TextFiles\Movies\";

        public List<string> FetchMovieDetails(string genre, string cast)
        {
            string fileName = genre+".txt";
            List<string> moviesList = new List<string>();
            moviesList = GetListCastBasis(fileName,cast);
            return moviesList;
        }


        public List<string> FetchMovieDetails(string cast)
        {

            List<string> moviesList = new List<string>();
            string fileName;
          
                fileName = "Action.txt";
                moviesList = GetListCastBasis(fileName, cast);
            
                fileName = "Romance.txt";
                moviesList = GetListCastBasis(fileName, cast);
            
           
                fileName = "Thriller.txt";
                moviesList = GetListCastBasis(fileName, cast);
           
                fileName = "Drama.txt";
                moviesList = GetListCastBasis(fileName, cast);
                  
           
                fileName = "Comedy.txt";
                moviesList = GetListCastBasis(fileName, cast);

            return moviesList;
        }

        public List<string> FetchMovieDetailsGenre(string genre)
        {
            string fileName = genre + ".txt";
            List<string> moviesList = new List<string>();
            string[] lines = File.ReadAllLines(rootFolderMovies + fileName);
            Console.WriteLine(lines.Length);
            foreach (string line in lines)
            {
               moviesList.Add(line);
            }
            return moviesList;
        }



        public List<string> GetListCastBasis(string fileName, string cast)
        {
            List<string> moviesList = new List<string>();
            string[] lines = File.ReadAllLines(rootFolderMovies + fileName);

            foreach (string line in lines)
            {
                string[] content = line.Split(":");
                if (content[1].Contains(cast))
                {
                    moviesList.Add(line);
                }
            }
            return moviesList;
        }
    }
}
