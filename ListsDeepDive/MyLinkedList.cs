/*
    ========================================================================

    Notes:
        -   Unlike a normal list whose size is static an linked lists size¨
            uses nodes to easely move the links arround to easely resize.

            Normal list: 
                [1][2][3][4][5]
                To change this we have to override the entire list.
                [1][2][3][5][4]

            Linked List:
                (1) --> (2) --> (3) --> (4) --> (5) --> null
                here we can just change the links ie.
                (1) & (2) --> (4) --> (3) --> (5) --> null

    ========================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListsDeepDive {

    class Node {
        public int data;
        public Node next;
    }

    public class MyLinkedList {
        private Node _head = null;
        private int count;                      // Used if we want to keep track of the lists size.
        public int Count {
            get { return count; }
        }

        public void Add(int item) {
            Node newNode = new Node();
            newNode.data = item;
            if(_head == null) {
                _head = newNode;
                return;
            }

            Node currentNode;
            for (currentNode = _head; currentNode.next != null; currentNode = currentNode.next) {}      // We don't do anything since we want to reach the end of our list.

            currentNode.next = newNode;
            count++;
        }

        public void Remove(int item) {
            if(_head.data == item) {
                _head = _head.next;
                return;
            }

            Node currentNode;
            for (currentNode = _head; currentNode.next.data != item; currentNode = currentNode.next) {}      // We don't do anything since we want to reach the end of our list.

            currentNode.next = currentNode.next.next;
            count--;
        }
        
        public void Print() {
            Node currentNode = _head;
            for (;currentNode != null; currentNode.next = currentNode) {
                Console.WriteLine(currentNode.data);
            }
        }
    }
}