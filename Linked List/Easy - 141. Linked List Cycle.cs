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
//����ָ�� fast slow  ÿ��fast���ƶ�һ��
//��� fast �� slow �н�����ʾ�л������fastΪ�� ��ʾû�л�
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


//ʹ��HashTable
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