using NUnit.Framework;
using GlobalProgect_1;
using GlobalProgect_1.LinkedLists;
using GlobalProgect_1.DoubleLinkedList;

namespace ListTest
{
    [TestFixture(1)]
    [TestFixture(2)]
    //[TestFixture(3)]
    public class ListTest
    {
        IList list;
        int q;

        public ListTest(int _q)
        {
            q = _q;
        }

        [SetUp]
        public void ListSelect()
        {
            switch (q)
            {
                case 1:
                    list = new ArrayList();
                    break;
                case 2:
                    list = new LinkedList();
                    break;
                    //case 3:
                    //    list = new DoubleLinkedList();
                    //    break;

            }
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, ExpectedResult = new int[] { 1, 2, 3, 4 })]
        public int[] AddTest(int[] array, int a)
        {
            list.Add(array);
            list.Add(a);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3 }, 0, ExpectedResult = new int[] { 0, 1, 2, 3 })]
        public int[] AddFirstTest(int[] array, int a)
        {
            list.Add(array);
            list.AddFirst(a);
            return list.ReturnArray();
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { -3, -2, -1, 0 }, ExpectedResult = new int[] { -3, -2, -1, 0, 1, 2, 3 })]
        public int[] AddFirstTest(int[] array, int[] a)
        {
            list.Add(array);
            list.AddFirst(a);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, 5, ExpectedResult = new int[] { 1, 2, 5, 3, 4 })]
        public int[] AddIndexTest(int[] array, int a, int b)
        {
            list.Add(array);
            list.AddIndex(a, b);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 1, 2, 3 })]
        public int[] DelFromEndTest(int[] array)
        {
            list.Add(array);
            list.DelFromEnd();
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 2, 3, 4 })]
        public int[] DelFromBegindTest(int[] array)
        {
            list.Add(array);
            list.DelFromBegin();
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, ExpectedResult = new int[] { 1, 2, 4 })]
        public int[] DelByIndexTest(int[] array, int a)
        {
            list.Add(array);
            list.DelByIndex(a);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, ExpectedResult = 3)]
        public int AccessIndexTest(int[] array, int a)
        {
            list.Add(array);
            return list.AccessIndex(a);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1, ExpectedResult = 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 5, ExpectedResult = -1)]
        public int AccessByValueTest(int[] array, int a)
        {
            list.Add(array);
            return list.AccessByValue(a);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 8, ExpectedResult = new int[] { 1, 2, 8, 4, 5 })]
        public int[] ChangesByIndexTest(int[] array, int a, int b)
        {
            list.Add(array);
            list.ChangesByIndex(a, b);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 4)]
        public int SearchMaxElemTest(int[] array)
        {
            list.Add(array);
            return list.SearchMaxElem();
        }

        [TestCase(new int[] { 51, 20, 33, 14 }, ExpectedResult = 14)]
        public int SearchMinElemTest(int[] array)
        {
            list.Add(array);
            return list.SearchMinElem();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 3)]
        public int SearchIndexMaxElemTest(int[] array) 
        {
            list.Add(array);
            return list.SearchIndexMaxElem();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 0)]
        public int SearchIndexMinElemTest(int[] array)
        {
            list.Add(array);
            return list.SearchIndexMinElem();
        }
    }
}