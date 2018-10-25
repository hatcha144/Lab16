using Lab13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class CountriesApp
    {
        static string path = @"C:\Users\mfilice\source\repos\Lab16\Lab16\countries.txt";
        CountriesTextFile country = new CountriesTextFile(path);
        //constructor 
        public CountriesApp()
        {

        }
        //method 
        public void Menu()

        {
            bool cont = true;
            {
                do
                {
                    //menu options
                    Console.WriteLine("******************************");
                    Console.WriteLine("Welcome to the Countries Maintenance Application!");
                    Console.WriteLine("1- See list of countries");
                    Console.WriteLine("2- Add a country");
                    Console.WriteLine("3- Exit");
                    Console.WriteLine("******************************");
                    Validator valid = new Validator();
                    int userInput = valid.numCheck(Console.ReadLine());
                    

                    if (userInput == 1)//listing
                    {
                        country.Read();
                    }
                    else if (userInput == 2) //adding
                    {
                        country.Write();
                    }
                    else if (userInput == 3)//quiting - do while loop 
                    {
                        cont = false;
                        Console.WriteLine("Viszontlátásra!");
                        Console.ReadLine();
                    }
                } while (cont == true);
            }
        }
    }
}
