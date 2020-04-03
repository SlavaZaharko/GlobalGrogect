using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalProgect_1.LinkedLists
{
    public class LinkedList: IList
    {
        private Node root;
        public int Lenght { get; private set; }

        public LinkedList()
        {
            root = null;
            Lenght = 0;
        }
        public LinkedList(int a)
        {
            root = new Node(a);
            Lenght = 1;
        }

        public int[] ReturnArray()//возврат массива
        {
            int[] array = new int[Lenght];
            if (Lenght != 0)
            {
                int i = 0;
                Node tmp = root;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                } while (tmp != null);
            }
            return array;
        }

        public void Add(int a)//добавление значения в конец
        {
            if (root == null)
            {
                root = new Node(a);
                Lenght = 1;
            }
            else if (root != null && root.Next == null)
            {
                root.Next = new Node(a);
                Lenght++;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(a);
                Lenght++;
            }
        }

        public void Add(int[] a)//добавление массива в конец
        {
            if (root == null)
            {
                root = new Node(a[0]);
                Node tmp = root;
                for (int i = 1; i < a.Length; i++)
                {
                    tmp.Next = new Node(a[i]);
                    tmp = tmp.Next;
                }
                Lenght = a.Length;
            }
            else if (root != null && root.Next == null)
            {
                Node tmp = root.Next;
                for (int i = 0; i < a.Length; i++)
                {
                    tmp.Next = new Node(a[i]);
                    tmp = tmp.Next;
                }
                Lenght+= a.Length;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                Node q=tmp.Next;
                for (int i = 0; i < a.Length; i++)
                {
                    q.Next = new Node(a[i]);
                    q = q.Next;
                }
                Lenght +=a.Length;
            }
        }


        public void AddFirst(int a)// добавление значения в начало
        {
            Node tmp = new Node(a);
            tmp.Next = root;
            root = tmp;
            Lenght++;
        }

        public void AddFirst(int[] a)// добавление массива в начало
        {
            for (int i = 0; i < a.Length; i++)
            {
                Node tmp = new Node(a[i]);
                tmp.Next = root;
                root = tmp;
            } 
            Lenght++;

        }




        public void AddIndex(int a, int b) // добавление значения по индексу
        {
            if (root != null && root.Next != null)
            {
                Node tmp = root;
                for (int i = 1; i < a; i++)
                {
                    tmp = tmp.Next;
                }
               // for
               // { 

                Node q = tmp.Next;
                tmp.Next = new Node(b);
                tmp.Next.Next = q;
               // tmp = tmp.Next;
                //}
                Lenght++;
            }

        
        }

        public void DelFromEnd() // удаление из конца одного элемента 
        {
            Node tmp = root;
            while (tmp.Next.Next!= null)
            {
                tmp = tmp.Next.Next;
            }
            tmp.Next = tmp.Next.Next;
            Lenght--;
        }

        public void DelFromBegin() //удаление из начала одного элемента
        {
            Node tmp = root.Next;
            root = tmp;
            Lenght--;
        }


    }
}
