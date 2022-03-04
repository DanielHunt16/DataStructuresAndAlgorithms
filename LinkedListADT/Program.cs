using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListADT
{
    public unsafe class Node 
    {
        private int data { get; set; }
        private IntPtr next { get; set; }

        public Node(int value, IntPtr pointer)
        {
            data = value;
            next = pointer;
        }

        public void ChangePtr (IntPtr pointer)
        {
            next = pointer;
        }

        public override string ToString()
        {           
            return $"Data: {data}\nAddress of Next: {next.ToString()}";
        }
    }  
    
    public class LinkedList
    {
        private List<Node> nodes { get; set; }

        public LinkedList()
        {
            nodes = new List<Node>();
        }

        public void Add(int value)
        {
            if (IsEmpty())
            {
                nodes.Add(new Node(value, IntPtr.Zero));
            }
            else
            {
                nodes.Add(new Node(value, IntPtr.Zero));
                IntPtr ptr = ConvertToPointer(nodes[nodes.Count - 1]);
                nodes[nodes.Count - 2].ChangePtr(ptr);
            }
        }

        public bool IsEmpty()
        {
            return nodes.Count == 0;
        }

        private IntPtr ConvertToPointer(Node node)
        {
            int size = MarshalAsAttribute.SizeConst 
            IntPtr arrPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(node, arrPtr, true);

            return arrPtr;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            for(int i = 0; i < nodes.Count; i++)
            {
                sb.Append(nodes[i].ToString());
                sb.Append("\n");
            }           
            
            return sb.ToString();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(55);
            linkedList.Add(4754);
            linkedList.Add(67676);

            Console.WriteLine(linkedList.ToString());

            Console.ReadLine();
        }
    }
}
