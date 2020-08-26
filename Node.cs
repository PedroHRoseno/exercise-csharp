using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercícios
{
    class Node
    {
        public int Value;
        public Node Next = null;
        public Node(int value)
        {
            this.Value = value;
        }
    }
}
