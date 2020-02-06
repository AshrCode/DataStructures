using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListVariants
{
    public class Node
    {
        public Node NextNode { get; set; }

        public int Data { get; set; }

        public Node(int Data)
        {
            this.Data = Data;
            this.NextNode = null;
        }

        public void Print()
        {
            Console.Write("|" + this.Data + "|-> ");

            if (this.NextNode != null)
            {
                NextNode.Print();
            }
        }

        public void AddToEnd(int Data)
        {
            if(NextNode == null)
            {
                NextNode = new Node(Data);
            }
            else
            {
                NextNode.AddToEnd(Data);
            }
        }
    }
}
