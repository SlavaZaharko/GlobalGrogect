using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalProgect_1
{
    public interface IList
    {
        public int[] ReturnArray();
        public void Add(int a); // добавление элемента в конец массива 
        public void Add(int[] a); // добавление массива в конец массива 
        public void AddFirst(int a); //добавление в начало массива 
        public void AddFirst(int[] a); //добавлене массива в начало массива 
        public void AddIndex(int a, int b); // добавление значения по индексу 
        //public void AddIndex(int a, int[] b); // добавление массива по индексу 
        public void DelFromEnd(); // удаление из конца одного элемента 
        public void DelFromEndNElem(int n); // удаление из конца n-элементов 
        public void DelFromBegin(); //удаление из начала одного элемента 
        public void DelFromBeginNElem(int n); // удаление из начала n-элементов 
        //public void DelByIndex(int a); //удаление элемента по индексу 
        ////public void DelByIndexNElem(int a, int n); //удаление элемента по индексу n-элементов
        //public int AccessIndex(int a);// вывод элемента по индексу 
        //public int AccessByValue(int a);// вывод индекса по значению
        //public void ChangesByIndex(int a, int b); // изменения по индексу
        //public void RevMassive();// ревес массива
        //public int SearchMaxElem();// поиск максималного значения 
        //public int SearchMinElem(); // поиск минимального значения 
        //public int SearchIndexMaxElem();//поиск индекса мах значения 
        //public int SearchIndexMinElem();//поиск индекса минимального значения 
        //public void SortAscendElem();//сортировка по возрастанию 
        //public int ReturnLengthMassiva();//возврат длины массива
        ////public void ReturnMassive();// возврат массива
        //public void DeleteByValue(int a);// удаление по значению
    }
}
