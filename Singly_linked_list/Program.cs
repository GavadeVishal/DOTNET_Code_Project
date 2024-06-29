using System;

class Node
{
    public int Data; 
    public Node Next; 
    public Node(int data)
    {
        Data = data;
        Next = null; 
    }
}
class LinkedList
{
    private Node head;
    public void Add(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
    public void Traverse()
    {
        Node current = head;

        Console.Write("Linked List: ");
        while (current != null)
        {
            Console.Write($"{current.Data} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        list.Traverse();
    }
}
