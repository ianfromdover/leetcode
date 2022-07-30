/**
 * Definition for singly-linked list.
 */
public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) 
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution 
{
    public ListNode MiddleNode(ListNode head) 
    {
        ListNode curr = head;
        ListNode mid = head;
        int i = 1;

        while (curr.next != null)
        {
            if (i % 2 != 0)
            {
                mid = mid.next;
            }
            curr = curr.next;
            i++;
        }

        return mid;
    }
}
