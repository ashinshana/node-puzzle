using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieFarm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double value = CalculateTime(500.0, 4.0, 2000.0);
            Console.WriteLine("Total Time To Win : " + value);
            Console.ReadKey();
        }

        public static double CalculateTime(double noOfCookiesToBuyAFarm, double frequecy, double noOfCookiesToWin)
        {
            double C = noOfCookiesToBuyAFarm;
            double F = frequecy;
            double X = noOfCookiesToWin;
            double totalTime = 0.0;
            double cookieFrequency = 2;
            int noOfFarms = 0;

            for (; noOfFarms <= 3; noOfFarms++ )
            {
                if (noOfFarms < 3)
                {
                    double timeToBuyNewFarm = C / cookieFrequency;
                    Console.WriteLine("Time To Buy A New Farm : "+timeToBuyNewFarm);
                    cookieFrequency = cookieFrequency + F;
                    totalTime = totalTime + timeToBuyNewFarm;
                }
                else
                {
                    totalTime = totalTime + (X / cookieFrequency);
                    Console.WriteLine("Time To win : " + totalTime);
                }
            }

            return totalTime;
        }
    }
}
