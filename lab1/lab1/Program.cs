using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int b1, b2; string n;
            b1 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            n = Console.ReadLine().ToUpper();

           
            int t = 0;
            for (int i = 0; i < n.Length; i++)
            {
                char c = n[n.Length - 1 - i];
                if (c >= '0' && c <= '9')
                    t += (c - '0') * (int)Math.Pow(b1, i);
                else
                    t += (c - 'A' + 10) * (int)Math.Pow(b1, i);

            }

            
            string s = "0123456789ABCDEF";
            string r = "";
            if (t == 0)
                r = "0";
            else
            {
                while (t > 0)
                {
                    r = s[t % b2] + r;
                    t /= b2;
                }
            }

            Console.WriteLine(r);
        }
    }
}