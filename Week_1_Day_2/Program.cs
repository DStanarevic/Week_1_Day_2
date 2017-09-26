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


            //Now, let's talk about operators!

            //Arithmetic Operator
            // + adds two operands(Value in variable that is being worked with). 
            // - this operator subtracts the second operator first.
            // * Multiplies both operands. 
            // / Divides the first operand by the second one. 
            // % Modulus opperator shows the remainder of what is left over when you divide.
            // ++ Increments value by one and is used for ints primarily.
            // -- Decreases value by one each time that it's used.

            //Relational operator
            // == Checks if the two operands are equal, if it they are it returns a true and if not a false.
            // != Checks if two operands are not equal to each other and if they are not equal it returns a true.
            // > Checks the value of the left operand and if it's greater than the right operand. If yes it returns a true.
            // < Checks the value of the left operand and if it is less than the value of the right operand. If it is true, it returns a true.
            // >= Checks if value is greater or equal to and if it is it returns a true. It checks the left value first and then the right.
            // <= Checks if the value of the left operand is less than or equal to the right operand. If this condition is true, it returns a true.





            int Jarryd = 29;
            int Daniel = 32;
            Console.WriteLine(Jarryd == Daniel);        }
    }
}
