using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMultipliers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRed = 3;
            int maxBull = 5;
            int redCounter = maxRed;
            int bullCounter = maxBull;

            for (int i = 0; i <= 100; i++)
            {
                if(redCounter == 0)
                {
                    redCounter = maxRed;

                    if (bullCounter == 0)
                    {
                        bullCounter = maxBull;
                        Console.WriteLine(string.Format(" i = {0} RedBull ", i));
                    }
                    else
                    {
                        Console.WriteLine(string.Format(" i = {0} Red ", i));
                    }

                }
                else
                {
                    if(bullCounter == 0)
                    {
                        bullCounter = maxBull;
                        Console.WriteLine(string.Format(" i = {0} Bull ", i));
                    }
                    else
                    {
                        Console.WriteLine(" i = " + i.ToString());
                    }
                }

                bullCounter--;
                redCounter--;
            }

            Console.ReadKey();
        }
    }
}
