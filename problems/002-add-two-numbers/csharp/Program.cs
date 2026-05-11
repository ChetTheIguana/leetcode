using System;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        // Wulfric: write your solution here
        return null;
    }
}

class Program
{
    static ListNode BuildList(int[] vals)
    {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        foreach (int v in vals)
        {
            curr.next = new ListNode(v);
            curr = curr.next;
        }
        return dummy.next!;
    }

    static void PrintList(ListNode? head)
    {
        Console.Write("[");
        while (head != null)
        {
            Console.Write(head.val);
            if (head.next != null) Console.Write(",");
            head = head.next;
        }
        Console.WriteLine("]");
    }

    static void Main()
    {
        var sol = new Solution();

        // Example 1: expected [7,0,8]
        var l1 = BuildList([2, 4, 3]);
        var l2 = BuildList([5, 6, 4]);
        Console.Write("Example 1: ");
        PrintList(sol.AddTwoNumbers(l1, l2));

        // Example 2: expected [0]
        l1 = BuildList([0]);
        l2 = BuildList([0]);
        Console.Write("Example 2: ");
        PrintList(sol.AddTwoNumbers(l1, l2));

        // Example 3: expected [8,9,9,9,0,0,0,1]
        l1 = BuildList([9, 9, 9, 9, 9, 9, 9]);
        l2 = BuildList([9, 9, 9, 9]);
        Console.Write("Example 3: ");
        PrintList(sol.AddTwoNumbers(l1, l2));
    }
}
