using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Structure
{
    class MinMax
    {
        private int num1;
        private int num2;
        private int num3;

        public void CheckIsValid()
        {
            Console.WriteLine("Task b \nPlease enter number one: ");
            bool isValidNum1 = Int32.TryParse(Console.ReadLine(), out var num1);

            while (!isValidNum1)
            {
                Console.WriteLine("Invalid number!!! Try again! Number=");
                isValidNum1 = Int32.TryParse(Console.ReadLine(), out num1);
            }

            Console.WriteLine("Please enter number two: ");
            bool isValidNum2 = Int32.TryParse(Console.ReadLine(), out var num2);
            while (!isValidNum2)
            {
                Console.WriteLine("Invalid number!!! Try again! Number=");
                isValidNum2 = Int32.TryParse(Console.ReadLine(), out num2);
            }

            Console.WriteLine("Please enter number three: ");
            bool isValidNum3 = Int32.TryParse(Console.ReadLine(), out var num3);
            while (!isValidNum3)
            {
                Console.WriteLine("Invalid number!!! Try again! Number=");
                isValidNum3 = Int32.TryParse(Console.ReadLine(), out num3);
            }

            if (isValidNum1 && isValidNum2 && isValidNum3)
            {
               GetMax(num1, num2, num3);
               GetMin(num1, num2, num3);
            }
            Console.WriteLine();
        }

        public void GetMin(int num1, int num2, int num3)
        {
            string resultMin = (num1 < num2 && num1 < num3) ? $"Min number is {num1}" :
                (num1 > num2 && num2 < num3) ? $"Min number is {num2}" : $"Min number is {num3}";
            Console.WriteLine(resultMin);
        }

        public void GetMax(int num1, int num2, int num3)
        {
            string resultMax = (num1 > num2 && num1 > num3) ? $"Max number is {num1}" :
                (num1 < num2 && num2 > num3) ? $"Max number is {num2}" : $"Max number is {num3}";
            Console.WriteLine(resultMax);
        }

    }
}
