using System;

namespace NodeChains
{
    class Program
    {
        static void Main(string[] args)
        {
            // +----+------+
            // | 3  | null +
            // +----+------+ 
            Node first = new Node {value = 3};

            // +----+------+  +-------+------+             
            // | 3  | null +  |   5   | null +              
            // +----+------+  +--------------+     

            Node middle = new Node {value = 5};

            // +----+------+     +-------+------+             
            // | 3  | *--- +---->|   5   | null +              
            // +----+------+     +--------------+  
            first.Next = middle;

            // +----+------+     +-------+------+   +-----+------+     
            // | 3  | *--- +---->|   5   | null +   |  7  | null +      
            // +----+------+     +--------------+   +------------+
            Node last = new Node{value = 7};

            // +----+------+     +-------+------+    +-----+------+     
            // | 3  | *--- +---->|   5   | *----+--->|  7  | null +      
            // +----+------+     +--------------+    +------------+
            middle.Next = last;

            
            //now itarete over each node and print the value
            PrintList(first);

        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.Next;

            }
        }
    }
}
