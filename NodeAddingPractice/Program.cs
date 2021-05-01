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
            //output ==> Node that represents the joined lists
            throw new NotImplementedException();
           
        }
       
        //2.
       public Node<ZipInfo> ZipLinkedList (Node<int> p)
        {
            //input: a Node that represents the first Node in a linked list
            // output : a ZipInfo Node represents the first Node in a linked list
            // example 1,1,1,2,2,5,5,5,5,1,4  ==> (1,3), (2,2), (5,4),(1,1), (4,1)
            throw new NotImplementedException();
            

        }
        //3.
        public static Node<int> DifferentNumbers (int [] ar)
        {
            // input : an array of integers
            //output : a Node represents a linked list of different numbers in array
            // example {1,2,4,1,5,2,6,2,4} ==> 1,2,3,4,5,6
            throw new NotImplementedException();
        
        }
        static bool Found (Node<int> head, int x)
            {
            // input => node<int> representing beginning of linked list and x (a number)
            // output => true if x is found within the linked list
                while (head!=null && head.GetValue()!=x)
                    head = head.GetNext();
                return head !=null;
            }
      
        //4.
       public static  Node<int> GetEvenNumbers (Node<int> p)
        {
            // input : a Node representing a linked list of numbers
            // output : a Node representing a linked list of all the even numbers in the original list
            throw new NotImplementedException();
          
        }
        //5.
        public static void AddAtEnd (Node<int> p, int val)
        {
            //input: a node representing a linked list of numbers and a number
            // output: adding the number at the end of the linked list
            throw new NotImplementedException();
        }

        static void Mystery (Node<int> p)
        {
            if (p == null || p.GetNext() == null || p.GetNext().GetNext() == null)
                return ;
            Node<int> q = p.GetNext();
            if (q.GetValue() >= p.GetValue() == q.GetValue() >= q.GetNext().GetValue())
            { 
                Node<int> t = new Node<int> (q.GetValue(), q);
                p.SetNext(t);
                p = p.GetNext();
            }
            Mystery(p.GetNext());

        }
        static int Sum (Node<int> p)
        {
            if (p == null)
                return 0;
            return p.GetValue() + Sum(p.GetNext());
        }
        static Node<int> EqualCut (Node<int> p)
        {
            int sum = Sum(p);
            Console.WriteLine($"sum: {sum}");
            Node<int> prev = p;
            Node<int> current = p.GetNext();
            int sumFirst =p.GetValue();
            Console.WriteLine($"Temp sum: {sumFirst}");
            while (current != null &&sumFirst + current.GetValue() < sum/2)
            {
                sumFirst += current.GetValue();
                prev = current;
                current = current.GetNext();
                Console.WriteLine($"Temp sum: {sumFirst}");
            }
            if (sum/2 - sumFirst > sumFirst+current.GetValue() -sum/2)
            {
                prev = current;
                current = current.GetNext();
            }
            prev.SetNext(null);
            return current;
        }
        static void Main(string[] args)
        {
            //Node<int> p1 = GenerateLinkedList.CreateRandomList(5, 20);
            //Node<int> p2 = GenerateLinkedList.CreateRandomList(4, 50);
            //GenerateLinkedList.PrintNodes(p1);
            //GenerateLinkedList.PrintNodes(p2);
            //p1 = JoinTwoLinkedList(p1, p2);
            //Node<int> p = GenerateLinkedList.CreateRandomList(new int[] { 1, 1,2, 6, 5, 2, 8, 10 });
            //GenerateLinkedList.PrintNodes(p);
            //Mystery(p);

            //GenerateLinkedList.PrintNodes(p);
            Node<int> p = GenerateLinkedList.CreateRandomList(15, 40);
            GenerateLinkedList.PrintNodes(p);
            Node<int> tem =EqualCut(p);
            Console.WriteLine($"first sum is {Sum(p)}");
            Console.WriteLine($"Second sum is {Sum(tem)}");


            Console.ReadKey();
        }
    }
}
