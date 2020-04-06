using System;
using GlobalProgect_1.LinkedLists;
using GlobalProgect_1.DoubleLinkedLists;

namespace GlobalProgect_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ArrayList a = new ArrayList(new int[] { 2, 3, 12, 3, -1, 0 });
            //a.DeleteByValue(3);

            //ArrayList b = new ArrayList(new int[] { 2, 4, 12, 9, -1, 0 });
            //b.AscendingDescending();

            DoubleLinkedList L = new DoubleLinkedList();
            L.Add(new int[] {1, 2, 3,4 });
            qqq(L.ReturnArray());

           





        }

        static void qqq(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

    }
}

