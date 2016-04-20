using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{

    //children: 3
    //cats: 7
    //samoyeds: 2
    //pomeranians: 3
    //akitas: 0
    //vizslas: 0
    //goldfish: 5
    //trees: 3
    //cars: 2
    //perfumes: 1


    class Program
    {
        static void Main(string[] args)
        {
            string []input = System.IO.File.ReadAllLines(@"C:\Users\Pote_s\Desktop\AdventOfCode\day16.txt");

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("children", 3);
            dictionary.Add("cats", 7);
            dictionary.Add("samoyeds", 2);
            dictionary.Add("pomeranians", 3);
            dictionary.Add("akitas", 0);
            dictionary.Add("vizslas", 0);
            dictionary.Add("goldfish", 5);
            dictionary.Add("trees", 3);
            dictionary.Add("cars", 2);
            dictionary.Add("perfumes", 1);

            for (int i = 0; i < 5; i++)
            {
                string[] splitInput = input[i].Split(',', ':');

                for ( int j = 1; j < splitInput.Length; j = j + 2 )
                {
                    if(dictionary.ContainsKey(splitInput[j]) && (dictionary[splitInput[j]]+"").Equals(splitInput[j+1]) ){
                        Console.WriteLine(splitInput[j] + " : " + splitInput[j+1]);
                    }

                    else
                    {
                        break;
                    }
                   // Console.WriteLine(splitInput[j]);
                }
                
            }

            Console.ReadLine();
        }
    }
}
