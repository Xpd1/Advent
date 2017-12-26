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
    {   public static void Stingici()
        {
            string str1;
            int brojac1 = 0;
            int brojac2 = 0;
            StreamReader f = new StreamReader(@"G:\fajl.txt");

            while ((str1 = f.ReadLine()) != null) {
                brojac1 += str1.Length;
                brojac2 += str1.Length-2;
                for (int i=0; i<str1.Length-2; i++)
                {
                    if (str1[i] == '\\')
                    {
                        Console.WriteLine(str1[i] + " " + str1[i+1]);
                        switch (str1[i + 1])
                        {
                            case 'x':
                                brojac2 -= 3;
                                i++;
                                break;
                            case '\\':
                                brojac2 -= 1;
                                i++;
                                break;
                            case '\"':
                                brojac2 -= 1;
                                i++;
                                break;


                        }
                    }
                }

            

                

            }
            Console.WriteLine(brojac1- brojac2);
          

        }
        static void Main(string[] args)
        {
            Stingici();
            Console.ReadKey();

        }
    }
}
