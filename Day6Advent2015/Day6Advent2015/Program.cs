using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Advent2015
{
    class Program
    {   
        public static void Svetla()
        {

            int[,] flag = new int[1000,1000];
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {

                    flag[i, j] = 0;
                }
            }
            int brojac = 0;
            string str1;
            System.IO.StreamReader f = new System.IO.StreamReader(@"G:\fajl.txt");
            while((str1 = f.ReadLine()) != null)
            {
                string[] s = str1.Split(' ');
                string komanda = "";
                string odX = "";
                string odY = "";
                string doX = "";
                string doY = "";
                if (s[0] == "turn")
                {
                    komanda = s[0] + " " + s[1];
                    string[] temp;
                    temp = s[2].Split(',');
                    odX = temp[0];
                    odY = temp[1];
                    temp = s[4].Split(',');
                    doX = temp[0];
                    doY = temp[1];
                    
                }
                else
                {
                    komanda = s[0];
                    string[] temp;
                    temp = s[1].Split(',');
                    odX = temp[0];
                    odY = temp[1];
                    temp = s[3].Split(',');
                    doX = temp[0];
                    doY = temp[1];
                    
                }
                if (komanda == "toggle")
                    {
                        for (int i = Convert.ToInt16(odX); i <= Convert.ToInt16(doX); i++)
                        {
                            for (int j = Convert.ToInt16(odY); j <= Convert.ToInt16(doY); j++)
                            {
                                if (flag[i, j] == 0)
                                    flag[i, j] = 1;
                                else
                                    flag[i, j] = 0;

                            }
                        }
                    }
                else if (komanda == "turn on")
                    {
                        for (int i = Convert.ToInt16(odX); i <= Convert.ToInt16(doX); i++)
                        {
                            for (int j = Convert.ToInt16(odY); j <= Convert.ToInt16(doY); j++)
                            {
                                if (flag[i, j] == 0)
                                    flag[i, j] = 1;
                                

                            }
                        }
                    }
                else 
                    {
                        for (int i = Convert.ToInt16(odX); i <= Convert.ToInt16(doX); i++)
                        {
                            for (int j = Convert.ToInt16(odY); j <= Convert.ToInt16(doY); j++)
                            {
                                if (flag[i, j] == 1)
                                    flag[i, j] = 0;


                            }
                        }
                    }



                
            }
            for(int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {

                    if (flag[i,j] == 1)
                    {
                        brojac++;
                    }
                }
            }
            Console.WriteLine(brojac);

        }
        static void Main(string[] args)
        {
            Svetla();
            Console.ReadKey();
        }
    }
}
