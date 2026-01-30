using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrep
{
    public class SecondLargestValueInAnArrayUsingOneLoop
    {
        public static int SecondLargest(int[] arr)
        {
            //int[] arr = {8,97,2,3,4,5,99,92,98 };
            //int secondlargest = 0;
            //secondlargest = arr.Order().Reverse().Take(2).Last();
            //return secondlargest;

            int max1 = 0;
            int max2 = 0;

            foreach (int item in arr)
            {      //{ 8, 97, 2, 3, 4, 5, 99, 92, 98 }
                if (item > max1) 
                { 
                    max2 = max1; // 0 8  97 
                    max1 = item; // 8 97 99
                }
                else if(item>=max2 && item != max1)
                {
                    max2 = item; // 98 
                }
                // 2  skipped
                // 3  skipped
                // 4  skipped
                // 5  skipped
                // 92 skipped 
            }
            return max2;
        }
    }
}
