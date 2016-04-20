using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Program12
{
    class Program
    {
        static void Main(string[] args)
        {
            string indata = System.IO.File.ReadAllText(@"C:\Users\Pote_s\Desktop\AdventOfCode\day12.txt");
            Int64 sum = 0;

            MatchCollection matches = Regex.Matches(indata, @"-?\d+");
            foreach (Match match in matches)
            {
                    sum = sum + Int64.Parse(match.Value);
            }

            Console.WriteLine(sum);
            Console.ReadLine();            
        } 
    }
}
