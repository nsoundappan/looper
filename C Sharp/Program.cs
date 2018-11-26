using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            classB cb = new classB();
          //  GC.Collect();
            Console.Read();
        }
    }

    public class classA
    {
        public classA()
        {
            Console.WriteLine("Base Class");
        }

        ~classA()
            {
            Console.WriteLine("Destruct Base");
        }
    }

    public class classB: classA
    {
        public classB()
        {
            Console.WriteLine("Derived Class");
        }

        ~classB()
        {
            Console.WriteLine("Destruct Derived");
        }
    }
}
