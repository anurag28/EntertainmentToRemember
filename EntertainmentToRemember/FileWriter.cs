using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EntertainmentToRemember
{
    public class FileWriter
    {
        string rootFolder = @"TextFiles\Movies\";
        public void WriteToMoviesFiles(string name, string cast, string genre, string rating)
        {
            string fileName = genre+".txt";
            string details = name + ":" + cast + ":" + genre + ":" + rating;
            File.AppendAllLines(rootFolder + fileName, new[] { details});
        }
    }
}
