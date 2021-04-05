using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Person
    {
        public void AddtoCgpa (int math, int phy)
        {
            Console.WriteLine("Added marks to math {0} and physics {1}",math,phy);
        }
    }
}
