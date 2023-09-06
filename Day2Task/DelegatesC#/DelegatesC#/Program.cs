using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesC_
{

    //delegate return type should be same as the return type of the method which is void
    //signature should also be the same as the method which is (int a,int b)
    //we can call more than 1 funtion through same delegate
    //or we can create another object and pass the reference of another method
    public delegate void Calculation(int a, int b);

    //for instance method we will create an object of the class otherwise we will write static with the method
    internal class Program
    {
         
        public static void addition(int a, int b)
        {
            int result = a + b; 
            Console.WriteLine("The addtion is : {0}", result);  
        }

        public static void subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("The subtraction is : {0}", result);
        }
        static void Main(string[] args)
        {
            //now to create a delegate object which will store the reference of the method
            Calculation obj = new Calculation(Program.addition);
            //call through invoke
            //obj.Invoke(10, 20);

            //calling subtraction through same delegate
            obj += subtraction;
            obj(30, 20);

            Console.ReadLine();

            //two ways to call a method
            // 1.Invoke obj.Invoke(10,10);
            // 2.Passing Arguement directly into the object obj(10,10)
        }
    }
}
