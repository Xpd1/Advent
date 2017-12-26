using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Advent2015
{
    class Program
    {
        public static string CreateMD5(string input)
        {
            
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        public static double Racunica()
        {
            double resenje = 0;
            while (true)
            {
                
                string pokusaj = CreateMD5("yzbqklnj" + resenje);
                
                if (pokusaj[0] == '0' && pokusaj[0] == '0' && pokusaj[1] == '0' && pokusaj[2] == '0' && pokusaj[3] == '0' && pokusaj[4] == '0' && pokusaj[5] == '0')
                {
                    return resenje;
                    
                    break;
                }
                resenje++;
                

            }
        }
        static void Main(string[] args)
        {


            Console.WriteLine(Racunica());
            Console.ReadKey();
        }
    }
}
