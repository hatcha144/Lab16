using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    
    class CountriesTextFile
    {

       StreamReader reader;
        string path;
        public CountriesTextFile(string Path)
        {
            path = Path;
        }

        public void Read()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (reader = new StreamReader(path))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }

        StreamWriter writer;

        public void Write()
        {
            Console.WriteLine("What country would you like to add?");
            string userInput = Console.ReadLine();
            Console.WriteLine("******************************");

            using (writer = new StreamWriter(path))
            {
                writer.WriteLine("United States");
                writer.WriteLine("Canada");
                writer.WriteLine("Mexico");
                writer.WriteLine("China");
                writer.WriteLine(userInput);
               
                writer.Close();
            }

        }



    }






}
