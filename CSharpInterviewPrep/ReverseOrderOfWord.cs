using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrep
{
    public class ReverseOrderOfWord
    {
        public static string ReOrder(string word) {
            string[] words = word.Split(' ').Reverse().ToArray();
            string rev = "";
            foreach (string s in words) { rev += s + " ";           }
            return rev.Trim();

        }
    }
}
