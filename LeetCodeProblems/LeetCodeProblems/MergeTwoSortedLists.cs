namespace LeetCodeProblems;

public class MergeTwoSortedLists
{
    public class ListNode { 
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) { 
            this.val = val;
            this.next = next;
        }
    }
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode temp = new ListNode(-1);
        ListNode current = temp;
        for (; list1 != null && list2 != null; current = current.next){
            if (list1.val <= list2.val){
                current.next = list1;
                list1 = list1.next;
            }
            
            else {
                current.next = list2;
                list2 = list2.next;
            }
        }

        if (list1 != null){
            current.next = list1;
        }

        else{
            current.next = list2;
        }

        return temp.next;
    }



}