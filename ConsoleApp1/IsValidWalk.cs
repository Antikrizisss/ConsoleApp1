using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Kata
    {
        //Задача Take a Ten Minute Walk
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length == 10)
            {
                int n = 1;
                int s = 1;
                int w = 1;
                int e = 1;
                for (int i = 0; i<10; i++)
                {
                    switch (walk[i])
                    {
                        case "n":
                            n += n;
                            break;
                        case "s":
                            s += s;
                            break;
                        case "w":
                            w += w;
                            break;
                        case "e":
                            e += e;
                            break;
                    }
                }
                if (n == s & w == e)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
    }
}
