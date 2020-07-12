using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Structure
{
    class Range
    {
        public void GetRange()
        {
            Console.WriteLine("Task a \nPlease enter number one: ");
            bool isValidNum1 = float.TryParse(Console.ReadLine(), out var num1);

            while (!isValidNum1)
            {
                Console.WriteLine("Invalid number!!! Try again! Number=");
                isValidNum1 = float.TryParse(Console.ReadLine(), out num1);
            }

            Console.WriteLine("Please enter number two: ");
            bool isValidNum2 = float.TryParse(Console.ReadLine(), out var num2);
            while (!isValidNum2)
            {
                Console.WriteLine("Invalid number!!! Try again! Number=");
                isValidNum2 = float.TryParse(Console.ReadLine(), out num2);
            }

            Console.WriteLine("Please enter number three: ");
            bool isValidNum3 = float.TryParse(Console.ReadLine(), out var num3);
            while (!isValidNum3)
            {
                Console.WriteLine("Invalid number!!! Try again! Number=");
                isValidNum3 = float.TryParse(Console.ReadLine(), out num3);
            }

            if (isValidNum1 && isValidNum2 && isValidNum3)
            {
                string answerNum1 = (num1 >= -5 && num1 <= 5) ? $"number 1 belongs to the range [-5;5]" : "number 1 does not belongs to the range [-5;5]";
                string answerNum2 = (num2 >= -5 && num2 <= 5) ? $"number 2 belongs to the range [-5;5]" : "number 2 does not belongs to the range [-5;5]";
                string answerNum3 = (num3 >= -5 && num3 <= 5) ? $"number 3 belongs to the range [-5;5]" : "number 3 does not belongs to the range [-5;5]";

                Console.WriteLine(answerNum1);
                Console.WriteLine(answerNum2);
                Console.WriteLine(answerNum3);
            }
            Console.WriteLine();
        }
    }
}
