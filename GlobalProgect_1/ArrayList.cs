using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalProgect_1
{
    public class ArrayList : IArrayList
    {
        private int[] array;
        private int length;

        public int this[int a]
        {
            get { return array[a]; }
            set { array[a] = value; }
        }

        public int[] ReturnArray()
        {
            int[] arrayToReturn = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrayToReturn[i] = array[i];
            }
            return arrayToReturn;
        }

        public ArrayList() //конструктор класса 
        {
            array = new int[0];
            length = 0;
        }

        public ArrayList(int a) //конструктор класса 
        {
            array = new int[1] { a };
            length = 1;
        }

        public ArrayList(int[] a) //конструктор класса 
        {
            array = a;
            length = a.Length;
        }


        private void UpArraySiza() //расширение массива  
        {
            int newL = Convert.ToInt32(array.Length * 1.3 + 1);
            int[] newArray = new int[newL];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public void Add(int a) // добавление элемента в конец массива 
        {
            if (length >= array.Length)
            {
                UpArraySiza();
            }
            array[length] = a;
            length++;
        }

        public void Add(int[] a) // добавление массива в конец массива 
        {
            while (length + a.Length > array.Length)
            {
                UpArraySiza();
            }
            for (int i = 0; i < a.Length; i++)
            {
                array[length + i] = a[i];
            }
            length += a.Length;
        }

        public void AddFirst(int a) //добавление в начало массива 
        {
            if (length >= array.Length)
            {
                UpArraySiza();
            }
            for (int i = length - 1; i >= 0; i--)
            {
                array[i + 1] = array[i];
            }
            array[0] = a;
            length++;
        }

        public void AddFirst(int[] a) //добавлене массива в начало массива 
        {
            while (length + a.Length > array.Length)
            {
                UpArraySiza();
            }
            for (int i = length + a.Length - 2; i >= 0; i--)
            {
                array[i + a.Length] = array[i];
            }
            for (int j = 0; j < a.Length; j++)
            {
                array[j] = a[j];
            }
            length += a.Length;
        }

        public void AddIndex(int a, int b) // добавление значения по индексу 
        {
            if (length >= array.Length)
            {
                UpArraySiza();
            }
            length++;
            for (int i = length - 1; i >= a; i--)
            {
                array[i + 1] = array[i];
            }
            array[a] = b;
        }

        public void AddIndex(int a, int[] b) // добавление массива по индексу 
        {
            if (length + b.Length > array.Length)
            {
                UpArraySiza();
            }
            for (int i = a; i < length + b.Length - 2; i++)
            {
                array[i + b.Length] = array[i];
            }
            for (int j = 0; j <= b.Length - 1; j++)
            {
                array[a + j] = b[j];
            }
            length += b.Length;

        }


        public void DelFromEnd() // удаление из конца одного элемента 
        {
            length--;
            array[length] = 0;
        }

        public void DelFromEndNElem(int n) // удаление из конца n-элементов 
        {
            length -= n;
        }


        public void DelFromBegin() //удаление из начала одного элемента 
        {
            for (int i = 0; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            length--;
        }

        public void DelFromBeginNElem(int n) // удаление из начала n-элементов 
        {
            for (int i = 0; i <= n; i++)
            {
                array[i] = array[i + n];
            }
            length -= n;
        }

        public void DelByIndex(int a) //удаление элемента по индексу 
        {
            for (int i = a; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            length--;
        }

        public void DelByIndexNElem(int a, int n) //удаление элемента по индексу n-элементов
        {
            for (int i = a; i < length - n; i++)
            {
                array[i] = array[i + n];
            }
            length -= n;
        }

        public int AccessIndex(int a)// вывод элемента по индексу 
        {
            return array[a];
        }

        public int AccessByValue(int a)// вывод индекса по значению
        {
            int i_index = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] == a)
                {
                    i_index = i;
                }
            }
            return i_index;
        }

        public void ChangesByIndex(int a, int b) // изменения по индексу
        {
            for (int i = length - 1; i >= 0; i++)
            {
                if (i == a)
                {
                    array[i + 1] = array[i];
                }
            }
            array[a] = b;
        }

        public void RevMassive()// ревес массива
        {
            int tmp = 0;
            if (length % 2 != 0)
            {
                for (int i = 0; i <= length / 2; i++)
                {
                    tmp = array[i];
                    array[i] = array[length - 1 - i];
                    array[length - 1 - i] = tmp;
                }
            }
            else
            {
                for (int j = 0; j < length / 2; j++)
                {
                    tmp = array[j];
                    array[j] = array[length - 1 - j];
                    array[length - 1 - j] = tmp;
                }
            }

        }

        public int SearchMaxElem()// поиск максималного значения 
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public int SearchMinElem()// поиск минимального значения 
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public int SearchIndexMaxElem()//поиск индекса мах значения 
        {
            int max = array[0];
            int i_max = 0;

            for (int i = 0; i < length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    i_max = i;
                }
            }
            return i_max;
        }

        public int SearchIndexMinElem()//поиск индекса минимального значения 
        {
            int min = array[0];
            int i_min = 0;
            for (int i = 0; i < length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    i_min = i;
                }
            }
            return i_min;
        }

        public void SortAscendElem()//сортировка по возрастанию 
        {
            int tmp;
            for (int n = 0; n < length; n++)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
            }
        }

        public void AscendingDescending()// сортировка по убыванию
        {
            int max, temp;
            for (int i = 0; i <= length-1; i++)
            {
                max = i;
                for (int j = i; j < length; j++)
                {
                    if (array[j] > array[max])
                    {
                        max = j;
                    }
                }
                    temp = array[i];
                    array[i] = array[max];
                    array[max] = temp;
            }
        }


        public int ReturnLengthMassiva()//возврат длины массива
        {
            int i = length;
            return i;
        }


        public void DeleteByValue(int a)// удаление по значению
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i] == a) 
                {
                    for (int j=i; j<length-1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    length--;
                }
            }
            
        }

        public void ReturnMassive()// возврат массива
        {
            int[] newMassive = new int[length];
            for (int i = 0; i< length - 1; i++)
            {
                newMassive[i] = array[i];
            }
            array = newMassive;
        }

    }

}