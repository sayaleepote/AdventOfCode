using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 16bit
            //string[] input = System.IO.File.ReadAllLines(@"C:\Users\Pote_s\Desktop\AdventOfCode\circuit.txt");

            //Dictionary<string, System.Int16> values = new Dictionary<string, System.Int16>();
            //int k = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    string[] inputArray = input[i].Split(' ');

            //    for (int j = 0; j < inputArray.Length; j++)
            //    {
            //        if (inputArray[j] != "->" && inputArray[j] != "AND" && inputArray[j] != "OR" && inputArray[j] != "RSHIFT" && inputArray[j] != "LSHIFT" && !int.TryParse(inputArray[j], out k))
            //        {
            //            if (!values.ContainsKey(inputArray[j]))
            //                values.Add(inputArray[j], (Int16)(-1));
            //        }
            //    }

            //    if (inputArray.Length == 3)
            //    {
            //        if (int.TryParse(inputArray[0], out k))
            //        {
            //            values[inputArray[2]] = Convert.ToInt16(inputArray[0]);
            //        }
            //    }
            //}


            //while (values.ContainsValue(-1))
            //{
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        string[] inputArray = input[i].Split(' ');

            //        //For direct assignment
            //        if (inputArray.Length == 3)
            //        {
            //            if (values.ContainsKey(inputArray[0]))
            //            {
            //                if (values[inputArray[0]] != -1)
            //                {
            //                    values[inputArray[2]] = values[inputArray[0]];
            //                }
            //            }
            //        }

            //        //for NOT operations
            //        if (inputArray.Length == 4)
            //        {
            //            if (values[inputArray[1]] != -1)
            //            {
            //                short operand = (values[inputArray[1]]);
            //                values[inputArray[3]] = Convert.ToInt16(~operand);
            //            }
            //        }


            //        //for other operations
            //        if (inputArray.Length == 5)
            //        {
            //            System.Int16 op1 = 0;
            //            System.Int16 op2 = 0;

            //            //Operand 1
            //            if (values.ContainsKey(inputArray[0]))
            //            {
            //                op1 = values[inputArray[0]];
            //            }

            //            else
            //            {
            //                op1 = Convert.ToInt16(inputArray[0]);
            //            }

            //            //Operand 2
            //            if (values.ContainsKey(inputArray[2]))
            //            {
            //                op2 = values[inputArray[2]];
            //            }

            //            else
            //            {
            //                op2 = Convert.ToInt16(inputArray[2]);
            //            }


            //            //Operations
            //            if (op1 != -1 && op2 != -1)
            //            {
            //                if (inputArray[1] == "AND")
            //                {
            //                    values[inputArray[4]] = Convert.ToInt16(op1 & op2);
            //                }

            //                if (inputArray[1] == "OR")
            //                {
            //                    values[inputArray[4]] = Convert.ToInt16(op1 | op2);
            //                }

            //                if (inputArray[1] == "LSHIFT")
            //                {
            //                    values[inputArray[4]] = Convert.ToInt16(op1 << op2);
            //                }

            //                if (inputArray[1] == "RSHIFT")
            //                {
            //                    values[inputArray[4]] = Convert.ToInt16(op1 >> op2);
            //                }
            //            }

            //        }
            //    }
            //}

            //Console.WriteLine(values["a"]); 
            #endregion

           // Console.WriteLine(1 << 15);


            #region 32bit
            string[] input = System.IO.File.ReadAllLines(@"C:\Users\Pote_s\Desktop\AdventOfCode\circuit.txt");

            Dictionary<string, int> values = new Dictionary<string, int>();
            int k = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] inputArray = input[i].Split(' ');

                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[j] != "->" && inputArray[j] != "AND" && inputArray[j] != "OR" && inputArray[j] != "RSHIFT" && inputArray[j] != "LSHIFT" && !int.TryParse(inputArray[j], out k) && inputArray[j] != "NOT")
                    {
                        if (!values.ContainsKey(inputArray[j]))
                            values.Add(inputArray[j], -1);
                    }
                }

                if (inputArray.Length == 3)
                {
                    if (int.TryParse(inputArray[0], out k))
                    {
                        values[inputArray[2]] = Convert.ToInt32(inputArray[0]);
                    }
                }
            }


            while (values.ContainsValue(-1))
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string[] inputArray = input[i].Split(' ');

                    //For direct assignment
                    if (inputArray.Length == 3)
                    {
                        if (values.ContainsKey(inputArray[0]))
                        {
                            if (values[inputArray[0]] != -1)
                            {
                                values[inputArray[2]] = values[inputArray[0]];
                            }
                        }
                    }

                    //for NOT operations
                    if (inputArray.Length == 4)
                    {
                        if (values[inputArray[1]] != -1)
                        {
                            int operand = (values[inputArray[1]]);
                            values[inputArray[3]] = ~operand;
                        }
                    }


                    //for other operations
                    if (inputArray.Length == 5)
                    {
                        int op1 = 0;
                        int op2 = 0;

                        //Operand 1
                        if (values.ContainsKey(inputArray[0]))
                        {
                            op1 = values[inputArray[0]];
                        }

                        else
                        {
                            op1 = Convert.ToInt32(inputArray[0]);
                        }

                        //Operand 2
                        if (values.ContainsKey(inputArray[2]))
                        {
                            op2 = values[inputArray[2]];
                        }

                        else
                        {
                            op2 = Convert.ToInt32(inputArray[2]);
                        }


                        //Operations
                        if (op1 != -1 && op2 != -1)
                        {
                            if (inputArray[1] == "AND")
                            {
                                values[inputArray[4]] = (int)((uint)op1 & (uint)op2);
                            }

                            if (inputArray[1] == "OR")
                            {
                                values[inputArray[4]] = (int)((uint)op1 | (uint)op2);
                            }

                            if (inputArray[1] == "LSHIFT")
                            {
                                int valueRef = (int)((uint)op1 << op2);
                                values[inputArray[4]] = Convert.ToInt32(valueRef);
                            }

                            if (inputArray[1] == "RSHIFT")
                            {
                                int valueRef = (int)((uint)op1 >> op2);
                                values[inputArray[4]] = Convert.ToInt32(valueRef);
                            }
                        }

                    }
                }
            }

            Console.WriteLine(values["g"]);  
            #endregion


            Console.ReadLine();
        }
    }
}
