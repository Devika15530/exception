using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnuserdefined_exception
{
    public class salaryException:Exception//user defined exception that inherits base class Exception

    {
        public salaryException(string s):base(s)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("dev", 100, 0);
            try
            {
                if (e.sal == 0) throw new salaryException("salary cannot be zero");//creating object for user defined exeption
            }
            catch(salaryException se)
            {
                Console.WriteLine(se.Message);
                Console.WriteLine(se.StackTrace);

            }
            Console.ReadLine();
        }
    }
}
