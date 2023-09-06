using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_cast_delegate
{
    // single cast delegate only point toward a single method one at a time
    public delegate void Calc(int num1,int num2); 

    internal class Program
    {
        public static void addition(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(" Addition result is: {0} ", result);
        }

        static void Main(string[] args)
        {
            Calc obj = new Calc(addition);
            obj(1, 2); 
            Console.ReadLine(); 
        }
    }
}
