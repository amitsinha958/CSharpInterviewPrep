using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrep
{
    public class CountNoOfCharacters
    {
        public static void CountChar(string s)
        {
            Dictionary<Char, int> keyValuePairs = new Dictionary<Char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (keyValuePairs.ContainsKey(s[i]))
                {
                    keyValuePairs[s[i]] = keyValuePairs[s[i]] + 1;
                }
                else
                {
                    keyValuePairs.Add(s[i], 1);
                }
            }
            foreach(KeyValuePair<char,int> kvp in keyValuePairs)
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value}");
            }
        }
    }
}
