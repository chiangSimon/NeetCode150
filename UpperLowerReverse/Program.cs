using System.Net.Http.Headers;

namespace UpperLowerReverse
{

    public class Solution
    {
        public string UpperLowerRserve(string str) 
        {
            //如果要對逐一字元做操作要轉換成CharArray
            var chars = str.ToCharArray();
            for (int i = 0; str.Length > i ;  i++) 
            {
                if (char.IsUpper(chars[i])) 
                {
                    chars[i] = char.ToLower(chars[i]);
                }
                else 
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
            }

            return string.Concat(chars);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            var result = solution.UpperLowerRserve("HelloWorld");
            Console.WriteLine(result);
        }
    }
}
