using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static int Input()
        {
            int suma = 0;
            int ribbon = 0;
            string linija;
            System.IO.StreamReader f = new System.IO.StreamReader(@"G:\fajl.txt");
            while ((linija = f.ReadLine()) != null)
            {
                string[] s = linija.Split('x');
                int l = Convert.ToInt32(s[0]);
                int w = Convert.ToInt32(s[1]);
                int h = Convert.ToInt32(s[2]);

                suma += Racunaj(l, w, h);
                ribbon += Ribbon(l, w, h);

            }
            return ribbon;
        }
        public static int Ribbon(int l, int w, int h)
        {
            
            int max = new int[] { l, w, h }.Max();
            if (max == l)
                return (2 * h + 2 * w) + (l * w * h);
            else if (max == w)
                return (2 * h + 2 * l) + (l * w * h);
            else 
                return (2 * w + 2 * l) + (l * w * h);

        }
            
        
        public static int Racunaj(int l, int w, int h)
        {
            int str1 = l * w;
            int str2 = w * h;
            int str3 = h * l;
            int min = new int[] { str1, str2, str3 }.Min();
            

            return (2 * l * w + 2 * w * h + 2 * h * l) + min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Input());
            Console.ReadKey();
        }
    }
}
