using System;

namespace HW2Structure
{
    public class Dog
    {
        DogStruct dog = new DogStruct();

        public void OutDog()
        {
            Console.WriteLine("Task d \nPlease enter name dog");
            dog.name = Console.ReadLine();

            Console.WriteLine("Please enter mark dog");
            dog.mark = Console.ReadLine();

            Console.WriteLine("Please enter age dog");
            bool isValid = Int32.TryParse(Console.ReadLine(), out var age);

            while (!isValid)
            {
                Console.WriteLine("Invalid age!!! Try again! Age=");
                isValid = Int32.TryParse(Console.ReadLine(), out age);
            }

            if (isValid)
            {
                dog.age = age;
                Console.WriteLine($"The dog is: \n {dog.name} \n {dog.mark} \n {dog.age}");
            }
            Console.WriteLine();
        }
    }
}