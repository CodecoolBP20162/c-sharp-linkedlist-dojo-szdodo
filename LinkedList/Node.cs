using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public object Data;
        public Node Next;

        public Node()
        {
            Data = null;
            Next = null;
        }

        public Node(object Data)
        {
            this.Data = Data;
            Next = null;
        }

        public Boolean hasNext()
        {
            if (this.Next is null)
                return false;
            else
                return true;
        }
    }
}
