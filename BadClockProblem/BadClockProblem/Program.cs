using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadClockProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            BadClock BadClock1 = new BadClock();

            double output = BadClock1.nextAgreement("11:59:58", "12:03:28", -3);

            Console.WriteLine("Returns: " + output);
            Console.WriteLine("This Clock loses three seconds every hour, and will catch up with the" +
                                "true time in exactly " + output + " hours");
            Console.ReadKey();
        }
    }
}
