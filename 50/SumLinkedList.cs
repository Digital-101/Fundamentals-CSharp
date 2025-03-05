using System;
using System.Collections.Generic;

public class ListNode
{
    public int Val;
    public ListNode Next;
    public ListNode(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}

public class LinkedListSum
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        // Push all nodes of l1 into stack1
        while (l1 != null)
        {
            stack1.Push(l1.Val);
            l1 = l1.Next;
        }

        // Push all nodes of l2 into stack2
        while (l2 != null)
        {
            stack2.Push(l2.Val);
            l2 = l2.Next;
        }

        ListNode head = null;
        int carry = 0;

        // Process stacks until both are empty
        while (stack1.Count > 0 || stack2.Count > 0 || carry > 0)
        {
            int sum = carry;
            if (stack1.Count > 0) sum += stack1.Pop();
            if (stack2.Count > 0) sum += stack2.Pop();

            carry = sum / 10;
            ListNode newNode = new ListNode(sum % 10);

            // Insert new node at the front of the result list
            newNode.Next = head;
            head = newNode;
        }

        return head;
    }

    // Helper function to print linked list
    public static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.Val + " → ");
            node = node.Next;
        }
        Console.WriteLine("NULL");
    }

    public static void Main()
    {
        // Creating List 1: 7 → 2 → 4 → 3
        ListNode l1 = new ListNode(7, new ListNode(2, new ListNode(4, new ListNode(3))));

        // Creating List 2: 5 → 6 → 4
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        Console.WriteLine("List 1:");
        PrintList(l1);
        Console.WriteLine("List 2:");
        PrintList(l2);

        // Add two numbers
        ListNode result = AddTwoNumbers(l1, l2);

        Console.WriteLine("Sum:");
        PrintList(result);
    }
}
