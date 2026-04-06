namespace Binary_Search
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length -1;
            while (left <= right) 
            {
                int middle = left + (right - left) / 2;
                if (target == nums[middle])
                {
                    return middle;
                }
                else if(target > nums[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }

            }
            return -1;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            int[] intput1 = [-1, 0, 2, 4, 6, 8];
            var result =solution.Search(intput1, 4);
            Console.WriteLine(result);
        }
    }
}
