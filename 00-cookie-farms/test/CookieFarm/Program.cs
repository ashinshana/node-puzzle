using System;

namespace CookieFarm
{
    public class Program
    {
        // This a console app for the game. You can run this and get the output for any value you want
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter how many cookies need to buy a farm : ");
            double noOfCookiesToBuyAFarm = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter what is the frequency of generating cookies : "); 
            double frequecy = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many cookies need to win the game : "); 
            double noOfCookiesToWin = Double.Parse(Console.ReadLine()); 
            //double totalTime = CalculateTime(500.0, 4.0, 2000.0);


            double totalTime = CalculateTime(noOfCookiesToBuyAFarm, frequecy, noOfCookiesToWin);
            Console.WriteLine("Total Time To Win : " + Math.Round(totalTime, 7));
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
