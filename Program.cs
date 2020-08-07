using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SayHi("Mogley", 8);
            SayHi("Ziggy", 6);
            SayHi("Dela", 4);
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age);

        }

    }

}
