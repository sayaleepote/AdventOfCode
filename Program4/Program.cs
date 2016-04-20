using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
                 for (int i = 1; i <= 99999999; i++)
                 {
                     //string secretKey = "abcdef";
                     string secretKey = "ckczppom";
                     //string secretKey = "iwrupvqb";
                     secretKey = secretKey + i.ToString();

                     // byte array representation of secretKey
                     byte[] encodedSecretKey = new UTF8Encoding().GetBytes(secretKey);

                     //MD5 to calculate the hash
                     byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedSecretKey);

                     // string representation (similar to UNIX format)
                     string encoded = BitConverter.ToString(hash)
                         // without dashes
                        .Replace("-", string.Empty)
                         // make lowercase
                        .ToLower();

                     if(encoded.Substring(0,6) == "000000")
                     {
                         Console.WriteLine(i);
                         break;
                     }
                 }

                 Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
