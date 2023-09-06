using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    public delegate void transformer(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i =  int.Parse(Console.ReadLine());

            transformer t; //create the instance

            t = square; // point to the function

            t += cuber; // points to another function

            t.Invoke(i); // invoking the delegate

            NotificationOfMethods obj = new NotificationOfMethods();

            obj.TransformerEvent += user1.Xhandler;
            obj.TransformerEvent += user2.Yhandler;

            obj.NotifyOnCell(i);

            Console.ReadLine(); 


        }

        public static void square(int x)
        {
            Console.WriteLine(x*x);
        }

        public static void cuber(int x)
        {
            Console.WriteLine(x*x*x);
        }

        // notification method
        class NotificationOfMethods
        {
            public event transformer TransformerEvent;

            public void NotifyOnCell(int x)
            {
                if(TransformerEvent != null)
                {
                    TransformerEvent(x);
                }
            }
        }

        //subscribers to the event 
        class user1
        {
            public static void  Xhandler(int x)
            {
                Console.WriteLine("event recieved by user1 object");
            }
        }

        class user2
        {
            public static void Yhandler(int x) 
            {
                Console.WriteLine("Event Recieved by user2 object");
            }
        }
    }
}


// real life example of event is emails and cellphone notification upon completion of some task