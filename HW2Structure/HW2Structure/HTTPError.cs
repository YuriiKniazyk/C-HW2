using System;

namespace HW2Structure
{
    public class HTTPError
    {
        public void GetNameError()
        {
            Console.WriteLine("Task c \nPlease enter number error of list(400, ..., 404): ");
            bool isValid = Int32.TryParse(Console.ReadLine(), out var error);

            while (!isValid)
            {
                Console.WriteLine("Invalid number!!! Try again! Number=");
                isValid = Int32.TryParse(Console.ReadLine(), out error);
            }

            if (isValid)
            {
                if (error != 400 && error != 401 && error != 402 && error != 403 && error != 404)
                {
                    Console.WriteLine("This error is not exist!!!");
                }
                else
                {
                    HTTPErrorEnum nameError = (HTTPErrorEnum)error;
                    Console.WriteLine($"The name of HTTP error is: {nameError}");
                }
            }
            Console.WriteLine();
        }
    }
}