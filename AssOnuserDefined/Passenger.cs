using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOnuserDefined
{
  public   class Passenger:Test
    {
       

        public void Booking(int ntickets)
        {
            if (ntickets > 2)
            {
                try
                {
                    throw new Bookingexception("cannot book more than 2 tickts");

                }
                catch (Bookingexception be)
                {
                    Console.WriteLine(be.Message);
                }
            }
            else
                for (int i = 1; i <= ntickets; i++)
                {
                    show();
                }
           
         


        }
        
    }
}
