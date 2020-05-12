using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1";
            int num = 1;
            while (num <= 20)
            {
                Console.WriteLine(num + "번째 수열 : " + s);
                char c = s[0];
                int count = 0;
                string space = "";
                for (int i = 0; i < s.Length; i++)
                {
                    if (c == s[i])
                    count++;
                    else
                    {
                        space += "" + c + count;
                        count = 0;
                        c = s[i];
                        count++;
                    }
                    if (i + 1 == s.Length)
                        space += "" + c + count;
                }
                s = space;
                num++;
            }
        }
    }
}
