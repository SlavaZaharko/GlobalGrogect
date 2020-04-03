﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalProgect_1.LinkedLists
{
    public class LinkedList : IList
    {
        private Node root;
        public int Length { get; private set; }

        public LinkedList()
        {
            root = null;
            Length = 0;
        }
        public LinkedList(int a)
        {
            root = new Node(a);
            Length = 1;
        }

        public int[] ReturnArray()//возврат массива
        {
            int[] array = new int[Length];
            if (Length != 0)
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
                Length = 1;
            }
            else if (root != null && root.Next == null)
            {
                root.Next = new Node(a);
                Length++;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(a);
                Length++;
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
                Length = a.Length;
            }
            else if (root != null && root.Next == null)
            {
                Node tmp = root.Next;
                for (int i = 0; i < a.Length; i++)
                {
                    tmp.Next = new Node(a[i]);
                    tmp = tmp.Next;
                }
                Length += a.Length;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                Node q = tmp.Next;
                for (int i = 0; i < a.Length; i++)
                {
                    q.Next = new Node(a[i]);
                    q = q.Next;
                }
                Length += a.Length;
            }
        }


        public void AddFirst(int a)// добавление значения в начало
        {
            Node tmp = new Node(a);
            tmp.Next = root;
            root = tmp;
            Length++;
        }

        public void AddFirst(int[] a)// добавление массива в начало
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Node tmp = new Node(a[i]);
                tmp.Next = root;
                root = tmp;
            }
            Length += a.Length;

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
                Node q = tmp.Next;
                tmp.Next = new Node(b);
                tmp.Next.Next = q;
                Length++;
            }
        }

        public void DelFromEnd() // удаление из конца одного элемента 
        {
            Node tmp = root;
            while (tmp.Next.Next != null)
            {
                tmp = tmp.Next.Next;
            }
            tmp.Next = tmp.Next.Next;
            Length--;
        }

        public void DelFromBegin() //удаление из начала одного элемента
        {
            Node tmp = root.Next;
            root = tmp;
            Length--;
        }

        public void DelByIndex(int a) //удаление элемента по индексу 
        {
            if (root != null && root.Next != null)
            {
                Node tmp = root;
                for (int i = 1; i < a; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = tmp.Next.Next;
                Length--;
            }
        }

        public int AccessIndex(int a)// вывод элемента по индексу 
        {

            Node tmp = root;
            for (int i = 0; i < a; i++)
            {
                tmp = tmp.Next;
            }
            return tmp.Value;
        }

        public int AccessByValue(int a)// вывод элемента по индексу 
        {
            int index = 0;
            Node tmp = root;
            while (tmp != null)
            {
                if (tmp.Value == a)
                {
                    return index;
                }
                else
                {
                    tmp = tmp.Next;
                    index++;
                }
            }
            return -1;
        }

        public void ChangesByIndex(int a, int b) // изменения по индексу
        {

            Node tmp = root;
            for (int i = 0; i < a; i++)
            {
                tmp = tmp.Next;
            }

            tmp.Value = b;
        }

        public int SearchMaxElem()// поиск максималного значения 
        {

            Node tmp = root;
            int max = root.Value;
            for (int i = 0; i < Length; i++)
            {
                if (max < tmp.Value)
                {
                    max = tmp.Value;
                }
                tmp = tmp.Next;
            }
            return max;
        }

        public int SearchMinElem()// поиск минимального значения 
        {

            Node tmp = root;
            int min = root.Value;
            for (int i = 0; i < Length; i++)
            {
                if (min > tmp.Value)
                {
                    min = tmp.Value;
                }
                tmp = tmp.Next;
            }
            return min;
        }

        public int SearchIndexMaxElem()//поиск индекса мах значения 
        {
            int i_max = 0;
            Node tmp = root;
            int max = root.Value;
            for (int i = 0; i < Length; i++)
            {
                if (max < tmp.Value)
                {
                    max = tmp.Value;
                    i_max++;
                }
                tmp = tmp.Next;
            }
            return i_max;
        }

        public int SearchIndexMinElem()//поиск индекса min значения 
        {
            int i_min = 0;
            Node tmp = root;
            int min = root.Value;
            for (int i = 0; i < Length; i++)
            {
                if (min > tmp.Value)
                {
                    min = tmp.Value;
                    i_min++;
                }
                tmp = tmp.Next;
            }
            return i_min;
        }
    }
}
