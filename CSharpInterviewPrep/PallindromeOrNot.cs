using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrep
{
    public class PallindromeOrNot
    {
        public static Boolean IfPallindrome(string s)
        {
            string revstr="";
            foreach (char c in s.Reverse().ToArray()) { revstr += c; }
            if (revstr == s) return true;
            else return false;
        }
    }
}
