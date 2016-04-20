using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines(@"C:\Users\Pote_s\Desktop\AdventOfCode\strings.txt");

            int niceStrings = 0;

            #region FirstHalf
            //for (int i = 0; i < input.Length; i++)
            //{
            //    int check = 0;
            //    int vowelCount = 0;

            //    for (int j = 0; j < input[i].Length; j++)
            //    {
            //        if (input[i][j] == 'a' || input[i][j] == 'e' || input[i][j] == 'i' || input[i][j] == 'o' || input[i][j] == 'u')
            //            vowelCount++;

            //        if (vowelCount == 3)
            //        {
            //            check = 1;
            //            break;
            //        }
            //    }


            //    if (check == 1)
            //    {
            //        for (int k = 0; k < input[i].Length - 1; k++)
            //        {
            //            if (input[i][k] == input[i][k + 1])
            //            {
            //                check = 2;
            //                break;
            //            }

            //        }
            //    }


            //    if (check == 2)
            //    {
            //        int flag = 0;

            //        for (int l = 0; l < input[i].Length - 1; l++)
            //        {
            //            if (input[i].Substring(l, 2) == "ab" || input[i].Substring(l, 2) == "cd" || input[i].Substring(l, 2) == "pq" || input[i].Substring(l, 2) == "xy")
            //            {
            //                flag = 1;
            //                break;
            //            }
            //        }

            //        if (flag == 0)
            //        {
            //            check = 3;
            //        }

            //    }


            //    if (check == 3)
            //        niceStrings++;

            //} 
            #endregion

            #region SecondHalf
            for (int i = 0; i < input.Length; i++)
            {
                int check = 0;
       
                for (int j = 0; j < input[i].Length - 1 ; j++)
                {
                    string compare = input[i].Substring(j, 2);

                    for (int l = j+2; l < input[i].Length - 1 ; l++)
                    {
                        if(compare == input[i].Substring(l, 2))
                        {
                            check = 1;
                            break;
                        }
                    }
                    
                    if(check == 1)
                    {
                        break;
                    }
                }


                if (check == 1)
                {
                    for (int k = 0; k < input[i].Length - 2; k++)
                    {
                        if (input[i][k] == input[i][k + 2])
                        {
                            check = 2;
                            break;
                        }

                    }
                }
               

                if (check == 2)
                    niceStrings++;

            }  
            #endregion
            Console.WriteLine(niceStrings);
            Console.ReadLine();

        }
    }
}
