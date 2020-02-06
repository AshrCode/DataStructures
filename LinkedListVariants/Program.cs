using System;

namespace LinkedListVariants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is how Linked List data structure works.");

            // One of adding multiple nodes
            //Node headNode = new Node(12);
            //headNode.NextNode = new Node(11);
            //headNode.NextNode.NextNode = new Node(13);
            //headNode.NextNode.NextNode.NextNode = new Node(7);

            // Recursive way of adding node to the end of the chain
            Node headNode = new Node(6);
            headNode.AddToEnd(17);
            headNode.AddToEnd(27);
            headNode.AddToEnd(13);

            headNode.Print();


            // To hold the output
            Console.Read();
        }
    }
}
