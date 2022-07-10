using System;

namespace MinSizeSubArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = [2,3,1,2,4,3];
            int s=7;
            Console.WriteLine(MinSubArrayLen(s,nums));
            Console.ReadLine();
        }

        public static int MinSubArrayLen(int s, int[] nums)
        {
            int result = Int32.MaxValue;

            int left=0;
            int val_sum = 0;

            for(int i=0; i < nums.Length); i++) {
                val_sum = nums[i];

                while(sum>=s) {
                    result = Math.Min(result, i+1-left);
                    val_sum -= nums[left];
                    left++;
                }
            }

            return (result != Int32.MaxValue) ? result : 0;
        }
    }
}
