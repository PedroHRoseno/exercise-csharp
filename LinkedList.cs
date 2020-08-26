using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercícios
{
    class LinkedList
    {
        public Node Head = null;
        public void Append(int value)
        {

            if (this.Head != null)
            {
                Node pointer = this.Head;
                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer.Next = new Node(value);
            }
            else
            {
                this.Head = new Node(value);
            }
        }
        public void RemoveByTheEnd()
        {
            if (this.Head != null)
            {
                Node pointer = this.Head;
                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer = null;
            }

        }

        public string printList()
        {
            string numbersList = "";
            Node pointer = this.Head;
            while (pointer.Next != null)
            {
                numbersList += pointer.Value.ToString() + ", ";
                pointer = pointer.Next;
            }

            return numbersList;
        }

    }
}
