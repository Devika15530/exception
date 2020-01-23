using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOnuserDefined
{
    public class Bookingexception : Exception//user defined exception that inherits base class Exception

    {
        public Bookingexception(string s) : base(s)
        {

        }
    }

  public class Test
    {
        public void show()
        {
            
            Console.WriteLine("enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("enter age");
           int id = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " " + id);
            Console.WriteLine("ticket booked succelfully");
        }

    }

  public   class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("number of tickets");
            int nticket = int.Parse(Console.ReadLine());
            
            Passenger p = new Passenger();

            p.Booking(nticket);
            Test t = new Test();


            Console.ReadKey();
        }
        
            
    }
}
