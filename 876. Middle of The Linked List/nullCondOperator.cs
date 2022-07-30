public ListNode MiddleNode(ListNode head)
{
    var curr = head;
    var mid = head;

    /**
     * Using the Null-Conditional Operators ?. and ?[]
     * If curr evaluates to null, 
     * the result of curr?.next will be null.
     * the result of curr?[i] will be null.
     *
     * Else, it is the same as curr.next or curr[i]
     * 
     * In this situation, curr might be null because of line 2 in the while's body.
     * Hence, we use ?. to avoid a NullReferenceException when the condition is checked again.
     */
    while (curr?.next != null) // while current is not null AND also has a next,
    {
        mid = mid.next;
        curr = curr.next.next;
    }

    return mid;
}
