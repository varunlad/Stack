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
        /// <summary>
        /// Displaying the top element
        /// UC2
        /// </summary>
        public void Peek()
        {
            ///Checking if top element is null
            ///otherwise printing the top element
            if (this.top == null)
            {
                Console.WriteLine("no element present to Peek");
                return;
            }
            Console.WriteLine("Top most element " + this.top.data);
        }

        /// <summary>
        /// Displaying and Deleting the top element
        /// UC2
        /// </summary>
        public void Pop()
        {
            ///Checking if top element is null
            ///otherwise printing the top element and deleting it also
            if (this.top == null)
            {
                Console.WriteLine("no element present to Pop");
                return;
            }
            Console.WriteLine("The element poped is " + this.top.data);
            int deleteNode = this.top.data;
            Peek();
            this.top = this.top.next;
            Console.WriteLine("Deleted element is {0}", deleteNode);
        }

        public void IsEmpty()
        {
            while (this.top != null)
            {
                Pop();
            }
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
