using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[1000, 1000];

            string[] input = System.IO.File.ReadAllLines(@"C:\Users\Pote_s\Desktop\AdventOfCode\lights.txt");
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;

            #region FirstHalf
            //for (int i = 0; i < input.Length; i++)
            //{
            //    string[] inputArray = input[i].Split(' ', ',');
            //    if (inputArray.Length == 6)
            //    {
            //        x1 = Convert.ToInt32(inputArray[1]);
            //        y1 = Convert.ToInt32(inputArray[2]);

            //        x2 = Convert.ToInt32(inputArray[4]);
            //        y2 = Convert.ToInt32(inputArray[5]);

            //        for (int k = x1; k <= x2; k++)
            //        {
            //            for (int l = y1; l <= y2; l++)
            //            {
            //                if (grid[k, l] == 0)
            //                    grid[k, l] = 1;

            //                else
            //                    grid[k, l] = 0;
            //            }
            //        }
            //    }

            //    if (inputArray.Length == 7)
            //    {
            //        x1 = Convert.ToInt32(inputArray[2]);
            //        y1 = Convert.ToInt32(inputArray[3]);

            //        x2 = Convert.ToInt32(inputArray[5]);
            //        y2 = Convert.ToInt32(inputArray[6]);


            //        for (int k = x1; k <= x2; k++)
            //        {
            //            for (int l = y1; l <= y2; l++)
            //            {
            //                if (inputArray[1] == "on")
            //                {
            //                    grid[k, l] = 1;
            //                }

            //                else
            //                {
            //                    grid[k, l] = 0;
            //                }
            //            }
            //        }

            //    }
            //}


            //int onLights = 0;
            //for (int v = 0; v < 1000; v++)
            //{
            //    for (int w = 0; w < 1000; w++)
            //    {
            //        if (grid[v, w] == 1)
            //            onLights++;
            //    }
            //}

            //Console.WriteLine(onLights); 
            #endregion

            #region SecondHalf
            for (int i = 0; i < input.Length; i++)
            {
                string[] inputArray = input[i].Split(' ', ',');

                if (inputArray.Length == 6)
                {
                    x1 = Convert.ToInt32(inputArray[1]);
                    y1 = Convert.ToInt32(inputArray[2]);

                    x2 = Convert.ToInt32(inputArray[4]);
                    y2 = Convert.ToInt32(inputArray[5]);

                    for (int k = x1; k <= x2; k++)
                    {
                        for (int l = y1; l <= y2; l++)
                        {
                            grid[k, l] += 2;
                        }
                    }
                }

                if (inputArray.Length == 7)
                {
                    x1 = Convert.ToInt32(inputArray[2]);
                    y1 = Convert.ToInt32(inputArray[3]);

                    x2 = Convert.ToInt32(inputArray[5]);
                    y2 = Convert.ToInt32(inputArray[6]);


                    for (int k = x1; k <= x2; k++)
                    {
                        for (int l = y1; l <= y2; l++)
                        {
                            if (inputArray[1] == "on")
                            {
                                grid[k, l]++;
                            }

                            else
                            {
                                if (grid[k, l] == 1)
                                    grid[k, l] = 0;

                                else if (grid[k, l] == 0)
                                    grid[k, l] = 0;

                                else
                                    grid[k, l]--;

                            }
                        }
                    }

                }
            }

            int brightness = 0;
            for (int v = 0; v < 1000; v++)
            {
                for (int w = 0; w < 1000; w++)
                {
                        brightness += grid[v, w];
                }
            }

            Console.WriteLine(brightness);  
            #endregion

            Console.ReadLine();
        }
    }
}
