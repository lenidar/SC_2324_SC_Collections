using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SC_2324_SC_Collections
{
    /// <summary>
    /// This will code will primary discuss the most common collection types in programming
    /// 
    /// This demonstration will contain the following:
    /// Arrays and its variants
    /// Stacks
    /// Queues
    /// List
    /// Dictionaries
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays have definite length
            #region Array Section
            //int[] array1 = new int[] { }; // int[] array1 = {};

            //Console.WriteLine($"The current length of the array is {array1.Length}");

            //// in order to change the length of an array, we have to redeclare/reinitialize it
            //// this is the only way to change an array's length
            //// do take note that by changing the length of the array, all elements will revert back to default

            //array1 = new int[5]; // if you define the length, you do not need to put the {} at the end.

            //Console.WriteLine($"\nThe current length of the array is {array1.Length}");

            //array1[0] = 5;
            //array1[1] = 6;

            //foreach (int i in array1)
            //    Console.WriteLine(i);

            //array1 = new int[2];

            //Console.WriteLine($"\nThe current length of the array is {array1.Length}");

            //foreach (int i in array1)
            //    Console.WriteLine(i); 
            #endregion

            // Stacks and Queues
            #region Stack and Queue
            //Stack<int> stack1 = new Stack<int>();
            //Queue<int> queue1 = new Queue<int>();

            //Console.WriteLine($"The number of items in the stack is {stack1.Count}");
            //Console.WriteLine($"The number of items in the queue is {queue1.Count}");

            //for(int x = 0; x < 10; x++)
            //{
            //    stack1.Push(x + 1);
            //    queue1.Enqueue(x + 1);
            //}

            //Console.WriteLine($"\nThe number of items in the stack is {stack1.Count}");
            //Console.WriteLine($"The number of items in the queue is {queue1.Count}");

            //Console.WriteLine($"\nThe value at the top of the stack is {stack1.Peek()}"); // stack operates on Last In First Out
            //Console.WriteLine($"The value at the front of the queue is {queue1.Peek()}\n"); // queue operates on First In First Out

            //while (stack1.Count > 0)
            //{
            //    Console.WriteLine($"Value at the top of the stack is {stack1.Pop()}");
            //    Console.WriteLine($"The number of items in the stack is {stack1.Count}");
            //}
            //Console.WriteLine();
            //while (queue1.Count > 0)
            //{
            //    Console.WriteLine($"Value at the front of the queue is {queue1.Dequeue()}");
            //    Console.WriteLine($"The number of items in the queue is {queue1.Count}");
            //} 
            #endregion

            // Lists
            #region Lists
            //List<int> list1 = new List<int>();

            //Console.WriteLine($"The list contains {list1.Count} elements");

            //for(int i = 0; i < 100; i++)
            //    list1.Add(i + 1);

            //Console.WriteLine($"\nThe list contains {list1.Count} elements");

            //Console.WriteLine($"\nThe value of the element at index 25 is {list1[25]}");
            //list1[25] = 666;
            //Console.WriteLine($"\nThe value of the element at index 25 is {list1[25]}");

            ////foreach(int i in list1)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //list1 = new List<int>();
            //for(int i = 0; i < 10; i++)
            //{
            //    list1.Add(0);
            //}

            //list1.RemoveAt(0);


            //foreach (int i in list1)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            // Dictionaries
            #region Dictionaries
            //Dictionary<int, string> dictonary = new Dictionary<int, string>();

            //dictonary[0] = "string";
            //dictonary[2] = "string";
            //dictonary[1] = "string";
            //dictonary[7] = "string";

            //Console.WriteLine($"Number of items in dictionary {dictonary.Count}");

            //foreach (KeyValuePair<int, string> kvp in dictonary)
            //    Console.WriteLine($"The key is {kvp.Key}. The value is {kvp.Value}");

            //dictonary[0] = "apple";

            //Console.WriteLine($"Number of items in dictionary {dictonary.Count}");

            //foreach (KeyValuePair<int, string> kvp in dictonary)
            //    Console.WriteLine($"The key is {kvp.Key}. The value is {kvp.Value}"); 
            #endregion


            // >>>>>> Compound data structures / Compound collections

            // arrays 
            // Jagged array or an array within an array
            // Multidimensional array

            //int[][] triangle = new int[5][];

            //for (int x = 0; x < 5; x++)
            //    triangle[x] = new int[x + 1];

            //for(int x = 0; x < triangle.Length; x++)
            //{
            //    for(int y = 0; y < triangle[x].Length; y++)
            //    {
            //        int a = x + 1;
            //        int b = y + 1;
            //        triangle[x][y] = a * b;
            //    }
            //}

            //foreach (int[] a in triangle)
            //{
            //    foreach(int b in a)
            //    {
            //        Console.Write(b + "\t");
            //    }
            //    Console.WriteLine();
            //}

            Stack<int>[] stack1 = new Stack<int>[5];
            Stack<int[]> stack2 = new Stack<int[]>();

            int[,] multiDim = new int[5, 10];
            Console.WriteLine(multiDim.Length); // 50
            Console.WriteLine(multiDim.GetLength(0)); // 5
            Console.WriteLine(multiDim.GetLength(1)); // 10

            int[][,] compount = new int[][,] { };

            Console.ReadKey();
        }
    }
}
