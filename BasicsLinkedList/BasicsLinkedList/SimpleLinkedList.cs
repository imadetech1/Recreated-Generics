
namespace BasicsLinkedList
{
 /*The class SimpleLinkedList<M> is derived from the Node<M> class. It has four methods: Add, Remove, Check, and Index. */
    internal class SimpleLinkedList<M> : Node<M>
    {
        private int listSize;


        public int Add(M value)  // The Add method adds a new node to the end of the list.
        {
            var node = new Node<M> { value = value };
            if (head == null)
            {
                head = node;
            }
            else
            {
                var currentNode = head;
                while (!(currentNode.next == null))
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = node;
            }
            listSize++;
            return listSize;
        }

        public bool Remove(M value) // The Remove method removes the first occurrence of a specified value from the list
        {
            if (head == null)
            { return false; }
            if (head.value.Equals(value))
            {
                head = head.next;
                listSize--;
                return true;
            }
            var currentNode = head;
            while (!(currentNode.next == null))
            {
                if (currentNode.next.value.Equals(value))
                {
                    currentNode = currentNode.next;
                    listSize--;
                    return true;
                }
                currentNode = currentNode.next;
            }
            return false;
        }

        public bool Check(M value)   // The Check method checks if a specified value is in the list.
        {
            var currentNode = head;
            while (!(currentNode == null))
            {
                if (currentNode.value.Equals(value))
                {
                    return true;
                }
                currentNode = currentNode.next;
            }
            return false;
        }

        public int Index(M value) // The Index method returns the index of the first occurrence of a specified value in the list.
        {
            var nodeIndex = 0; var currentNode = head;
            while (!(currentNode == null))
            {
                if (currentNode.value.Equals(value))
                {
                    return nodeIndex;
                }
                nodeIndex++;
                currentNode = currentNode.next;
            }
            return -1;
        }

        public int Count() { return listSize; }

    }
}
