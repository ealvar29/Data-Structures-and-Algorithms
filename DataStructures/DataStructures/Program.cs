// See https://aka.ms/new-console-template for more information

// Data Structure #1 - Stack
/* 
 Stack = LIFO Data Stucture. Last-in First-out
This stores objects into a sort of vertical tower.
.push() to add to the top of the stack
.pop() to remove from the top
 */

/*Stack<String> stack = new Stack<String>();
stack.Push("Minecraft");
stack.Push("Skyrim");
stack.Push("Doom");*/

// pop() - removes the item from the top of the stack
// Pop() can be used to store the top item to variable
//string favGame = stack.Pop();
// .Peek() - returns the object from the top without removing it
/*Console.WriteLine(stack.Peek());*/
/*
 Uses of stacks?
1. Undo / Redo features in text editors
2. moving back / forward through the browser history
3. backtracking algorithms (maze, file directories)
4. calling functions (call stack)
 */
/*------------------------------------------------------------------------*/


// Data Structure #2 - Queue
/*
 * First Come First Serve! 
 Queue = FIFO data structure. First in First out
A collection designed for holding elements prior to processing
linear data structure

Add = Enqueue()
Remove = Dequeue()
 */


/*Queue<String> queue = new Queue<String>();
queue.Enqueue("Karen");
queue.Enqueue("Harold");
queue.Enqueue("Chad");
//Dequeue will remove the first object in the Queue - AKA Karen
//Dequeue will not throw an exception
queue.Dequeue();
foreach (var item in queue)
{
    Console.WriteLine(item);
}*/

/*
 Where are queues useful?
1. Keyboard buffer (Letters should appear on the screen in the order they're pressed)
2. Printer Queue (Print jobs should be completed in order)
3. Used in LinkedLists, priority Queues, breadth-first search
 */

/*------------------------------------------------------------------------*/

// Data Structure #3 - Priority Queue
/* First Come First Serve! 
 Queue = FIFO data structure. First in First out
A FIFO data structure that serves elements with the highest priorities first before elements
with lower priority.

Add = Enqueue()
Remove = Dequeue()
 */

/*PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
pq.Enqueue(11,3);
pq.Enqueue(22,2);
pq.Enqueue(33,1);
// second arguement is for assigning where in the queue they go.
Console.WriteLine(pq);*/



/*------------------------------------------------------------------------*/
// Data Structure #4 - Priority Queue
/*
 LinkedList = stores Nodes in 2 parts (data + address)
 Nodes are in non-consecutive memory locations
 Elements are linekd using pointers
                            Singly Linked List
     Node                   Node                    Node
[Data | address]    -> [Data | address]     -> [Data | address]
 
 Advantages?
1. Dynamic Data Structure (allocates needed memory while running)
2. Insertion and Deletion of Nodes is easy. 0(1)
3. No / Low memory waste
 

 Disadvantages?
1. Greater memory usage (additional pointer)
2. No Random access of elements (no index of [i])
3. Accessing / searching elements is more time consuming. O(n)

 Uses?
1. Implement Stacks / Queues
2. 
3. 
 */

/*// Create a new LinkedList of strings
LinkedList<string> linkedList = new LinkedList<string>();

// Add elements to the LinkedList
linkedList.AddLast("Apple");
linkedList.AddLast("Banana");
linkedList.AddLast("Orange");


//Example 2: Removing Elements from LinkedList
// Remove a specific element
linkedList.Remove("Banana");

// Find a specific element
LinkedListNode<string> node = linkedList.Find("Apple");

// Insert a new element after the found node
linkedList.AddAfter(node, "Banana");

// Display elements in the LinkedList
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}*/


/*------------------------------------------------------------------------*/
// Data Structure #6 - Static Array / Dynamic Array / ArrayList




