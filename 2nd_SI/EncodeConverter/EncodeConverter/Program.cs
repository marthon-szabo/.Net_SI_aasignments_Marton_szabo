using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter
                (File.Open
                (@"C:\Users\DELL\.Net_SI_aasignments_Marton_szabo\2nd_SI\EncodeConverter\gitignore_utf7.txt",
                FileMode.Create), Encoding.UTF7);
            StreamReader reader = new StreamReader(@"C:\Users\DELL\.Net_SI_aasignments_Marton_szabo\.gitignore");
            WriteText(ReadText(reader), writer);
        }

        private static StringBuilder ReadText(StreamReader reader)
        {
            StringBuilder sb = new StringBuilder();
            String line;
            while ((line = reader.ReadLine()) != null)
            {
                sb.Append(line + "\n");
            }
            return sb;
        }

        private static void WriteText(StringBuilder sb, StreamWriter writer)
        {
            foreach (char word in sb.ToString())
            {
                if (word.ToString().Equals("\n"))
                {
                    writer.WriteLine("\n" + word);
                }
                else
                {
                    writer.Write(word);
                }
            }
        }
    }
}
