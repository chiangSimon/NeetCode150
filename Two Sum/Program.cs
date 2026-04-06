using System.Security.Cryptography;

namespace Two_Sum
{
    /// <summary>
    /// 找到兩個值相加等於target的index位置
    /// </summary>
    public class Solution 
    {

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result= new int [2];

            for (int i =0; i < nums.Length; i++) 
            {
                int matchNum = target - nums[i];
                int matchIndex = Array.IndexOf(nums, matchNum);
                if (matchIndex != -1) 
                {
                    result[0] = i;
                    result[1] = matchIndex;
                }

            }
            return result;
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> keys = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int matchNum = target - nums[i];
                if (keys.ContainsKey(matchNum)) 
                {
                    result = [ i, keys[matchNum]];
                }
                else
                {
                    keys.Add(nums[i],i );
                }

            }
            return result;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();

            var result = solution.TwoSum([3, 4, 5, 6], 7);
            Console.WriteLine(result);
            Console.WriteLine($"1.結果：[{string.Join(", ", result)}]");


            var result2 = solution.TwoSum2([3, 4, 5, 6], 7);
            Console.WriteLine(result2);
            Console.WriteLine($"2.結果：[{string.Join(", ", result2)}]");
        }
    }
}
