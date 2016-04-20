using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1321131112";
           // string output = "";

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    int count = 1;
                    int jref = j;
                    //Console.WriteLine(input[j]);
                    //Console.WriteLine(input[j+1]);

                    while ( (j != input.Length - 1) && ( input[j].Equals( input[j+1] ) ) )
                    {                       
                        count++;
                        j++;
                    }

                    input = input.Insert(jref, count+"");

                    if (count > 1)
                    {
                        input = input.Remove( jref+1, (count-1) );
                        while (count-1 != 0)
                        {
                            j--;
                            count--;
                        }
                    }
                    j++;
                }
                //Console.WriteLine(input);
            }
            //System.IO.File.WriteAllText(@"D:\path.txt", input.Length+"");

                Console.WriteLine("Final Input:    "+input);
                Console.ReadLine();
        }
    }
}
