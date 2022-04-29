// A simple C# program to introduce a linked list

using System;

public class LinkedList{
    Node head;  // head of list

    // Linked list Node.
    // This inner class is made static so that main() can access it

    public class Node{
        public int data;
        public Node next;

        // Constructor
        public Node(int d)
        {
            this.data = d;
            this.next = null;
        }
    }

    // Method to create a simple linked list with 3 nodes
    public static void Main(String[] args)
    {
        // Start with the empty list.
        LinkedList linked_list = new LinkedList();

        // Three nodes have been allocated dynamically.
        linked_list.head = new Node(1);      // 1st. node

        Node second = new Node(2);    // 2nd. node
        Node third = new Node(3);     // 3rd. node

        // Link 1st. node with 2nd. node
        linked_list.head.next = second;

        // Link 2nd. node with 3rd. node
        second.next = third;
        
    }
}

/* Note :
    -   Line 30 ~ 33 : Three nodes have been allocated dynamically.
        We have references to these three blocks as head, second and third nodes.

        list.head       second          third
            |               |               |
            |               |               |
            +---+------+    +---+------+    +---+------+
            | 1 | null |    | 2 | null |    | 3 | null |
            +---|------+    +---+------+    +---+-------

    -   Line 36 : Link head node with second node

        list.head       second          third
            |               |               |
            |               |               |
            +---+------+    +---+------+    +---+------+
            | 1 | null |--->| 2 | null |    | 3 | null |
            +---|------+    +---+------+    +---+-------

    -   Line 39 : Link second node with third node

        list.head       second          third
            |               |               |
            |               |               |
            +---+------+    +---+------+    +---+------+
            | 1 | null |--->| 2 | null |--->| 3 | null |
            +---|------+    +---+------+    +---+-------
*/