using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Advent2015
{
    class Program
    {
        public static int Stringovi()
        {


            int brojac = 0;
            int brojac2 = 0;
            int brojac3 = 0;
            string str1;
            System.IO.StreamReader f = new System.IO.StreamReader(@"G:\fajl.txt");
            while ((str1 = f.ReadLine()) != null)
            {
                brojac2 = 0;
                brojac3 = 0;
                for (int i = 0; i < str1.Length - 2; i++)
                {

                    if (str1[i] == str1[i + 2])
                    {
                        brojac3++;
                    }

                }
                for (int j = 0; j < str1.Length; j++)
                {
                    for (int g = j + 2; g < str1.Length - 1 ; g++)
                    {
                        if (str1[j] == str1[g] && str1[j+1] == str1[g+1])
                        {
                            brojac2++;
                        }
                    }

                }
                Console.WriteLine(brojac2);
                if (brojac3 > 0 && brojac2 > 0)
                {
                    brojac++; 
                }
                

                



            }
            return brojac;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Stringovi());
            Console.ReadKey();
        }
    }
}
