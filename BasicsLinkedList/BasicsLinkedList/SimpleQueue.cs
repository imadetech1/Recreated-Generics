using System.Xml.Linq;

namespace BasicsLinkedList
{
    internal class SimpleQueue<Q> : Node<Q>
    {
/* The Enqueue method adds an element to the end of the queue.
If the queue is empty, it sets both the head and
tail to the new node.Otherwise, 
it sets the next node of the current tail to
 the new node and then sets the tail to the new node.*/

        private int queueSize = 0;
        public void Enqueue(Q value)
        {
            var node = new Node<Q> { value = value };

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            queueSize++;
        }

        public Q Dequeue()
            /* The Dequeue method removes and returns the first element in the queue.
             * If the queue is empty, it throws an exception. */
        {
            if (head == null)
            {
                throw new InvalidOperationException("Empty queue");
            }
            var nodeValue = head.value;
            head = head.next;
            queueSize--;
            return nodeValue;
        }

        /* The IsEmpty method returns true if the queue is empty.  */
        public bool IsEmpty() { return head == null; }

        /* The Size method returns the number of elements in the queue.  */
        public int Size() { return queueSize; }

    }
}
