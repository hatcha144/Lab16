using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Validator
    {
        public Validator()
        {

        }
        public bool inRange(int check , int max, int min)
        {
            if (check > min && check < max)
            {
                return true;
            }
            else
            {
                return false; 
            }
        } 
        public int numCheck(string input)
        {
            try
            {
              return int.Parse(input);
            }
            catch
            {
                Console.WriteLine("That is not a valid input");
            }
            return 0;
  
        
        }
    }
}

