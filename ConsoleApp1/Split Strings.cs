using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Kata
    {
        //Задача Split Strings
        public static string[] SplitStrings(string str)
        {
            if (str.Length % 2 == 0)
            {
                string[] ss = new string[str.Length/2];
                int counter = 0;
                for (int i = 0; i < str.Length; i+=2)
                {
                    
                    ss[counter] = str.Substring(0+i, 2);
                    counter++;
                }
                
                return ss;
            }
            else
            {
                str = str + "_";
                string[] ss = new string[str.Length / 2];
                int counter = 0;
                for (int i = 0; i < str.Length; i += 2)
                {

                    ss[counter] = str.Substring(0 + i, 2);
                    counter++;
                }

                return ss;
            }    
        }
    }
}
