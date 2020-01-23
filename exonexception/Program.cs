using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exonexception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num / 2);
                try
                {
                    int[] a = new int[] { 1, 2, 3 };
                    Console.WriteLine(a[4]);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Source);
                    Console.WriteLine(e.StackTrace);

                }

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);

            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
                Console.WriteLine(m.Source);
                Console.WriteLine(m.StackTrace);
            }
            finally
            {
                Console.WriteLine("program ended");

            }
                Console.ReadKey();
           
        }
    }
}
