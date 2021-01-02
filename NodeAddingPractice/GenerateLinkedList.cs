using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace NodeAddingPractice
{
    class GenerateLinkedList
    {
        #region GenerateList
        static private Random rnd = new Random();
        public static Node<int> CreateRandomList(int size = 10, int limit = 100)
        {
            Node<int> head = null;
            for (int i = 0; i < size; i++)
                head = new Node<int>(rnd.Next(limit) + 1, head);
            return head;

        }
        public static Node<int> CreateRandomList(int[] ar)
        {
            Node<int> dummy = new Node<int>(-1);
            Node<int> last = dummy;
            foreach (int x in ar)
            {
                last.SetNext(new Node<int>(x));
                last = last.GetNext();
            }
            return dummy.GetNext();
        }
        public static void PrintNodes(Node<int> p)
        {
            Console.Write("[");
            if (p != null)
            {
                Console.Write(p.GetValue());
                p = p.GetNext();
            }
            while (p != null)
            {
                Console.Write($",{p.GetValue()}");
                p = p.GetNext();
            }
            Console.WriteLine("]");
        }
        public static Node<int> GetSortedList(int size = 10, int limit = 100)
        {
            Node<int> p = CreateRandomList(size, limit);
            p = Sort(p);
            return p;
        }
        private static Node<int> Sort(Node<int> p)
        {
            Node<int> dummy = new Node<int>(-1);
            while (p != null)
            {
                Node<int> q = p.GetNext();
                AddSorted(dummy, p);
                p = q;
            }
            return dummy.GetNext();
        }
        private static void AddSorted(Node<int> first, Node<int> last)
        {
            Node<int> previous = first;
            first = first.GetNext();
            while (first != null && first.GetValue() < last.GetValue())
            {
                previous = first;
                first = first.GetNext();
            }
            last.SetNext(first);
            previous.SetNext(last);
        }
        #endregion
    }
}
