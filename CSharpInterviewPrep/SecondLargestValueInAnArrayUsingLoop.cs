using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrep
{
    public class SecondLargestValueInAnArrayUsingLoop
    {
        public static int FindSecondLargest(int[] arr)
        {
            int secondmaxvalue = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        secondmaxvalue = arr[i];
                    }
                    else if (arr[j] >= arr[i])
                    {
                        secondmaxvalue = arr[j];
                    }
                }
            }
            return secondmaxvalue;
        }
        public static int FindAnyLargest(int[] arr, int largestposition)
        {
            int temp = 0;

            //Sort and array in ascending order
            //for (int i = 0; i <= arr.Length - 1; i++)
            //{
            //    for (int j = 0; j < arr.Length - i - 1; j++)             
            //    {
            //        if (arr[j] >= arr[j + 1])                 // Ascending arr[j] <= arr[j+1]
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}

            //Sort and array in descending order
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (arr[i] > arr[j])              
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine($"sorted array {string.Join(',',arr)}");
            return arr[largestposition-1];
        }
    }
}
