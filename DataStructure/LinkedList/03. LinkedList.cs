// Linked List Traversal

using System;

public class LinkedList
{

    Node head;  // head of list

    /*  Linked list Node. This inner class is made static
        so that main() can access it */
    public class Node
    {
        public int data;
        public Node next;

        // Constructor
        public Node(int d)
        {
            this.data = d;
            this.next = null;
        }
    }

    // Prints contents of linked list starting from head
    public void printList()
    {
        Node linked_list = head;
        while (linked_list != null)
        {
            Console.Write(linked_list.data + " ");
            linked_list = linked_list.next;  // change to next node
        }
    }

    // Method to create a simple linked list with 3 nodes
    public static void Main(String[] args)
    {
        // Start with the empty list
        LinkedList linked_list = new LinkedList();

        // Create 3 nodes
        linked_list.head = new Node(1);
        Node second = new Node(2);
        Node third = new Node(3);

        // Link nodes
        linked_list.head.next = second; // link head node with second node
        second.next = third;            // link second node with third node

        // Print linked_list contents
        linked_list.printList();
    }
}

/* Node:

    -   Output : 

        1   2   3

*/