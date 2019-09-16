using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadClockProblem
{
    public class BadClock
    {
       public double nextAgreement(string trueTime, string skewTime, double hourlyGain)
        {
            //Initialise agreementTime
            double agreementTime = 0;

            DateTime trueTime1 = Convert.ToDateTime(trueTime);
            DateTime skewTime1 = Convert.ToDateTime(skewTime);
            DateTime newTime;
            if(trueTime1 == skewTime1)
            {
                return agreementTime;
            }

            else
            {
                    
                while (skewTime1 != trueTime1) 
                {
                    newTime = skewTime1.AddSeconds(hourlyGain);
                    Console.WriteLine(newTime);
                    skewTime1 = newTime;
                    agreementTime++;

                } 

            }

            //Return agreementTime
            return agreementTime;
        }
    }
}
