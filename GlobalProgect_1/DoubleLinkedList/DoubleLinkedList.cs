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
            if (a.Length != 0)
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

        public void AddIndex(int a, int[] b)//добавление массива по индексу
        {
            if (root != null && end != null)
            {
                if (a < Length / 2)
                {
                    DoubleNode tmp = root;
                    for (int i = 0; i < a - 1; i++)
                    {
                        tmp = tmp.Next;
                    }
                    for (int j = 0; j < b.Length; j++)
                    {
                    DoubleNode q = tmp.Next;
                    q.Previous = tmp;
                    tmp.Next = new DoubleNode(b[j]);
                    tmp.Next.Previous = tmp;
                    tmp = tmp.Next;
                    tmp.Next = q;
                    q.Previous = tmp;
                    }
                    Length +=b.Length;
                }
                else
                {
                    DoubleNode tmp = end;
                    for (int i = Length; i > a+1 ; i--)
                    {
                        tmp = tmp.Previous;
                    }
                    for (int j = 0; j < b.Length; j++)
                    {
                        DoubleNode q = tmp.Previous;
                        q.Next = tmp;
                        tmp.Previous = new DoubleNode(b[j]);
                        tmp.Previous.Next = tmp;
                        tmp.Previous.Previous = q;
                        q.Next = tmp.Previous;
                    }
                    Length += b.Length;
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

        public void DelByIndex(int a) //удаление элемента по индексу
        {
            if (root != null && end != null) { 
                if (a < Length / 2)
                {
                    DoubleNode tmp = root;
                    for (int i = 1; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    DoubleNode q = tmp.Next.Next;
                    q.Previous.Previous = tmp;
                    q.Previous = null;
                    tmp.Next = null;
                    tmp.Next = q;
                    Length--;
                }
                else 
                {
                    DoubleNode tmp = end;
                    for (int i = Length-1; i > a+1; i--)
                    {
                        tmp = tmp.Previous;
                    }
                    DoubleNode q = tmp.Previous.Previous;
                    q.Next.Next = tmp;
                    q.Next = null;
                    tmp.Previous = null;
                    q.Next = tmp;
                    Length--;
                }
            }
        }

        public int AccessIndex(int a)// вывод элемента по индексу 
        {
            int n = root.Value;
            if (root != null && end != null)
            {
                if (a < Length / 2)
                {
                    DoubleNode tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    n = tmp.Value;
                }
                else
                {
                    DoubleNode tmp = end;
                    for (int i = Length-1; i > a; i--)
                    {
                        tmp = tmp.Previous;
                    }
                    n = tmp.Value;
                }
            }
            return n;
        }

        public int AccessByValue(int a)// вывод индекса по значению
        {
            int index = 0;
            DoubleNode tmp = root;
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
            if (root != null && end != null)
            {
                if (a < Length / 2)
                {
                    DoubleNode tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Value=b;
                }
                else
                {
                    DoubleNode tmp = end;
                    for (int i = Length - 1; i > a; i--)
                    {
                        tmp = tmp.Previous;
                    }
                    tmp.Value = b;
                }
            }
        }

        public int SearchMaxElem()// поиск максималного значения
        {
            DoubleNode tmp = root;
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
        
        public int SearchMinElem() // поиск минимального значения 
        {
            DoubleNode tmp = root;
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
            DoubleNode tmp = root;
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
        
        public int SearchIndexMinElem()//поиск индекса минимального значения
        {
            int i_min = 0;
            DoubleNode tmp = root;
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

        public void DeleteByValue(int a)// удаление по значению
        {
            DoubleNode tmp = root;
            if (tmp.Value == a)
            {
                DelFromBegin();
            }
            else
            {
                while (tmp.Next != null)
                {
                    if (tmp.Next.Value == a)
                    {
                        DoubleNode q = tmp.Next.Next;
                        q.Previous.Previous = tmp;
                        q.Previous = null;
                        tmp.Next = null;
                        tmp.Next = q;
                        Length--;
                    }
                    else
                    {
                        tmp = tmp.Next;
                    }
                }
            }
        }

        public int ReturnLengthMassiva()//возврат длины массива
        {
            DoubleNode tmp = root;
            int ilength = 1;
            if (tmp == null)
            {
                ilength = 0;
            }
            else if (tmp != null && tmp.Next == null)
            {
                ilength = 1;
            }
            else if (tmp != null && tmp.Next != null)
            {
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                    ilength++;
                }
            }
            return ilength;
        }

        public void RevMassive()// ревес массива
        {
            if (root != null && end != null)
            {
                DoubleNode tmp = root;
                tmp.Previous = tmp.Next;
                tmp.Next = null;
                tmp = tmp.Previous;

            while (root.Previous!=null)
                {
                    tmp.Previous = tmp.Next;
                    tmp.Next = root;
                    root = tmp;
                    tmp = tmp.Previous;         
                }
                while (end.Next != null) 
                {
                    end = end.Next;
                }
            }
        }


        public void DelFromEndNElem(int n) // удаление из конца n-элементов 
        {
            if (Length > n)
            {
                for (int i = 0; i < n; i++)
                {
                    end = end.Previous;
                    end.Next = null;
                    Length--;
                }
            }
        }

        public void DelFromBeginNElem(int n) // удаление из начала n-элементов
        {
            if (Length > n) 
            {
                for (int i = 0; i < n; i++)
                {
                    DoubleNode tmp = root.Next;
                    tmp.Previous = null;
                    root = tmp;
                    root.Previous = null;
                    Length--;
                }
            }
        }

        public void DelByIndexNElem(int a, int n)
        {
            if (root != null && end != null)
            {
                if (a < Length / 2)
                {
                    DoubleNode tmp = root;
                    for (int i = 1; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    for (int j = 0; j < n; j++)
                    {
                        DoubleNode q = tmp.Next.Next;
                        q.Previous.Previous = tmp;
                        q.Previous = null;
                        tmp.Next = null;
                        tmp.Next = q;
                        Length--;
                    }
                }
                else
                {
                    DoubleNode tmp = end;
                    for (int i = Length - 1; i > a + 1; i--)
                    {
                        tmp = tmp.Previous;
                    }
                    for (int j = 0; j < n; j++)
                    {
                        DoubleNode q = tmp.Previous.Previous;
                        q.Next.Next = tmp;
                        q.Next = null;
                        tmp.Previous = null;
                        q.Next = tmp;
                        Length--;
                    }
                }
            }
        }

        public void SortAscendElem()
        {         
            DoubleNode newRoot = null;
            DoubleNode newEnd = null;

            for (int j=0; j<Length;j++)
            {
                DoubleNode tmp = root;
                DoubleNode a = root;

                while (tmp!=null)
                {
                    if (a.Value > tmp.Value)
                    {
                        a = tmp;
                    }
                    tmp = tmp.Next;
                }

                if (a!=root)
                {
                    DelFromBegin();
                }
                else if (a!=end)
                {
                    DelFromEnd();
                }
                else
                {
                    a.Previous.Next = a.Next;
                    a.Next.Previous = a.Previous;
                }
               

                a.Next = null;
                a.Previous = null;

                if (newRoot == null)
                {
                    newRoot = a;
                    newEnd = newRoot;
                }
                else
                {
                    newEnd.Next = a;
                    newEnd.Next.Previous = newEnd;
                    newEnd = newEnd.Next;
                }

            }
            root = newRoot;
            end = newEnd;
        }

        public void AscendingDescending()
        {

            if (root != null && end != null)
            {
                if (root != null && root.Next == end)
                {
                    DoubleNode tmpRoot = root;
                    DoubleNode tmpEnd = end;
                    if (root.Value < end.Value)
                    {
                        tmpRoot.Next = null;
                        tmpRoot.Previous = tmpEnd;
                        tmpEnd.Previous = null;
                        tmpEnd.Next = tmpRoot;
                        root = tmpEnd;
                        end = tmpRoot;

                    }
                    else 
                    {
                        root = tmpRoot;
                        end = tmpEnd;
                    }
                }
                else
                {
                    for (int i = Length - 1; i > 0; i--)
                    {
                        DoubleNode tmpRoot = root;
                        DoubleNode tmp = root.Next;
                        if (tmpRoot.Value < tmp.Value)
                        {
                            tmpRoot.Next = tmpRoot.Next.Next;
                            tmp.Next = tmpRoot;
                            tmpRoot.Previous = tmp;
                            tmp.Previous = null;
                            root = tmp;
                        }
                        else
                        {
                            while (tmp.Next!=null)
                            {

                                if (tmp.Value > tmp.Next.Value)
                                {
                                    DoubleNode q = tmp.Next;
                                    DoubleNode b = tmp.Previous;
                                    tmp.Next = tmp.Next.Next;
                                    tmp.Previous.Next = q;
                                    q.Previous = tmp.Previous;
                                    q.Next = tmp;
                                    tmp.Previous = q;
                                }
                                else
                                {
                                    tmp = tmp.Next;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
