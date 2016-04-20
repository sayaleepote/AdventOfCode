using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines(@"C:\Users\Pote_s\Desktop\AdventOfCode\day8.txt");

            #region FirstHalf
            //Int64 inMemory = 0;
            //Int64 inCode = 0;


            //for (int i = 0; i < input.Length; i++)
            //{
            //    inCode = inCode + input[i].Length;
            //    inMemory = inMemory + input[i].Length - 2;
            //    Console.WriteLine("Length: {0}", input[i].Length);
            //    bool cut = true;

            //    input[i] = input[i].Substring(1,input[i].Length - 2);

            //    while ( cut )
            //    {
            //        if ( input[i].Contains("\\\\") )
            //        {
            //            int index = input[i].IndexOf("\\\\");
            //            input[i] = input[i].Remove(index, 2);                
            //            inMemory--;
            //        }

            //        else
            //        {
            //            cut = false;
            //        }
            //    }

            //    cut = true;
            //    while (cut)
            //    {
            //        if (input[i].Contains("\\\""))
            //        {
            //            int index = input[i].IndexOf("\\\"");
            //            input[i] = input[i].Remove(index, 2);
            //            inMemory--;                   
            //        }

            //        else
            //        {
            //            cut = false;
            //        }
            //    }

            //    cut = true;
            //    while (cut)
            //    {
            //        if (input[i].Contains("\\x"))
            //        {
            //            int index = input[i].IndexOf("\\x");
            //            input[i] = input[i].Remove(index, 4);
            //            inMemory-=3;                     
            //        }

            //        else
            //        {
            //            cut = false;
            //        }
            //    }

            //    Console.WriteLine("String: {0}", input[i]);
            //    Console.WriteLine(i);

            //}

            //Console.WriteLine("inMemory: {0}", inMemory);

            //Console.WriteLine("inCode: {0}", inCode);

            //Console.WriteLine("Difference: {0}", (inCode - inMemory));

            //Console.ReadLine(); 
            #endregion

            #region SecondHalf
            int inCode = 0;
            int inEncoded = 0;

            for (int i = 0; i < input.Length; i++)
            {
                inCode += input[i].Length;

                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][j].Equals('"') || input[i][j].Equals('\\'))
                    {
                        input[i] = input[i].Insert(j, "\\");
                        j++;
                    }
                }

                inEncoded += input[i].Length + 2;
            }

            Console.WriteLine("inCode: {0} ", inCode);
            Console.WriteLine("inEncoded: {0} ", inEncoded);
            Console.WriteLine("Difference: {0} ", inEncoded - inCode);
            Console.ReadLine();
        } 
            #endregion
    }
}

