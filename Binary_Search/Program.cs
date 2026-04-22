namespace Binary_Search
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length -1 ;
            while (right >= left) 
            {
                int middle = (left + right) / 2;
                if (target > nums[middle]) 
                {
                    left = middle  + 1;
                }
                else if(target < nums[middle]) 
                {
                    right = middle - 1;
                }
                else 
                {
                    return middle;
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
            var result = solution.Search(intput1, 8);
            Console.WriteLine(result);
        }
    }
}
