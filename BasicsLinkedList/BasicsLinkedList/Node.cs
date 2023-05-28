namespace BasicsLinkedList


/*  A class called Node that is used in a linked list. A linked list is a data structure that consists of a sequence of nodes, 
 *  where each node contains an object and a reference to the next node in the list. The Node class has four fields: value,
 *  next, head and tail. The value field stores the object that the node represents. The next field is a reference to
 *  the next node in the list. The head field is a reference to the first node in the list. The tail field is a reference to
 *  the last node in the list. */
{
    internal class Node<N>
    {
        public N value;
        public Node<N> next;
        public Node<N> head;
        public Node<N> tail;
    }
}
