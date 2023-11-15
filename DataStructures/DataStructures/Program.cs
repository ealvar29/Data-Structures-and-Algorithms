using DataStructures;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
// Data Structure #6 - Static Array / Dynamic Array / ArrayList - Didnt finish


/*DynamicArray dynamicArray = new DynamicArray();
dynamicArray.Add("A");
dynamicArray.Add("B");
dynamicArray.Add("C");
foreach (var item in dynamicArray)
{
Console.WriteLine(item);

}*/

/*------------------------------------------------------------------------*/

// Big O Notation
/*
 How code slows as data grows.
Big O notation is notation used to describe the performance of an algorythm
as an amount of data increases.
 
O(1) = Constant time
- random access of an element in an array
- inserting at the beginning of linkedList

O(log n) = logarithmic time
- binary search

O(N) = linear time
- looping through elements in an array
- searching through a linkedlist

O(n log n) = quasilinear time
- quick sort
- merge sort
- head sort

O(n^2) = quadratic time
- insertion sort
- selection sort
- bubblesort

O(n!) = factorial time
- traveling salesman problem

 */

/*------------------------------------------------------------------------*/

// Algorithm #1 - linear search

/*
 
Linear search = Iterate through a collection one element at a time

Runtime complexity: O(n)


Disadvatages:
-Slow for large data sets

Advantages:
-Fast for searches of small to medium data sets
-Does not need to be sorted
-Useful for data structures that do not have random access (Linked List)


 */

/*int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 3213, 44 };
int index = linearSearch(array1, 5);

if (index != -1)
    Console.WriteLine("Element found at " + index);
else
    Console.WriteLine("Element not found");


static int linearSearch(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            return i;
        }
    }
    return -1;
}*/

/*------------------------------------------------------------------------*/

// Algorithm #2 - biary search

/*
 Explanation: Divide and conquer strategy to
 efficiently find a target element in a sorted array.
 
 Search algorithm that finds the position of 
 a target value within a sorted array.
 
 Half of the array is eliminated during each "step".

 */

/*int[] ints = new int[100000];

int target = 77742;
for (int i = 0; i < ints.Length; i++)
{
    ints[i] = i;
}*/
// Array.BinarySearch is a built in method
/*int index = Array.BinarySearch(ints, target);
if (index == -1)
    Console.Write(target + " not found");
else 
    Console.Write("Element found at " +  index);*/

/*int index2 = BinarySearch(ints, target);

// Creating Binary search algorithm from scratch! 
int BinarySearch(int[] arr, int target)
{
    int low = 0;
    int high = arr.Length - 1;
    while (low <= high)
    {
        int middle = low + (high - low) / 2;
        int value = arr[middle];
        Console.WriteLine("Middle:" + value);
        if (value < target)
            low = middle + 1;
         else if (value > target)
            high = middle - 1;
        else return middle;
    }


    return -1; // target not found;
}*/

/*------------------------------------------------------------------------*/

// Algorithm #3 - Interpolation search

/*
    Interpolation Search = improvement over binary search.
    Best used for "uniformly" distributed "guesses"
    where a value might be based on calculated probe results
    If probe is incorrect, search area is narrowed and a new probe
    is construcucted.
    
    average case: O(log(log(n)))
    worse case: O(N) [values increase exponentially]
 */

/*int[] arr = { 1,2,4, 8, 16, 32, 64, 128, 256, 512, 1024 };

int index = interpolationSearch(arr, 256);
if (index != -1)
{
    Console.WriteLine("Element found at index: " + index);
}
else
    Console.WriteLine("Element not found");

int interpolationSearch(int[] arr, int target)
{
    int high = arr.Length - 1;
    int low = 0;

    while (target >= arr[low] && target <= arr[high] && low <= high)
    {
        int probe = low + (high - low) 
            * (target - arr[low]) 
            / (arr[high] - arr[low]);

        Console.WriteLine("probe:" + probe);
        if (arr[probe] == target)
            return probe;
        else if (arr[probe] < target)
            low = probe + 1;
        else high = probe - 1;
    }
    return -1;
}*/

/*------------------------------------------------------------------------*/

// Algorithm #4 - Bubble search

/*
    Bubble Sort = pairs of adjacent elements are compared and the elements
    are swapped if they are not in order.
    Quadratic time O(n^2)
    small data set = okay-ish
    large data set = terrible
 
 */

/*int[] arr = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
bubbleSort(arr);
int[] bubbleSort(int[] arr)
{
    int[] sorted = new int[arr.Length];
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    return arr;
}*/

/*------------------------------------------------------------------------*/

// Algorithm #5 - Selection Sort

/*
    Selection Sort = search through an array and keep track 
    of the min. value during each iteration. At the end of each iteration,
    we swap variables. 
    
    Quadratic time O(N^2)
    small data set = okay;
    large data set = terrible
 */

/*int[] arr = { 8, 2, 6, 4, 3, 1, 9, 7, 0, 1, 5 };
selectionSort(arr);
Console.WriteLine(arr);
void selectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            // For sort algorithm, if you want descending, swap > to <
            if (arr[min] > arr[j])
            {
                min = j;
            }
        }
        int temp = arr[i];
        arr[i] = arr[min];
        arr[min] = temp;
    }
}*/

/*------------------------------------------------------------------------*/

// Algorithm #6 - Insertion Sort

/*
    Insertion Sort = after comparing elements to the left
    shift elements to the right to make room to insert a value

    Quadratic time O(n^2)
    small data set = decent
    large data set = terrible

    less steps than bubble sort
    best case is O(n) compared to selection sort O(n^2)
 
 */

/*int[] arr = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
insertionSort(arr);

void insertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int temp = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] > temp)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = temp;  
    }
}*/