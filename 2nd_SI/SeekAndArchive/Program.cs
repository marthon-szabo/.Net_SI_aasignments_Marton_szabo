using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SeekAndArchive
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = args[1];
            string file = args[0];

            Console.WriteLine(RecursiveSearch(destination, file));
            
        }

        static string RecursiveSearch(string directory, string file)
        {
            DirectoryInfo di = new DirectoryInfo(directory);

            if (di.Exists)
            {
                Console.WriteLine($"The path {directory} exists!");

                FileInfo[] fileInfoes = di.GetFiles();


                foreach (FileInfo fileInfo in fileInfoes)
                {
                    if (Path.GetFileName(fileInfo.FullName) == file)
                    {
                        return fileInfo.FullName;
                    }
                    else
                    {
                        return $"There's no file here with the name: {file}";
                    }
                    
                }
            }
            else
            {
                return $"The following directory: {directory} does not exist!";
            }
            return $"The following directory: {directory} does not exist!";
        }
    }
}
