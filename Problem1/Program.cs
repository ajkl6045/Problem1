using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Start time:");
            string startTime = Console.ReadLine();

            Console.WriteLine("End time:");
            string endTime = Console.ReadLine();

            var diffInSeconds = (Convert.ToDateTime(endTime) - Convert.ToDateTime(startTime)).TotalSeconds;
            Console.WriteLine("{0}", diffInSeconds);

            TimeSpan sTime = Convert.ToDateTime(startTime).TimeOfDay;
            TimeSpan eTime = Convert.ToDateTime(endTime).TimeOfDay;
            int cycle = 0;
            if (sTime.Hours >=9 && sTime.Hours<23 && eTime.Hours >= 9 && eTime.Hours < 23)
            {
            //    Console.WriteLine("Peak");
                 cycle =Convert.ToInt32( diffInSeconds) / 20;
                if(Convert.ToInt32(diffInSeconds) % 20!=0)
                {
                    cycle ++;
                }
              //  double balance = 0;
               double balance =cycle * 0.3;
                Console.WriteLine("Charge: {0} taka",balance);
            }
           else if ((sTime.Hours >= 0 && sTime.Hours < 8 && eTime.Hours >= 0 && eTime.Hours < 8) || (sTime.Hours >= 23 && sTime.Hours < 0 && eTime.Hours >= 23 && eTime.Hours < 0))
            {
                //    Console.WriteLine("Peak");
                cycle = Convert.ToInt32(diffInSeconds) / 20;
                if (Convert.ToInt32(diffInSeconds) % 20 != 0)
                {
                    cycle++;
                }
                //  double balance = 0;
                double balance = cycle * 0.2;
                Console.WriteLine("Charge: {0} taka", balance);
            }
            else if(sTime.Hours >= 9 && sTime.Hours < 23 || eTime.Hours >= 9 && eTime.Hours < 23)
            {
                cycle = Convert.ToInt32(diffInSeconds) / 20;
                if (Convert.ToInt32(diffInSeconds) % 20 != 0)
                {
                    cycle++;
                }
                //  double balance = 0;
                double balance = cycle * 0.3;
                Console.WriteLine("Charge: {0} taka", balance);
            }



            Console.ReadLine();
        }
    }
}
