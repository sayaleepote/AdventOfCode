using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText(@"C:\Users\Pote_s\Desktop\AdventOfCode\input.txt");
            Int64 floorCount = 0;
            int firstBasementPosition = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    floorCount++;
                }

                else if (input[i] == ')')
                { 
                    floorCount--;
                }


                if (floorCount == -1)
                {
                    firstBasementPosition = i + 1;
                    break;
                }
            }

            Console.WriteLine("FloorCount: {0}",floorCount);

            Console.WriteLine("FirstBasementPosition: {0}", firstBasementPosition);

            Console.ReadLine();
        }
    }
}
