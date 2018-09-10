using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chashDelegates
{
    class Maths
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return b - a;
        }
    }
    class Program
    {
        public delegate int Function(int value1, int value2);

        static void Main(string[] args)
        {
            Maths mc = new Maths();
            Function add = new Function(mc.add);
            Function sub = new Function(mc.sub);
            Console.WriteLine("Addition of 2 Numbers ::" + add(100, 200));
            Console.WriteLine("Subtraction of 2 numbers :: " + sub(10,30));
            Console.ReadLine();
        }
    }
    
   
}
   
