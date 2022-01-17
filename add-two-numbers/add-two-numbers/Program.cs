// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Test Values
//ListNode l1 = new(2, new(4, new(3, null)));
//ListNode l2 = new(5, new(6, new(4, null)));

ListNode l1 = new(3, new(7));
ListNode l2 = new(9, new(2));

//ListNode l1 = new(5);
//ListNode l2 = new(5);

Solution solution = new Solution();

//Results
Console.WriteLine(solution.AddTwoNumbers(l1, l2));

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        Queue<ListNode> qu = new Queue<ListNode>();
        ListNode result = new ListNode();

        while (l1 != null || l2 != null)
        {
            var sum = 0;
            int carry = 0;
            if (l1 == null && l2 != null)
            {
                sum = result.val + l2.val;
                if (sum >= 10)
                {
                    result.val = sum - 10;
                    carry = 1;
                }
                else
                {
                    result.val = sum;
                }
                l2 = l2.next;

                if (l2 == null && carry < 1)
                    result.next = null;
                else
                    result.next = new ListNode(carry);

                qu.Enqueue(result);
                result = result.next;
                continue;
            }
            if (l1 != null && l2 == null)
            {
                sum = result.val + l1.val;
                if (sum >= 10)
                {
                    result.val = sum - 10;
                    carry = 1;
                }
                else
                {
                    result.val = sum;
                }
                l1 = l1.next;
                if (l1 == null && carry < 1)
                    result.next = null;
                else
                    result.next = new ListNode(carry);
                qu.Enqueue(result);
                result = result.next;
                continue;
            }
            sum = l1.val + l2.val;
            l1 = l1.next;
            l2 = l2.next;
            if (sum + result.val >= 10)
            {
                result.val = result.val + sum - 10;
                carry = 1;
            }
            else
            {
                result.val += sum;
            }
            if (l1 == null && l2 == null && carry < 1)
                result.next = null;
            else
                result.next = new ListNode(carry);
            qu.Enqueue(result);
            result = result.next;

        }
        result = null;
        return qu.Dequeue();
    }
}

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