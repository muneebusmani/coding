/* 
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]
Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.

 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 using System;
using Microsoft.VisualBasic;
namespace two{
public class Solution {
    public static void Main(){
        LinkedList<int> l1= new LinkedList<int>();
        LinkedList<int> l2= new LinkedList<int>();
        LinkedList<int> l3=new LinkedList<int>();
        bool carry=false;
        int third=0;
        l1.AddLast(2);
        l1.AddLast(4);
        l1.AddLast(3);

        l2.AddLast(5);
        l2.AddLast(6);
        l2.AddLast(7);
        LinkedListNode<int> node = l1.First;
        foreach(int value in l3){
            if (value != l3.Last())
            {
            Console.Write($"{value},");
            }
        }

    }
    }
}