using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Range range = new Range();
            range.GetRange();

            MinMax minMax = new MinMax();
            minMax.CheckIsValid();

            HTTPError httpError = new HTTPError();
            httpError.GetNameError();

            Dog dog = new Dog();
            dog.OutDog();

            Console.ReadKey();
        }
    }
}
