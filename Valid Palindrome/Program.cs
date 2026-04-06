namespace Valid_Palindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            string cleanValue = string.Concat(s.Where(x => char.IsLetterOrDigit(x))).ToLower();
            string opsiteValue = string.Empty;
            for(int i = cleanValue.Length -1 ; 0 <= i ; i--)
            {
                //opsiteValue = string.Join(opsiteValue, trimedValue[i]);
                opsiteValue = opsiteValue + cleanValue[i];
            }

            return cleanValue == opsiteValue;
        }

        public bool IsPalindrome2(string s)
        {
            string cleanValue = string.Concat(s.Where(x => char.IsLetterOrDigit(x))).ToLower();
            char[] temp1 = cleanValue.ToCharArray();
            char[] temp2 = cleanValue.Reverse().ToArray();
            

            return temp1 == temp2;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            bool Q1 = solution.IsPalindrome("Was it a car or a cat I saw?");
            Console.WriteLine($"Q1：{Q1}");

            bool Q2 = solution.IsPalindrome("Was it a car or a cat I saw?1");
            Console.WriteLine($"Q2：{Q2}");
        }
    }
}
