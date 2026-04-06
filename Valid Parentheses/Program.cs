namespace Valid_Parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            while (s.Contains("{}") || s.Contains("()") || s.Contains("[]")) 
            {
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
                s = s.Replace("()", "");
            }

            return s == string.Empty;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            var input1 = "([{}])";
            var result1 = solution.IsValid(input1);
            Console.WriteLine($"Q1{result1}");

            var input2 = "[(])";
            var result2 = solution.IsValid(input2);
            Console.WriteLine($"Q2{result2}");

        }
    }
}
