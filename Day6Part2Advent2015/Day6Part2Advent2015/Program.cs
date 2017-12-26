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
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[,] flag = new int[1000, 1000];
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
            while ((str1 = f.ReadLine()) != null)
            {
                string[] s = str1.Split(' ');
                string komanda = "";
                int odX = 0;
                int odY = 0;
                int doX = 0;
                int doY = 0;
                if (s[0] == "turn")
                {
                    komanda = s[0] + " " + s[1];
                    string[] temp;
                    temp = s[2].Split(',');
                    odX = Convert.ToInt16(temp[0]);
                    odY = Convert.ToInt16(temp[1]);
                    temp = s[4].Split(',');
                    doX = Convert.ToInt16(temp[0]);
                    doY = Convert.ToInt16(temp[1]);
                }
                else
                {
                    komanda = s[0];
                    string[] temp;
                    temp = s[1].Split(',');
                    odX = Convert.ToInt16(temp[0]);
                    odY = Convert.ToInt16(temp[1]);
                    temp = s[3].Split(',');
                    doX = Convert.ToInt16(temp[0]);
                    doY = Convert.ToInt16(temp[1]);
                 }
                if (komanda == "toggle")
                {
                    for (int i = odX; i <= doX; i++)
                    {
                        for (int j = odY; j <= doY; j++)
                        {
                            flag[i, j] += 2;
                        }
                    }
                }
                else if (komanda == "turn on")
                {
                    for (int i = odX; i <= doX; i++)
                    {
                        for (int j = odY; j <= doY; j++)
                        {
                            flag[i, j] += 1;
                        }
                    }
                }
                else
                {
                    for (int i = odX; i <= doX; i++)
                    {
                        for (int j = odY; j <= doY; j++)
                        {
                            if ((flag[i, j] - 1) != -1)
                                flag[i, j] -= 1;
                        }
                    }
                }
            }
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {                    
                        brojac += flag[i,j];                    
                }
            }
            Console.WriteLine(brojac);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
        static void Main(string[] args)
        {
            Svetla();
            
            Console.ReadKey();
            
        }
    }
}
