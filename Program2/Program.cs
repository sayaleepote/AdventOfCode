using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = System.IO.File.ReadAllLines(@"C:\Users\Pote_s\Desktop\AdventOfCode\wrappingPaper.txt");
            Int64 totalWrap = 0;
            Int64 totalRibbon = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] splitArray = input[i].Split('x');
                
                int length = Convert.ToInt32(splitArray[0]);
                int breadth = Convert.ToInt32(splitArray[1]);
                int height = Convert.ToInt32(splitArray[2]);

                int l, b, h, lp, bp, hp;

                //check smallest Area 
                l = length * breadth;
                b = length * height;
                h = height * breadth;

                int smallestArea = smallest(l, b, h);

                totalWrap = totalWrap + 2 * (l + b + h) + smallestArea;

                //check smallest Perimeter
                lp = 2 * (length + breadth);
                bp = 2 * (length + height);
                hp = 2 * (height + breadth);

                int smallestPerimeter = smallest(lp, bp, hp) ;

                totalRibbon = totalRibbon + (length * breadth * height) + smallestPerimeter;

            }


            Console.WriteLine("Total Wrapping Paper required: {0}", totalWrap);
            Console.WriteLine("Total Ribbon required: {0}", totalRibbon);
            Console.ReadLine();

        }

        static int smallest(int l, int b, int h)
        {
            int smallestValue = 0;
            if (l < b)
            {
                if (l < h)
                    smallestValue = l;

                else
                    smallestValue = h;
            }

            else
            {
                if (b < h)
                    smallestValue = b;

                else
                    smallestValue = h;
            }


            return smallestValue;
        }
    }
}
