using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class LinkListStack
    {
        public Node top;
        public void Push(int newData)
        {
            ///creating a link between newnode and where top is pointing
            ///then pointing top towards the new node 
            ///new node is inserted on the top 
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top; // newnode will hold the address of top element
            }
            this.top = newNode;// top will point to new element
            Console.WriteLine("New node {0} is added", newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("Displaying Nodes ");
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + "");
                    temp = temp.next;
                }
                //Console.Write(" " + temp.data);
            }

        }
    }
}
