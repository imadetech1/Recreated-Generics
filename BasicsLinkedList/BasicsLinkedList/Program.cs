namespace BasicsLinkedList
{

    public class Program
    {
        public static void Main(string[] args)
        {
            /* The SimpleLinkedList class is a singly linked list implementation that provides methods for adding and
             * removing elements from the list. The Add method adds an element to the end of the list, while the
             * Remove method removes the first occurrence of an element from the list. */

 /* In this code, we create instances of each class and add some elements to them.
 * We then call their respective methods to remove or pop elements from them. */

            var list = new SimpleLinkedList<string>();
            list.Add("Orange");
            list.Add("Apple");
            Console.WriteLine(list.Remove("Apple"));


            /*  The SimpleStack class is a stack implementation that provides methods for adding and removing elements from
             *  the stack. The Push method adds an element to the top of the stack,
             *  while the Pop method removes and returns the top element from the stack.*/
            var stack = new SimpleStack<string>();
            stack.Push("Orange");
            stack.Push("Apple");
            Console.WriteLine(stack.Pop());


            /* The SimpleQueue class is a queue implementation that provides methods for adding and removing elements from
             * the queue. The Enqueue method adds an element to the end of the queue, while the Dequeue method removes and 
             * returns the first element from the queue.*/
            var queue = new SimpleQueue<string>();
            queue.Enqueue("Orange");
            queue.Enqueue("Apple");
            Console.WriteLine(queue.Dequeue());

        }
    }
}
