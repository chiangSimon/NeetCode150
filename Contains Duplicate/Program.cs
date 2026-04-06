namespace Contains_Duplicate
{
    /// <summary>
    /// 比對重複
    /// </summary>
    public class Solution 
    {
        public bool HasDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// hashset用來比對有沒有重複值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool HasDuplicate2(int[] nums)
        {
            HashSet<int> existNum = new HashSet<int>();
            foreach(int num in nums)
            {
                if (existNum.Contains(num)) 
                {
                    return true;
                }
                existNum.Add(num);

            }
            return false;

        }

    }




    internal class Program
    {

        static void Main(string[] args)
        {
            Solution solution = new();
            bool q1 = solution.HasDuplicate([1,2,3,4,5,6,7,7]);
            Console.WriteLine($"q1是否有重複!{q1}");
            bool q2 = solution.HasDuplicate([1, 2, 3, 4, 5, 6, 7]);
            Console.WriteLine($"q1是否有重複!{q2}");
        }
    }
}
