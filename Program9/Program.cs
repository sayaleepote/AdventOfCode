using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] locations = { "Faerun", "Norrath", "Tristram", "AlphaCentauri", "Arbre", "Snowdin", "Tambi", "Straylight"};
            int[ , ] distance = new int[8,8] { { 0, 129, 58,  13,  24,  60,  71, 67},
                                               { 0, 0,   142, 15,  135, 75,  82, 54},
                                               { 0, 0,   0,   118, 122, 103, 49, 97},
                                               { 0, 0,   0,   0,   116, 12,  18, 91},
                                               { 0, 0,   0,   0,   0,   129, 53, 40},
                                               { 0, 0,   0,   0,   0,   0,   15, 99},
                                               { 0, 0,   0,   0,   0,   0,   0,  70},
                                               { 0, 0,   0,   0,   0,   0,   0,  0 } };


        }
    }
}
