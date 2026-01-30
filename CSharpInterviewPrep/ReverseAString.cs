using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrep
{
    public class ReverseAString
    {
        public static string ReverseString(ref string str)
        {
            string transpose = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                transpose += str[i];
            }
            return transpose;
        }
    }
}
