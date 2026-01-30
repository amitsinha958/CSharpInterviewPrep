using System;
using System.Linq;

namespace CSharpInterviewPrep
{
    public class AddODDIntegerArraySingleLine
    {
        public static int add(int[] arr)
        {
            //int sum=(new [] {1,2,3,4,5,6,7,8,9,10}).Where(e=>e%2!=0).Sum();
            return arr.Where(e => e % 2 != 0).Sum();

        }
    }
}
