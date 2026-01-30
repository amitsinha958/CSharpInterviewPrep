using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrep
{
    public class ReverseString
    {
        public static string Logic(string str)
        {
            string revstr = "";
            for(int i = str.Length - 1; i >=0 ; i--)
            {
                revstr += str[i];
            }
            return revstr;
        } 
    }
}
