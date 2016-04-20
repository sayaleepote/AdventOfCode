using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText(@"C:\Users\Pote_s\Desktop\AdventOfCode\houseDirections.txt");
            //String input = "v>v<vvv<<vv^v<v>vv>v<<<^^^^^<<^<vv>^>v^>^>^>^>^><vvvv<^>^<<^><<<^vvvv>^>^><^v^><^<>^^>^vvv^<vv>>^>^^<>><>^>vvv>>^vv>^<><>^<v^>^>^><vv^vv^>><<^><<v>><>^<^>>vvv>v>>>v<<^<><^<v<>v>^^v^^^<^v^^>>><^>^>v<>^<>>^>^^v^><v<v>>><>v<v^v>^v<>>^><v>^<>v^>^<>^v^^^v^^>>vv<<^^><^<vvv>^>^^<^>>^^^^^v^<v>vv<>>v^v<^v^^<><^<^vv^><>><><>v>vvv^vv^^<<><<vvv><<^v^><v<>vvv^<^>vvvv^>^>>^v^<v^vv<^^v<>v>vv^<>><";
            Console.WriteLine(input.Length);

            int[,] houseBlock = new int [10000, 10000];

            char [] inputChar = input.ToCharArray(0, input.Length);

            int x = 5000, y = 5000;

            houseBlock [5000,5000] = 2 ;

            for (int i = 0; i < inputChar.Length - 10; i = i + 2)
            {
                if (inputChar[i] == '>')
                    houseBlock[x, y++]++;

                if (inputChar[i] == '<')
                    houseBlock[x, y--]++;

                if (inputChar[i] == '^')
                     houseBlock[x--, y]++; 

                if (inputChar[i] == 'v')
                     houseBlock[x++, y]++; 
            }

            x = 5000;
            y = 5000;

            for (int i = 1; i < inputChar.Length - 10; i = i + 2)
            {
                if (inputChar[i] == '>')
                    houseBlock[x, y++]++;

                if (inputChar[i] == '<')
                    houseBlock[x, y--]++;

                if (inputChar[i] == '^')
                    houseBlock[x--, y]++;

                if (inputChar[i] == 'v')
                    houseBlock[x++, y]++;
            }

            int count = 0;
             
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    if (houseBlock[i, j] != 0)
                    { 
                        count++;
                       // Console.WriteLine(i+" "+j+" "+houseBlock[i, j]);
                    }
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
