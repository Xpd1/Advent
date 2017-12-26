using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day8Advent2015
{
    class Program
    {
        public static void Stingici()
        {
            string str1;
            int brojac1 = 0;
            int brojac2 = 0;
            StreamReader f = new StreamReader(@"G:\fajl.txt");

            while ((str1 = f.ReadLine()) != null)
            {
                brojac1 += str1.Length;
                brojac2 += str1.Length + 4;
                for (int i = 1; i < str1.Length - 1; i++)
                {
                        switch (str1[i])
                        {
                            case '\"':
                                brojac2 += 1;
                                
                                break;
                            case '\\':
                                brojac2 += 1;
                                
                                break;
                            


                        }
                    
                }





            }
            Console.WriteLine(brojac2 - brojac1);
            


        }
        static void Main(string[] args)
        {
            Stingici();
            Console.ReadKey();

        }
    }
}
