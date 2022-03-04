using System.Collections.Generic;

namespace leetCodeExamples.LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int _data)
        {
            data = _data;
        }
    }

    public class LinkedList
    {
        private Node head;

        //Add
        public void Add(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;

            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = head.next;
                }

                current.next = new Node(data);

            }

        }

        public void PrePend(int data)
        {
            //Change the head or add a new head by replacing old head

            Node newHead = new Node(data);
            newHead.next = head;
            head = newHead;

        }

        //Delete Duplicates
        public void DeleteDuplicates(LinkedList _listWithDuplicates)
        {
            Dictionary<int, int> newLink = new Dictionary<int, int>();  //Will contain all unique data

            int index = 0;


            Node current = _listWithDuplicates.head;

            if (current == null) return;

            while (current.next != null)
            {

                if (!newLink.ContainsKey(current.data))
                {
                    newLink.Add(current.data, index);
                    ++index;
                }
                current = _listWithDuplicates.head.next;

            }
        }

        //Update
    }
}
