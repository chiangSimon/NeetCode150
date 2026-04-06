namespace Valid_Anagram
{

    public class Solution
    {
        /// <summary>
        /// 比對是否相同字元組成
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram1(string s, string t)
        {
            char[] charS = s.ToCharArray();
            Array.Sort(charS);

            char[] charT = t.ToCharArray();
            Array.Sort(charT);

            if (charS.SequenceEqual(charT)) { return true; }
            return false;
        }

        public bool IsAnagram2(string s, string t)
        {
            var sortedS = s.OrderBy(x => x);
            var sortedT = t.OrderBy(x => x);

            return sortedS.SequenceEqual(sortedT);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();

            bool Q1result_1 = solution.IsAnagram1("apple", "ppale");
            bool Q2result_1 = solution.IsAnagram1("apple", "pale");

            Console.WriteLine($"Q1{Q1result_1}");
            Console.WriteLine($"Q2{Q2result_1}");


            bool Q1result_2 = solution.IsAnagram2("apple", "ppale");
            bool Q2result_2 = solution.IsAnagram2("apple", "pale");

            Console.WriteLine($"Q1{Q1result_2}");
            Console.WriteLine($"Q2{Q2result_2}");
        }
    }
}
