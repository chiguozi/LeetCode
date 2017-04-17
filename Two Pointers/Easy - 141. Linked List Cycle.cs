Given a linked list, determine if it has a cycle in it.

Follow up:
Can you solve it without using extra space?



/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
//两个指针 fast slow  每次fast多移动一格
//如果 fast 与 slow 有交集表示有环，如果fast为空 表示没有环
public class Solution 
{
    public bool HasCycle(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;
        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if(fast == slow)
                return true;
        }
        return false;
    }
}


//使用HashTable
public boolean hasCycle(ListNode head)
 {
    Set<ListNode> nodesSeen = new HashSet<>();
    while (head != null) 
	{
        if (nodesSeen.contains(head)) 
		{
            return true;
        } else 
		{
            nodesSeen.add(head);
        }
        head = head.next;
    }
    return false;
}