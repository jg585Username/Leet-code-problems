namespace LeetCodeProblems;

public class RemoveDupSortedList
{
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null)
            return head;

        ListNode current = head;

        while (current != null && current.next != null) {
            if (current.val == current.next.val) {
                current.next = current.next.next;
            } 
            else {
                current = current.next;
            }
        }

        return head;
    }
}
public class ListNode { 
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next; 
    }
}