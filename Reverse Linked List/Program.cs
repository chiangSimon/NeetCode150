using System;

namespace Reverse_Linked_List
{
    // 1. 定義盒子規格 (ListNode)
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // --- 準備階段 ---
            // 2. 模擬 LeetCode 輸入：把 [0, 1, 2, 3] 變成 Linked List
            // 我們手動串起來：0 -> 1 -> 2 -> 3 -> null
            ListNode node3 = new ListNode(3);
            ListNode node2 = new ListNode(2, node3);
            ListNode node1 = new ListNode(1, node2);
            ListNode head = new ListNode(0, node1);

            Console.WriteLine("原本的順序：");
            PrintList(head);

            // --- 執行階段 ---
            // 3. 呼叫你的反轉邏輯
            Solution solution = new Solution();
            ListNode reversedHead = solution.ReverseList(head);

            // --- 結果階段 ---
            Console.WriteLine("\n反轉後的順序：");
            PrintList(reversedHead);
        }

        // 輔助方法：用來把整列火車印出來看
        static void PrintList(ListNode head)
        {
            ListNode curr = head;
            while (curr != null)
            {
                Console.Write(curr.val + (curr.next != null ? " -> " : " -> null"));
                curr = curr.next;
            }
            Console.WriteLine();
        }
    }

    // 你寫的 Solution 類別
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                ListNode nextNode = curr.next; // 記住後路
                curr.next = prev;            // 轉向
                prev = curr;                 // 挪移 prev
                curr = nextNode;             // 挪移 curr
            }
            return prev; // 回傳新車頭
        }
    }
}