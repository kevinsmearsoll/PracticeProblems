using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LeetCode24
    {
         
         
         public class ListNode
         { 
              public int val;
              public ListNode next;
              public ListNode(int x) { val = x; }
         }

        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) { return null; }
            if (head.next == null) { return head; }

            ListNode retNode = head.next;
            ListNode p1, p2, nextPairHead;
            nextPairHead = head;

            while (nextPairHead != null)
            {
                //Set up the current pair
                p1 = nextPairHead;
                p2 = p1.next;

                //Make sure the second item in the pair exists 
                if (p2 != null)
                {
                    //Set up for the next loop before swapping any nodes
                    nextPairHead = p2.next;

                    //Point the old second node to the first
                    p2.next = p1;

                    //Point the old first node to the next pair
                    if (nextPairHead != null)
                    {
                        if (nextPairHead.next != null)
                        {
                            p1.next = nextPairHead.next;
                        }
                        else
                        {
                            p1.next = nextPairHead;
                        }
                    }
                    else
                    {
                        p1.next = null;
                    }
                }
                else
                {
                    //If there is no second node in the pair, there's nothing to swap
                    nextPairHead = null;
                }
            }

            return retNode;
        }
    }
}
