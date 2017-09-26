using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* What data types we talked about so far ?
               Int - It is a whole number with no decimals.
               String - Collection of characters.
               Char - Character is a single character.Char's are in '' single quotes. They are also case sensitive.
            */

            char firstInitial = 'D';
            // Characters or chars are single letters, numbers or symbols. Their value is set using a single quote.

            bool isTired = true;
            // It is a value that is True or false. It's default value is true.
            // Other number data types.
            float number = 2.16444123232763781313123213f;
            // Float types need to have an f at the end, this way it knows that it's a float.
            // 32 bit limit.
            decimal partialNumber = 2.16444123232763781313123213m;
            // Decimal needs to have an m at the end of the value. 
            // 128 bit limit.
            double someNumber = 2.16444123232763781313123213;
            // 64 bit limit. With double it technically doesn't need a D at the end but you can add it.
            Console.WriteLine(number);
            Console.WriteLine(partialNumber);
            Console.WriteLine(someNumber);
            /*
              Float - 32 bit (7 digits)
              Double - 64 bit (15-16 digits)
              Decimal - 128 bit (28-29 significant digits) 
            */



        }
    }
}
