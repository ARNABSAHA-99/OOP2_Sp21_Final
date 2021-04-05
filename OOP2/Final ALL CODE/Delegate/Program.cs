using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate void arithmatic(int a, int b);
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition: "+(a+b));
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }

        static void Main(string[] args)
        {
            //Individually calling or indicate
            arithmatic calc = Add;
            calc(10, 5);
            calc = Sub;
            calc(10, 5);

            Person p = new Person();
            calc = p.AddtoCgpa;
            calc(70, 80);

            //at a time calling and added all method/ multi-custing
            arithmatic calc2 = Add;
            calc2 += Sub;
            calc2 += p.AddtoCgpa;

            calc2(30, 20);

            //remove one method

            calc2 -= Sub;
            calc2(70, 60);

        }
    }
}
