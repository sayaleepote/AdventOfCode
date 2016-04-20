using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kms = new int[9]{ 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] speed = { 8, 13, 20, 12, 9, 10, 3, 9, 37 };
            int[] sec = { 8, 4, 7, 4, 5, 4, 37, 12, 1 };
            int[] restSec = { 53, 49, 132, 43, 38, 37, 76, 97, 36 };
            int[] workingsec = { 8, 4, 7, 4, 5, 4, 37, 12, 1 };
            int[] points = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //for (int l = 0; l < 9; l++)
            //{
            //    Console.WriteLine(workingsec[l] + "");
            //}


            for (int i = 1; i <= 2503; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i <= workingsec[j])
                    {
                        kms[j] = kms[j] + speed[j];
                    }

                    else if(i == workingsec[j] + restSec[j])
                    {
                        workingsec[j] = workingsec[j] + sec[j] + restSec[j];
                    }
              
                }

                int maxValue = kms.Max();
                int maxIndex = kms.ToList().IndexOf(maxValue);

                points[maxIndex]++;

                for (int k = maxIndex + 1; k < 9; k++)
                {
                    if (kms[k] == maxValue )
                    {
                        points[k]++;
                    }
                }
            }

            int winningPoints = points.Max();

            Console.WriteLine(winningPoints);

            //for (int i = 1; i <= 2503; i++)
            //{
            //        if (i <= workingsec[0])
            //        {
            //            kms[0] = kms[0] + speed[0];
                       
            //        }

            //        if ( i == (workingsec[0] + restSec[0]) )
            //        {
            //            workingsec[0] = workingsec[0] + restSec[0] + sec[0];

            //            Console.WriteLine("i: "+i);
            //            Console.WriteLine("sec: " + sec[0]);
            //            Console.WriteLine("workingsec: "+ workingsec[0]);
            //        }

            //}

            //for (int l = 0; l < 9; l++)
            //{
            //    Console.WriteLine(kms[l] + "");
            //}

            Console.ReadLine();

        }
    }
}
