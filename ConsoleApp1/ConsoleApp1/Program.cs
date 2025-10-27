using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b1, b2; string[] n;
            b1 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            n = Console.ReadLine().ToUpper().Split('.');

            //b1=>10
            float r = 0;
            for (int i = 0; i < n[0].Length; i++)
            {
                char c = n[0][n[0].Length - 1 - i];
                if (c >= '0' && c <= '9')
                    r += (c - '0') * (int)Math.Pow(b1, i);
                else
                    r += (c - 'A' + 10) * (int)Math.Pow(b1, i);

            }

            for (int i = 0; i < n[1].Length; i++)
            {
                char c = n[1][i];
                if (c >= '0' && c <= '9')
                    r += (c - '0') * (float)1 / (int)Math.Pow(b1, i + 1);
                else
                    r += (c - 'A' + 10) * (float)1 / (int)Math.Pow(b1, i + 1);
            }

            //10=>b2
            string s = "0123456789ABCDEF";

            int PI = (int)Math.Floor(r);
            float PF = r - PI;
            string RI = "";

            if (PI == 0)
                RI = "0";
            else
            {
                while (PI > 0)
                {
                    RI = s[(int)(PI % b2)] + RI;
                    PI /= b2;
                }
            }

            string RF = "";

            while (PF - Math.Floor(PF) != 0)
            {
                PF *= b2;
                int cifra = (int)Math.Floor(PF);
                RF += s[cifra];
                PF -= cifra;
            }

            Console.WriteLine($"{RI}.{RF}");
        }
    }
}
