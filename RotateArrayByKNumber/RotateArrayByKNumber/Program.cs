using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace RotateArrayByKNumber
{
    /* write a Function to right-rotate an array by `k` positions
     *  for Example 
     *  given an array = { 1, 2, 3, 4, 5, 6, 7 } three times rotate means K =3 
     *  output = { 5, 6, 7, 1, 2, 3,4}
     *  that means after first rotate = { 7, 1, 2, 3, 4, 5, 6}
     *  after second rotate = { 6,7, 1, 2, 3, 4, 5}
     *  after third rotate = { 7, 1, 2, 3, 4, 5, 6}
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = new[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] Result = RotateArrayByKNumber(inputs,2);

            for (int i = 0; i < Result.Length; i++)
            {
                Console.Write(Result[i]);
            }

            Console.WriteLine(" \n Second Solution ----------------");

            
            inputs = new[] { 1, 2, 3, 4, 5, 6, 7 };
            int[ ] Result2 = RotateArrayByK(inputs, 2);

            for (int n = 0; n < Result2.Length; n++)
            {
                Console.Write(Result2[n]);
            }

            Console.WriteLine(" \n -----------------------------");
        }


        public static int [] RotateArrayByKNumber(int[] nums, int k)
        {
            int temp = 0;
            for(int i=0; i < k; i++)
            {
                for(int j=0; j < nums.Length -1; j++)
                {
                    temp = nums[j + 1];
                    nums[j+1] = nums[0];
                    nums[0] = temp;
                }
            }

            return nums;
        }

        public static int[] RotateArrayByK(int[] nums, int k)
        {
            int size = nums.Length;
            k = size - k;
            int[] firstMid = nums.Take(k).ToArray();
            int[] secondtMid = nums.Skip(k).ToArray();

            int[] result = secondtMid.Concat(firstMid).ToArray();
            return result;
        }
    }
}
