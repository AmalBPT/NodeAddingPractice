using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;
using GenerateLinkedList;


namespace NodeAddingPractice
{
    class Program
    {
        //1.
        static Node<int> JoinTwoLinkedList (Node<int>p1, Node<int> p2)
        {
            //input ==> 2 Nodes that represent 2 linked lists
            //output ==> Node that represents the 
            throw new NotImplementedException();
        }
        //2.
        static Node<int> PutInPlace (Node<int> head, int place, int value)
        {
            //input : Node representing the beginning of the LinkedList, place : the place to place , value: the value to add
            // assumption: place is within the list
            // output: Node representing the beginning of the Linked list after adding the new value
            throw new NotImplementedException();
        }
        //3.
       public Node<ZipInfo> ZipLinkedList (Node<int> p)
        {
            //input: a Node that represents the first Node in a linked list
            // output : a ZipInfo Node represents the first Node in a linked list
            // example 1,1,1,2,2,5,5,5,5,1,4  ==> (1,3), (2,2), (5,4),(1,1), (4,1)
            throw new NotImplementedException();
        }
        //4.
        public Node<int> DifferentNumbers (int [] ar)
        {
            // input : an array of integers
            //output : a Node represents a linked list of different numbers in array
            // example {1,2,4,1,5,2,6,2,4} ==> 1,2,3,4,5,6
            throw new NotImplementedException();
        }
        //5.
       public static  Node<int> GetEvenNumbers (Node<int> p)
        {
            // input : a Node representing a linked list of numbers
            // output : a Node representing a linked list of all the even numbers in the original list
            throw new NotImplementedException();
        }
        //6.
        public static void AddAtEnd (Node<int> p, int val)
        {
            //input: a node representing a linked list of numbers and a number
            // output: adding the number at the end of the linked list
            throw new NotImplementedException();
        }


        static void Main(string[] args)
        {
            Node<int> p = GenerateLinkedList.GetSortedList(10, 50);
            GenerateLinkedList.PrintNodes(p);
            Console.ReadKey();
        }
    }
}
