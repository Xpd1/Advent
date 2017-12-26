using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Day7Advent2015
{
    class Program
    {   
        public static void Gates()
        {
            string str1;

            string[] splitdata;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("b", 46065);
            StreamReader f = new StreamReader(@"G:\fajl.txt");
            while(!dic.ContainsKey("a"))
            {
                if ((str1 = f.ReadLine()) == null)
                {
                    f.DiscardBufferedData();
                    f.BaseStream.Seek(0, SeekOrigin.Begin);
                    f.BaseStream.Position = 0;
                    continue;
                }
                
                splitdata =  str1.Split(' ');

                if (splitdata[0].Any(c => char.IsDigit(c)) && splitdata[1] == "->")
                {
                    if (!dic.ContainsKey(splitdata[2]))
                    
                        dic.Add(splitdata[2], Convert.ToInt16(splitdata[0]));
                       
                    
                }

                if (splitdata[0] != "NOT")
                {
                    if (dic.ContainsKey(splitdata[0]) && splitdata[1] == "->")
                    {
                        if (!dic.ContainsKey(splitdata[2]))
                            dic.Add(splitdata[2],  dic[splitdata[0]]);
                    }
                    else if (dic.ContainsKey(splitdata[0]) && splitdata[1] == "RSHIFT")
                    {
                        int temp = dic[splitdata[0]] >> Convert.ToInt16(splitdata[2]);
                        if (!dic.ContainsKey(splitdata[4]))
                            dic.Add(splitdata[4], temp);
                    }
                    else if (dic.ContainsKey(splitdata[0]) && splitdata[1] == "LSHIFT")
                    {
                        int temp = dic[splitdata[0]] << Convert.ToInt16(splitdata[2]);
                        if (!dic.ContainsKey(splitdata[4]))
                            dic.Add(splitdata[4], temp);
                    }
                    else if (splitdata[0] == "1" && splitdata[1] == "AND" && dic.ContainsKey(splitdata[2]))
                    {
                        int temp = 1 & dic[splitdata[2]];
                        if (!dic.ContainsKey(splitdata[4]))
                            dic.Add(splitdata[4], temp);
                    }
                    else if (dic.ContainsKey(splitdata[0]) && splitdata[1] == "AND" && dic.ContainsKey(splitdata[2]))
                    {
                        int temp = dic[splitdata[0]] & dic[splitdata[2]];
                        if (!dic.ContainsKey(splitdata[4]))
                            dic.Add(splitdata[4], temp);
                    }
                    else if (dic.ContainsKey(splitdata[0]) && splitdata[1] == "OR" && dic.ContainsKey(splitdata[2]))
                    {
                        int temp = dic[splitdata[0]] | dic[splitdata[2]];
                        if (!dic.ContainsKey(splitdata[4]))
                            dic.Add(splitdata[4], temp);
                    }
                }
                else if (splitdata[0] == "NOT")
                {
                    if (dic.ContainsKey(splitdata[1]) && splitdata[2] == "->")
                    {
                        if (!dic.ContainsKey(splitdata[3]))
                        {
                            
                            dic.Add(splitdata[3], ~dic[splitdata[1]]);
                            
                        }
                    }

                }


            }

                
                Console.WriteLine(dic["a"]);

        }
        static void Main(string[] args)
        {
            Gates();
            Console.ReadKey();
        }
    }
}
