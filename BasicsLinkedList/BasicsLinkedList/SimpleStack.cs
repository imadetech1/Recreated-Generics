/* This is a simple implementation of a stack data structure in C#. The class SimpleStack<S>
 * is derived from the class Node<S>. The class has three methods: Push, Pop, and Peek.  */
namespace BasicsLinkedList
{
    internal class SimpleStack<S> : Node<S>
    {
        private int stackSize = 0;
        public void Push(S value)
        /* The Push method adds an element to the top of the stack.
         * It creates a new node with the value passed as an argument and sets the head of the stack to this new node.
         * If there is already a head node, it sets the next pointer of the new node to the current head node and
         * then sets the head pointer to the new node. */
        {
            var node = new Node<S>() { value = value };
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
            stackSize++;
        }

        public S Pop()
        /*The Pop method removes and returns the top element of the stack.
         * It first checks if there is a head node. If there is no head node,
         * it throws an exception. Otherwise, it returns the value of the head node and
         * sets the head pointer to the next node in the stack. */
        {
            if (head == null)
            {
                throw new InvalidOperationException("Empty stack");
            }
            var nodeValue = head.value;
            head = head.next;
            stackSize--;
            return nodeValue;
        }

        public S Peek()
        /*The Peek method returns the value of the top element of the stack without removing it.
         * It first checks if there is a head node. If there is no head node, 
         * it throws an exception. Otherwise, it returns the value of the head node. */
        {
            if (head == null)
            {
                throw new InvalidOperationException("Empty stack");
            }
            return head.value;
        }

        /* IsEmpty and Size. The IsEmpty method returns true if there is no head node in the stack.
         * The Size method returns the number of nodes in the stack. */
        public bool IsEmpty() { return head == null; }

        public int Size() { return stackSize; }
    }
}
