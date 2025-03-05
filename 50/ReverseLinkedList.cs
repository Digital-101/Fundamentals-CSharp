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
public class LinkedListOperations
{
    public static ListNode ReverseListRecursive(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return head; // Base case: the list is empty or has one node
        }

        ListNode rest = ReverseListRecursive(head.Next); // Reverse the rest of the list
        head.Next.Next = head; // Make the next node point to the current node
        head.Next = null; // Set the current node's next to null (new tail)

        return rest; // Return the new head of the reversed list
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
        // Creating Linked List: 1 → 2 → 3 → 4 → 5
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3,
                      new ListNode(4, new ListNode(5)))));

        Console.WriteLine("Original Linked List:");
        PrintList(head);

        // Reverse the linked list recursively
        head = ReverseListRecursive(head);

        Console.WriteLine("Reversed Linked List:");
        PrintList(head);
    }
}
