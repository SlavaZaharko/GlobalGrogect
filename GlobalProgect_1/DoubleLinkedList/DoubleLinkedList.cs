using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalProgect_1.DoubleLinkedList
{
    public class DoubleLinkedList//:IList
    {
        private DoubleNode root;
        private DoubleNode end;
        public int Length { get; set; }

        public DoubleLinkedList()
        {
            root = null;
            end = null;
            Length = 0;
        }

        public DoubleLinkedList(int a)
        {
            root = new DoubleNode(a);
            end = root;
            Length = 1;
        }

        public int[] ReturnArray()//возврат массива
        {
            int[] array = new int[Length];
            if (Length != 0)
            {
                int i = 0;
                DoubleNode tmp = root;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                } while (tmp != null);
            }
            return array;
        }

        public void Add(int a) // добавление значения в конец списка
        {
            if (root == null)
            {
                root = new DoubleNode(a);
                end = root;
                Length = 1;
            }

            else
            {
                end.Next = new DoubleNode(a);
                end.Next.Previos = end;
                end = end.Next;
                Length++;
            }
        }
        public void Add(int[] a) // добавление массива в конец списка
        {
            if (root == null)
            {
                root = new DoubleNode(a[0]);
                DoubleNode tmp = root;
                for (int i = 1; i < a.Length; i++)
                {
                    tmp.Next = new DoubleNode(a[i]);
                    tmp.Previos = tmp;
                    tmp = tmp.Next;
                }
                end = tmp;
                Length = a.Length;
            }

            else
            {
                DoubleNode tmp = end;
                for (int i = 0; i < a.Length; i++)
                {
                    tmp.Next = new DoubleNode(a[i]);
                    tmp.Previos = tmp;
                    tmp = tmp.Next;
                }
                end = tmp;
                Length += a.Length;
            }
        }

        public void AddFirst(int a)// добавление значения в начало
        {
            DoubleNode tmp = new DoubleNode(a);
            root.Previos = tmp;
            tmp.Next = root;
            root = tmp;
        }

        public void AddFirst(int[] a)// добавление значения в начало
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                DoubleNode tmp = new DoubleNode(a[i]);
                root.Previos = tmp;
                tmp.Next = root;
                root = tmp;
            }
            Length += a.Length; ;
        }
        public void AddIndex(int a, int b) // добавление значения по индексу
        {
            if (root != null && root.Next != null)
            {
                DoubleNode tmp = root;
                for (int i = 1; i < a; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Next.Previos = tmp;
                DoubleNode q = tmp.Next;
                tmp.Next = new DoubleNode(b);
                tmp.Next.Next = q;
                Length++;
            }
        }
    }
}
