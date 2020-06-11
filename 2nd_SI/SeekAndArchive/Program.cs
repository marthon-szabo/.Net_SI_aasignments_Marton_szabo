using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                FileInfo[] fileInfoes = di.GetFiles();


                foreach (FileInfo fileInfo in fileInfoes)
                {
                    if (file.Contains(Path.GetFileName(fileInfo.FullName)))
                    {
                        return $"The full path of the file: {fileInfo.FullName}";
                    }
                    

                }
                 if (di.GetDirectories().Length >= 1)
                {
                    List<DirectoryInfo> subDirectories = di.GetDirectories().ToList<DirectoryInfo>();
                    //subDirectories.ForEach(subDir => RecursiveSearch(subDir.Name, file));
                    string result;
                    foreach (DirectoryInfo subDir in subDirectories)
                    {
                        result = RecursiveSearch(subDir.FullName, file);
                        if (result != null)
                        {
                            return result;
                        }
                    }
                }
            }
            return null;
        }
        
    }
}
