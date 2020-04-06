using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalProgect_1.DoubleLinkedLists
{
    public class DoubleLinkedList : IList
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

        public DoubleLinkedList(int[] a)
        {
            root = new DoubleNode(a[0]);
            DoubleNode tmp = root;
            for (int i = 1; i < a.Length; i++)
            {
                tmp.Next = new DoubleNode(a[i]);
                tmp.Previous = tmp;
                tmp = tmp.Next;
            }
            end = tmp;
            Length = a.Length;
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
                end.Next.Previous = end;
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
                    tmp.Next.Previous = tmp;
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
                    tmp.Next.Previous = tmp;
                    tmp = tmp.Next;
                }
                end = tmp;
                Length += a.Length;
            }
        }

        public void AddFirst(int a)// добавление значения в начало
        {
            if (Length == 0)
            {
                root = new DoubleNode(a);
                end = root;
                Length = 1;
            }
            else
            {
                root.Previous = new DoubleNode(a);
                root.Previous.Next = root;
                root = root.Previous;
                Length++;
            }
        }

        public void AddFirst(int[] a)// добавление массива в начало
        {
            if (root == null)
            {
                root = new DoubleNode(a[Length - 1]);
                for (int i = a.Length - 2; i >= 0; i--)
                {
                    root.Previous = new DoubleNode(a[i]);
                    root.Previous.Next = root;
                    root = root.Previous;
                }
                Length = a.Length; ;
            }
            else
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    root.Previous = new DoubleNode(a[i]);
                    root.Previous.Next = root;
                    root = root.Previous;
                }
                Length += a.Length; ;
            }
        }
        public void AddIndex(int a, int b) // добавление значения по индексу
        {
            if (root != null && end != null)
            {
                if (a < Length / 2)
                {
                    DoubleNode tmp = root;
                    for (int i = 0; i < a-1; i++)
                    {
                        tmp = tmp.Next;
                    }
                    DoubleNode q = tmp.Next;
                    q.Previous = tmp;
                    tmp.Next = new DoubleNode(b);
                    tmp.Next.Previous = tmp;
                    tmp.Next.Next = q;
                    q.Previous = tmp.Next;
                    Length++;
                }
                else
                {
                    DoubleNode tmp = end;
                    for (int i = Length; i > a+1; i--)
                    {
                        tmp = tmp.Previous;
                    }
                    DoubleNode q = tmp.Previous;
                    q.Next = tmp;
                    tmp.Previous = new DoubleNode(b);
                    tmp.Previous.Next = tmp;
                    tmp.Previous.Previous = q;
                    q.Next = tmp.Previous;
                    Length++;
                }
            }
        }

        public void DelFromBegin() //удаление из начала одного элемента
        {
            if (root != null && root.Next == null)
            {
                root = new DoubleNode(0);
                Length = 1;
            }
            else
            {
                DoubleNode tmp = root.Next;
                tmp.Previous = null;
                root = tmp;
                root.Previous = null;
                Length--;

            }
        }

        public void DelFromEnd() // удаление из конца одного элемента
        {
            if (root == null)
            {
                root = new DoubleNode(0);
                end = root;
                Length = 1;
            }
            else
            {
                end = end.Previous;
                end.Next = null;
                Length--;
            }
        }
        public void DelFromEndNElem(int n)
        {

        }

        public void DelFromBeginNElem(int n) // удаление из начала n-элементов
        { 
        
        }
    }
}
